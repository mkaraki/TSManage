using Mono.Options;
using System.Text;
using TSManage.Shared;
using TSManageCLI;
using YamlDotNet.Serialization;

Console.OutputEncoding = Encoding.UTF8;

string? ruleFile = null;
string? action = null;
bool showHelp = false;
bool verbose = false;
bool dryRun = false;

var p = new OptionSet() {
    {"r|rule=", "Rule file", v => ruleFile = v},
    {"a|action=", "Actions (COPY, MOVE, DELETE)", v => action = v},
    {"d|dry", "Dry run (just information)", v => dryRun = v != null},
    {"v|verbose", "Verbose information", v => verbose = v != null},
    {"h|help", "Show help", v => showHelp = v != null},
};

p.Parse(args);

if (showHelp)
{
    Console.WriteLine("TSManageCLI.exe [-h] [-d] -r rule.yaml -a {COPY|MOVE|DELETE}");
    p.WriteOptionDescriptions(Console.Out);
    return;
}

if (ruleFile == null || !File.Exists(ruleFile))
{
    Environment.Exit((int)ExitCodes.NO_RULE_FILE_EXIST);
    return;
}

string ruleyaml = await File.ReadAllTextAsync(ruleFile, System.Text.Encoding.UTF8);
var yamld = new DeserializerBuilder().Build();
var rules = yamld.Deserialize<Rule[]>(ruleyaml);

ActionEnum actionenum = ActionEnum.PREVIEW;

switch (action?.ToLower())
{
    case "copy":
        actionenum = ActionEnum.COPY;
        break;

    case "move":
        actionenum = ActionEnum.MOVE;
        break;

    case "delete":
        actionenum = ActionEnum.DELETE;
        break;

    default:
        Environment.Exit((int)ExitCodes.NOT_VALID_ACTION);
        return;
}

bool originallyDelete = actionenum == ActionEnum.DELETE;

if (dryRun)
    actionenum = ActionEnum.PREVIEW;

for (int i = 0; i < rules.Length; i++)
{
    var rule = rules[i];

    Console.WriteLine("Processing Rule: {0}", i + 1);
    Console.WriteLine("From           : {0}", rule.FromDir);
    Console.WriteLine("Regex          : {0}", rule.Regex);
    Console.WriteLine("Destination    : {0}", rule.Destination);
    Console.WriteLine("Action         : {0}", dryRun ? "Dry " + action : action);

    var targetFiles = Processor.GetFilterdFiles(Processor.GetFiles(rule.FromDir, rule.Regex), rule);

    Console.WriteLine("Target Files   : {0}", targetFiles.Count);

    foreach (var targetFile in targetFiles)
    {
        foreach (var f in Processor.GetRelatedFiles(targetFile.Key))
        {
            string from = f;
            string dest = Path.Combine(rule.Destination, Path.GetFileName(from));
            switch (actionenum)
            {
                case ActionEnum.PREVIEW:
                    Console.WriteLine("[PREV] {0} => {1}", from, originallyDelete ? "DELETE" : dest);
                    break;

                case ActionEnum.MOVE:
                    if (verbose)
                        Console.WriteLine("[MOVE] {0} => {1}", from, dest);
                    File.Move(from, dest);
                    break;

                case ActionEnum.COPY:
                    if (verbose)
                        Console.WriteLine("[COPY] {0} => {1}", from, dest);
                    File.Copy(from, dest);
                    break;

                case ActionEnum.DELETE:
                    if (verbose)
                        Console.WriteLine("[DELETE] {0}", from);
                    File.Delete(from);
                    break;
            }
        }
    }
}