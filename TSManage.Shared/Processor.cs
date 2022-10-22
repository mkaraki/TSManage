using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TSManage.Shared
{
    public static class Processor
    {
        public static Dictionary<string, TSInfo> GetFiles(string fromDir, string regex)
        { 
            var filelist = Directory.GetFiles(fromDir);
            return filelist
                .Select(v => (v, Path.GetFileName(v)))
                .Where(v => Regex.IsMatch(v.Item2, regex, RegexOptions.IgnoreCase))
                .Select(v => (v.Item1, Regex.Replace(v.Item2, regex,
                    "${ProgramName}\0${DateYear}\0${DateMonth}\0${DateDay}\0${TimeHour}\0${TimeMinute}\0${ServiceName}"
                )))
                .ToDictionary(v => v.Item1, v => new TSInfo(v.Item2));
        }

        public static Dictionary<string, TSInfo> GetFilterdFiles(Dictionary<string, TSInfo> files, Rule rule)
        {
            return files
                .Where(v => rule.ServiceNames.Contains(v.Value.ServiceName))
                .Where(v => CheckTextMatch(v.Value.ProgramName ?? "", rule.ProgramNameFilter, rule.ProgramNameFilterType))
                .Where(v => v.Value.TimeTotalSec >= rule.TimeStart && v.Value.TimeTotalSec < rule.TimeEnd)
                .Where(v => v.Value.DateTime >= rule.DateStart && v.Value.DateTime <= rule.DateEnd)
                .ToDictionary(v=>v.Key, v=>v.Value);
        }

        private static bool CheckTextMatch(string text, string needle, string type)
        {
            switch (type)
            {
                case "Partial":
                    return text.Contains(needle);
                case "Starts With":
                    return text.StartsWith(needle);
                case "Ends With":
                    return text.EndsWith(needle);
                case "Regex":
                    return Regex.IsMatch(text, needle);
                default:
                    return true;
            }
        }

        public static IEnumerable<string> GetRelatedFiles(string file)
        {
            if (File.Exists(file))
                yield return file;

            if (File.Exists(file + ".program.txt"))
                yield return file + ".program.txt";

            if (File.Exists(file + ".err"))
                yield return file + ".err";
        }

    }
}
