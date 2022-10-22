using System.Configuration;
using System.Diagnostics;
using System.Text.RegularExpressions;
using TSManage.Shared;

namespace TSManage
{
    public partial class Main : Form
    {

        private Dictionary<string, TSInfo> files = new();

        private Dictionary<string, TSInfo> filterdFiles = new();

        public Main()
        {
            InitializeComponent();

            if (ConfigurationManager.AppSettings["filenameRegex"] != string.Empty)
                tbox_fname_regex.Text = ConfigurationManager.AppSettings["filenameRegex"] ?? tbox_fname_regex.Text;
        }

        private void btn_tsdir_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_tspath.ShowDialog() != DialogResult.OK)
                return;

            tbox_tsdir.Text = folderBrowserDialog_tspath.SelectedPath;
        }

        private void btn_tsdir_update_Click(object sender, EventArgs e)
        {
            var loadingscr = new LoadingScreen();

            Enabled = false;
            loadingscr.Show();

            ConfigurationManager.AppSettings["filenameRegex"] = tbox_fname_regex.Text;

            files = Processor.GetFiles(tbox_tsdir.Text, tbox_fname_regex.Text);

            filterdFiles = files;

            checkedlbox_filter_services.Items.Clear();
            foreach (var i in files.Select(v => v.Value.ServiceName).Distinct())
                checkedlbox_filter_services.Items.Add(i, true);

#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            btn_list_reset_Click(null, null);
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.

            loadingscr.Close();
            Enabled = true;

            Focus();
        }

        private void folderBrowserDialog_tspath_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btn_list_update_Click(object sender, EventArgs e)
        {
            var rule = GetRuleInfo();

            filterdFiles = Processor.GetFilterdFiles(files, rule);

            UpdateFileList(filterdFiles);
        }


        private void btn_list_reset_Click(object sender, EventArgs e)
        {
            filterdFiles = files;
            UpdateFileList(files);
        }

        private void UpdateFileList(IDictionary<string, TSInfo> files)
        { 
            lview_files.Items.Clear();

            lview_files.Items.AddRange(files.Select(v => {
                var item = new ListViewItem(v.Key);
                item.SubItems.Add(v.Value.ToString());
                return item;
                }).ToArray());
        }

        private void btn_file_getinfo_Click(object sender, EventArgs e)
        {
            if (lview_files.SelectedItems.Count != 1)
                return;

            var item = lview_files.SelectedItems[0];
            new TextView(item.Text + ".program.txt").Show();
        }

        private void btn_file_geterr_Click(object sender, EventArgs e)
        {
            if (lview_files.SelectedItems.Count != 1)
                return;

            var item = lview_files.SelectedItems[0];
            new TextView(item.Text + ".err").Show();
        }

        private void btn_filt_service_checkall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedlbox_filter_services.Items.Count; i++)
                checkedlbox_filter_services.SetItemChecked(i, true);
        }

        private void btn_filt_service_uncheckall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedlbox_filter_services.Items.Count; i++)
                checkedlbox_filter_services.SetItemChecked(i, false);
        }

        private void btn_move_destdir_browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog_move_destdir.ShowDialog() != DialogResult.OK)
                return;

            tbox_move_dest.Text = folderBrowserDialog_move_destdir.SelectedPath;
        }

        private void btn_move_copy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This operation can't be undo.\n\nCopy {lview_files.Items.Count} items into \"{tbox_move_dest.Text}\"", "TSManage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var loadingscr = new LoadingScreen();

            Enabled = false;
            loadingscr.Show();

            foreach (var f in filterdFiles)
            {
                foreach (var i in Processor.GetRelatedFiles(f.Key))
                { 
                    string from = i;
                    string dest = Path.Combine(tbox_move_dest.Text, Path.GetFileName(from));
                    File.Copy(from, dest);
                }
            }

            loadingscr.Close();
            Enabled = true;

            Focus();
        }

        private void btn_move_move_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This operation can't be undo.\n\nMove {lview_files.Items.Count} items into \"{tbox_move_dest.Text}\"", "TSManage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var loadingscr = new LoadingScreen();

            Enabled = false;
            loadingscr.Show();

            foreach (var f in filterdFiles)
            {
                foreach (var i in Processor.GetRelatedFiles(f.Key))
                { 
                    string from = i;
                    string dest = Path.Combine(tbox_move_dest.Text, Path.GetFileName(from));
                    File.Move(from, dest);
                }
            }

            loadingscr.Close();
            Enabled = true;

            Focus();
        }

        private void btn_move_delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"This operation can't be undo.\n\nDelete {lview_files.Items.Count} items", "TSManage", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes)
                return;

            var loadingscr = new LoadingScreen();

            Enabled = false;
            loadingscr.Show();

            foreach (var f in filterdFiles)
            {
                foreach (var i in Processor.GetRelatedFiles(f.Key))
                { 
                    File.Delete(i);
                }
            }

            loadingscr.Close();
            Enabled = true;

            Focus();
        }

        private string ComboBoxToString(ComboBox cbox)
        { 
            if (cbox.SelectedItem != null)
                return cbox.SelectedItem.ToString() ?? "";
            else
                return "";
        }

        private Rule GetRuleInfo()
        {
            return new Rule() {
                ProgramNameFilterType = ComboBoxToString(cbox_filter_progname_type),
                ProgramNameFilter = tbox_filter_progname.Text,
                ServiceNames = checkedlbox_filter_services.CheckedItems.Cast<string>().ToArray(),
                FromDir = tbox_tsdir.Text,
                Regex = tbox_fname_regex.Text,
                Destination = tbox_move_dest.Text,
                TimeStart = (int)num_time_start_h.Value * 3600 + (int)num_time_start_m.Value * 60,
                TimeEnd = (int)num_time_end_h.Value * 3600 + (int)num_time_end_m.Value * 60,
                DateStart = dateTime_filter_from.Value,
                DateEnd = dateTime_filter_to.Value,
            };
        }

        private void btn_rule_export_Click(object sender, EventArgs e)
        {
            new RuleExporter(GetRuleInfo()).ShowDialog();
        }
    }
}