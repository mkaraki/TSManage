namespace TSManage
{
    partial class TextView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbox_content = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbox_content
            // 
            this.tbox_content.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_content.Location = new System.Drawing.Point(0, 0);
            this.tbox_content.Multiline = true;
            this.tbox_content.Name = "tbox_content";
            this.tbox_content.ReadOnly = true;
            this.tbox_content.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbox_content.Size = new System.Drawing.Size(800, 450);
            this.tbox_content.TabIndex = 0;
            this.tbox_content.Text = "Loading contents...";
            // 
            // TextView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbox_content);
            this.Name = "TextView";
            this.Text = "TextView";
            this.Load += new System.EventHandler(this.TextView_Load);
            this.Shown += new System.EventHandler(this.TextView_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbox_content;
    }
}