using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSManage
{
    public partial class TextView : Form
    {
        private string _filePath;

        public TextView(string filePath)
        {
            InitializeComponent();

            _filePath = filePath;
        }

        private void TextView_Load(object sender, EventArgs e)
        {

        }

        private async void TextView_Shown(object sender, EventArgs e)
        {
            if (!File.Exists(_filePath))
            {
                MessageBox.Show("No file found");
                Close();
                return;
            }

            string filecontent = await File.ReadAllTextAsync(_filePath, Encoding.GetEncoding("Shift_JIS"));

            tbox_content.Text = filecontent;
        }
    }
}
