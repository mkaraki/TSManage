using System.Runtime.Serialization;
using YamlDotNet.Serialization;

namespace TSManage
{
    public partial class RuleExporter : Form
    {
        private Shared.Rule _rule;

        public RuleExporter(Shared.Rule rule)
        {
            InitializeComponent();

            _rule = rule;

            var yamls = new SerializerBuilder().Build();
            tbox_rule.Text = yamls.Serialize(new Shared.Rule[] {_rule});
        }

        private void RuleExporter_Load(object sender, EventArgs e)
        {

        }

        private async void btn_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            await File.WriteAllTextAsync(saveFileDialog1.FileName, tbox_rule.Text, System.Text.Encoding.UTF8);
        }
    }
}
