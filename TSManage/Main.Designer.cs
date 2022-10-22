namespace TSManage
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_tsdir = new System.Windows.Forms.TextBox();
            this.btn_tsdir_browse = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_tsdir_update = new System.Windows.Forms.Button();
            this.tbox_fname_regex = new System.Windows.Forms.TextBox();
            this.lview_files = new System.Windows.Forms.ListView();
            this.lview_files_ch_filename = new System.Windows.Forms.ColumnHeader();
            this.lview_files_ch_metadata = new System.Windows.Forms.ColumnHeader();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_list_update = new System.Windows.Forms.Button();
            this.btn_list_reset = new System.Windows.Forms.Button();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_filt_service_checkall = new System.Windows.Forms.Button();
            this.btn_filt_service_uncheckall = new System.Windows.Forms.Button();
            this.checkedlbox_filter_services = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.tbox_filter_progname = new System.Windows.Forms.TextBox();
            this.cbox_filter_progname_type = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTime_filter_from = new System.Windows.Forms.DateTimePicker();
            this.dateTime_filter_to = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num_time_start_h = new System.Windows.Forms.NumericUpDown();
            this.num_time_start_m = new System.Windows.Forms.NumericUpDown();
            this.num_time_end_h = new System.Windows.Forms.NumericUpDown();
            this.num_time_end_m = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_file_getinfo = new System.Windows.Forms.Button();
            this.btn_file_geterr = new System.Windows.Forms.Button();
            this.tbox_move_dest = new System.Windows.Forms.TextBox();
            this.btn_move_destdir_browse = new System.Windows.Forms.Button();
            this.btn_move_copy = new System.Windows.Forms.Button();
            this.btn_move_move = new System.Windows.Forms.Button();
            this.btn_move_delete = new System.Windows.Forms.Button();
            this.btn_rule_export = new System.Windows.Forms.Button();
            this.folderBrowserDialog_tspath = new System.Windows.Forms.FolderBrowserDialog();
            this.folderBrowserDialog_move_destdir = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_start_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_start_m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_end_h)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_end_m)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lview_files, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel6, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.59399F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.40601F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1055, 514);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel2.Controls.Add(this.tbox_tsdir, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_tsdir_browse, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1049, 34);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tbox_tsdir
            // 
            this.tbox_tsdir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_tsdir.Location = new System.Drawing.Point(3, 3);
            this.tbox_tsdir.Name = "tbox_tsdir";
            this.tbox_tsdir.Size = new System.Drawing.Size(963, 23);
            this.tbox_tsdir.TabIndex = 0;
            // 
            // btn_tsdir_browse
            // 
            this.btn_tsdir_browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tsdir_browse.Location = new System.Drawing.Point(972, 3);
            this.btn_tsdir_browse.Name = "btn_tsdir_browse";
            this.btn_tsdir_browse.Size = new System.Drawing.Size(74, 28);
            this.btn_tsdir_browse.TabIndex = 1;
            this.btn_tsdir_browse.Text = "Browse";
            this.btn_tsdir_browse.UseVisualStyleBackColor = true;
            this.btn_tsdir_browse.Click += new System.EventHandler(this.btn_tsdir_browse_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel3.Controls.Add(this.btn_tsdir_update, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.tbox_fname_regex, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1049, 34);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_tsdir_update
            // 
            this.btn_tsdir_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_tsdir_update.Location = new System.Drawing.Point(972, 3);
            this.btn_tsdir_update.Name = "btn_tsdir_update";
            this.btn_tsdir_update.Size = new System.Drawing.Size(74, 28);
            this.btn_tsdir_update.TabIndex = 3;
            this.btn_tsdir_update.Text = "Get Files";
            this.btn_tsdir_update.UseVisualStyleBackColor = true;
            this.btn_tsdir_update.Click += new System.EventHandler(this.btn_tsdir_update_Click);
            // 
            // tbox_fname_regex
            // 
            this.tbox_fname_regex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_fname_regex.Location = new System.Drawing.Point(3, 3);
            this.tbox_fname_regex.Name = "tbox_fname_regex";
            this.tbox_fname_regex.Size = new System.Drawing.Size(963, 23);
            this.tbox_fname_regex.TabIndex = 0;
            this.tbox_fname_regex.Text = "^(?<ProgramName>.+) \\((?<DateYear>\\d{4})(?<DateMonth>\\d{2})(?<DateDay>\\d{2})\\-(?<" +
    "TimeHour>\\d{2})(?<TimeMinute>\\d{2}) (?<ServiceName>.+)\\)\\.m2ts$";
            // 
            // lview_files
            // 
            this.lview_files.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lview_files_ch_filename,
            this.lview_files_ch_metadata});
            this.lview_files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lview_files.Location = new System.Drawing.Point(3, 233);
            this.lview_files.Name = "lview_files";
            this.lview_files.Size = new System.Drawing.Size(1049, 243);
            this.lview_files.TabIndex = 2;
            this.lview_files.UseCompatibleStateImageBehavior = false;
            this.lview_files.View = System.Windows.Forms.View.Details;
            // 
            // lview_files_ch_filename
            // 
            this.lview_files_ch_filename.Text = "Filepath";
            // 
            // lview_files_ch_metadata
            // 
            this.lview_files_ch_metadata.Text = "Metadata";
            this.lview_files_ch_metadata.Width = 700;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 83);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1049, 144);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.btn_list_update, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btn_list_reset, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(972, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(74, 138);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // btn_list_update
            // 
            this.btn_list_update.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_list_update.Location = new System.Drawing.Point(3, 108);
            this.btn_list_update.Name = "btn_list_update";
            this.btn_list_update.Size = new System.Drawing.Size(68, 27);
            this.btn_list_update.TabIndex = 3;
            this.btn_list_update.Text = "Update";
            this.btn_list_update.UseVisualStyleBackColor = true;
            this.btn_list_update.Click += new System.EventHandler(this.btn_list_update_Click);
            // 
            // btn_list_reset
            // 
            this.btn_list_reset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_list_reset.Location = new System.Drawing.Point(3, 75);
            this.btn_list_reset.Name = "btn_list_reset";
            this.btn_list_reset.Size = new System.Drawing.Size(68, 27);
            this.btn_list_reset.TabIndex = 2;
            this.btn_list_reset.Text = "Reset";
            this.btn_list_reset.UseVisualStyleBackColor = true;
            this.btn_list_reset.Click += new System.EventHandler(this.btn_list_reset_Click);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel8, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel10, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(963, 138);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.tableLayoutPanel9, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.checkedlbox_filter_services, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(766, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(194, 132);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 2;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.btn_filt_service_checkall, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.btn_filt_service_uncheckall, 1, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 105);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(188, 32);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // btn_filt_service_checkall
            // 
            this.btn_filt_service_checkall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_filt_service_checkall.Location = new System.Drawing.Point(3, 3);
            this.btn_filt_service_checkall.Name = "btn_filt_service_checkall";
            this.btn_filt_service_checkall.Size = new System.Drawing.Size(88, 26);
            this.btn_filt_service_checkall.TabIndex = 0;
            this.btn_filt_service_checkall.Text = "Check all";
            this.btn_filt_service_checkall.UseVisualStyleBackColor = true;
            this.btn_filt_service_checkall.Click += new System.EventHandler(this.btn_filt_service_checkall_Click);
            // 
            // btn_filt_service_uncheckall
            // 
            this.btn_filt_service_uncheckall.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_filt_service_uncheckall.Location = new System.Drawing.Point(97, 3);
            this.btn_filt_service_uncheckall.Name = "btn_filt_service_uncheckall";
            this.btn_filt_service_uncheckall.Size = new System.Drawing.Size(88, 26);
            this.btn_filt_service_uncheckall.TabIndex = 1;
            this.btn_filt_service_uncheckall.Text = "Uncheck all";
            this.btn_filt_service_uncheckall.UseVisualStyleBackColor = true;
            this.btn_filt_service_uncheckall.Click += new System.EventHandler(this.btn_filt_service_uncheckall_Click);
            // 
            // checkedlbox_filter_services
            // 
            this.checkedlbox_filter_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedlbox_filter_services.FormattingEnabled = true;
            this.checkedlbox_filter_services.Location = new System.Drawing.Point(3, 3);
            this.checkedlbox_filter_services.Name = "checkedlbox_filter_services";
            this.checkedlbox_filter_services.Size = new System.Drawing.Size(188, 96);
            this.checkedlbox_filter_services.TabIndex = 1;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 2;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel11, 0, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel12, 1, 0);
            this.tableLayoutPanel10.Controls.Add(this.tableLayoutPanel17, 0, 1);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(757, 132);
            this.tableLayoutPanel10.TabIndex = 1;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 2;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.tbox_filter_progname, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.cbox_filter_progname_type, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 2;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(372, 44);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // tbox_filter_progname
            // 
            this.tbox_filter_progname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_filter_progname.Location = new System.Drawing.Point(103, 20);
            this.tbox_filter_progname.Name = "tbox_filter_progname";
            this.tbox_filter_progname.Size = new System.Drawing.Size(266, 23);
            this.tbox_filter_progname.TabIndex = 0;
            // 
            // cbox_filter_progname_type
            // 
            this.cbox_filter_progname_type.FormattingEnabled = true;
            this.cbox_filter_progname_type.Items.AddRange(new object[] {
            "Partial",
            "Starts With",
            "Ends With",
            "Regex"});
            this.cbox_filter_progname_type.Location = new System.Drawing.Point(3, 20);
            this.cbox_filter_progname_type.Name = "cbox_filter_progname_type";
            this.cbox_filter_progname_type.Size = new System.Drawing.Size(94, 23);
            this.cbox_filter_progname_type.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Program name";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 3;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel12.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.dateTime_filter_from, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.dateTime_filter_to, 2, 1);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(381, 3);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(373, 44);
            this.tableLayoutPanel12.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(179, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "~";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date";
            // 
            // dateTime_filter_from
            // 
            this.dateTime_filter_from.CustomFormat = "yyyy/MM/dd";
            this.dateTime_filter_from.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTime_filter_from.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_filter_from.Location = new System.Drawing.Point(3, 20);
            this.dateTime_filter_from.Name = "dateTime_filter_from";
            this.dateTime_filter_from.Size = new System.Drawing.Size(170, 23);
            this.dateTime_filter_from.TabIndex = 2;
            this.dateTime_filter_from.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // dateTime_filter_to
            // 
            this.dateTime_filter_to.CustomFormat = "yyyy/MM/dd";
            this.dateTime_filter_to.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dateTime_filter_to.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime_filter_to.Location = new System.Drawing.Point(199, 20);
            this.dateTime_filter_to.Name = "dateTime_filter_to";
            this.dateTime_filter_to.Size = new System.Drawing.Size(171, 23);
            this.dateTime_filter_to.TabIndex = 3;
            this.dateTime_filter_to.Value = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 8;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Controls.Add(this.label16, 5, 1);
            this.tableLayoutPanel17.Controls.Add(this.label15, 3, 1);
            this.tableLayoutPanel17.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.num_time_start_h, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.num_time_start_m, 2, 1);
            this.tableLayoutPanel17.Controls.Add(this.num_time_end_h, 4, 1);
            this.tableLayoutPanel17.Controls.Add(this.num_time_end_m, 6, 1);
            this.tableLayoutPanel17.Controls.Add(this.label7, 1, 1);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 53);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 2;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(372, 44);
            this.tableLayoutPanel17.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Location = new System.Drawing.Point(163, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 27);
            this.label16.TabIndex = 14;
            this.label16.Text = ":";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label15.Location = new System.Drawing.Point(103, 17);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 27);
            this.label15.TabIndex = 13;
            this.label15.Text = "~";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Time";
            // 
            // num_time_start_h
            // 
            this.num_time_start_h.Location = new System.Drawing.Point(3, 20);
            this.num_time_start_h.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_time_start_h.Name = "num_time_start_h";
            this.num_time_start_h.Size = new System.Drawing.Size(34, 23);
            this.num_time_start_h.TabIndex = 1;
            // 
            // num_time_start_m
            // 
            this.num_time_start_m.Location = new System.Drawing.Point(63, 20);
            this.num_time_start_m.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_time_start_m.Name = "num_time_start_m";
            this.num_time_start_m.Size = new System.Drawing.Size(34, 23);
            this.num_time_start_m.TabIndex = 2;
            // 
            // num_time_end_h
            // 
            this.num_time_end_h.Location = new System.Drawing.Point(123, 20);
            this.num_time_end_h.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.num_time_end_h.Name = "num_time_end_h";
            this.num_time_end_h.Size = new System.Drawing.Size(34, 23);
            this.num_time_end_h.TabIndex = 3;
            this.num_time_end_h.Value = new decimal(new int[] {
            23,
            0,
            0,
            0});
            // 
            // num_time_end_m
            // 
            this.num_time_end_m.Location = new System.Drawing.Point(183, 20);
            this.num_time_end_m.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.num_time_end_m.Name = "num_time_end_m";
            this.num_time_end_m.Size = new System.Drawing.Size(34, 23);
            this.num_time_end_m.TabIndex = 4;
            this.num_time_end_m.Value = new decimal(new int[] {
            59,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(43, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 27);
            this.label7.TabIndex = 5;
            this.label7.Text = ":";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 11;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel6.Controls.Add(this.btn_file_getinfo, 10, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_file_geterr, 9, 0);
            this.tableLayoutPanel6.Controls.Add(this.tbox_move_dest, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_move_destdir_browse, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_move_copy, 3, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_move_move, 4, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_move_delete, 5, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_rule_export, 7, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 482);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(1049, 29);
            this.tableLayoutPanel6.TabIndex = 4;
            // 
            // btn_file_getinfo
            // 
            this.btn_file_getinfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_file_getinfo.Location = new System.Drawing.Point(932, 3);
            this.btn_file_getinfo.Name = "btn_file_getinfo";
            this.btn_file_getinfo.Size = new System.Drawing.Size(114, 23);
            this.btn_file_getinfo.TabIndex = 3;
            this.btn_file_getinfo.Text = "Get .program.txt";
            this.btn_file_getinfo.UseVisualStyleBackColor = true;
            this.btn_file_getinfo.Click += new System.EventHandler(this.btn_file_getinfo_Click);
            // 
            // btn_file_geterr
            // 
            this.btn_file_geterr.Location = new System.Drawing.Point(852, 3);
            this.btn_file_geterr.Name = "btn_file_geterr";
            this.btn_file_geterr.Size = new System.Drawing.Size(74, 23);
            this.btn_file_geterr.TabIndex = 2;
            this.btn_file_geterr.Text = "Get .err";
            this.btn_file_geterr.UseVisualStyleBackColor = true;
            this.btn_file_geterr.Click += new System.EventHandler(this.btn_file_geterr_Click);
            // 
            // tbox_move_dest
            // 
            this.tbox_move_dest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbox_move_dest.Location = new System.Drawing.Point(3, 3);
            this.tbox_move_dest.Name = "tbox_move_dest";
            this.tbox_move_dest.Size = new System.Drawing.Size(393, 23);
            this.tbox_move_dest.TabIndex = 4;
            // 
            // btn_move_destdir_browse
            // 
            this.btn_move_destdir_browse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_move_destdir_browse.Location = new System.Drawing.Point(402, 3);
            this.btn_move_destdir_browse.Name = "btn_move_destdir_browse";
            this.btn_move_destdir_browse.Size = new System.Drawing.Size(74, 23);
            this.btn_move_destdir_browse.TabIndex = 5;
            this.btn_move_destdir_browse.Text = "Browse";
            this.btn_move_destdir_browse.UseVisualStyleBackColor = true;
            this.btn_move_destdir_browse.Click += new System.EventHandler(this.btn_move_destdir_browse_Click);
            // 
            // btn_move_copy
            // 
            this.btn_move_copy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_move_copy.Location = new System.Drawing.Point(492, 3);
            this.btn_move_copy.Name = "btn_move_copy";
            this.btn_move_copy.Size = new System.Drawing.Size(74, 23);
            this.btn_move_copy.TabIndex = 6;
            this.btn_move_copy.Text = "Copy";
            this.btn_move_copy.UseVisualStyleBackColor = true;
            this.btn_move_copy.Click += new System.EventHandler(this.btn_move_copy_Click);
            // 
            // btn_move_move
            // 
            this.btn_move_move.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_move_move.Location = new System.Drawing.Point(572, 3);
            this.btn_move_move.Name = "btn_move_move";
            this.btn_move_move.Size = new System.Drawing.Size(74, 23);
            this.btn_move_move.TabIndex = 7;
            this.btn_move_move.Text = "Move";
            this.btn_move_move.UseVisualStyleBackColor = true;
            this.btn_move_move.Click += new System.EventHandler(this.btn_move_move_Click);
            // 
            // btn_move_delete
            // 
            this.btn_move_delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_move_delete.Location = new System.Drawing.Point(652, 3);
            this.btn_move_delete.Name = "btn_move_delete";
            this.btn_move_delete.Size = new System.Drawing.Size(74, 23);
            this.btn_move_delete.TabIndex = 8;
            this.btn_move_delete.Text = "Delete";
            this.btn_move_delete.UseVisualStyleBackColor = true;
            this.btn_move_delete.Click += new System.EventHandler(this.btn_move_delete_Click);
            // 
            // btn_rule_export
            // 
            this.btn_rule_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_rule_export.Location = new System.Drawing.Point(742, 3);
            this.btn_rule_export.Name = "btn_rule_export";
            this.btn_rule_export.Size = new System.Drawing.Size(74, 23);
            this.btn_rule_export.TabIndex = 9;
            this.btn_rule_export.Text = "Export";
            this.btn_rule_export.UseVisualStyleBackColor = true;
            this.btn_rule_export.Click += new System.EventHandler(this.btn_rule_export_Click);
            // 
            // folderBrowserDialog_tspath
            // 
            this.folderBrowserDialog_tspath.HelpRequest += new System.EventHandler(this.folderBrowserDialog_tspath_HelpRequest);
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 2;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.Controls.Add(this.textBox3, 1, 1);
            this.tableLayoutPanel14.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 2;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(103, 23);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(94, 23);
            this.textBox3.TabIndex = 0;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Partial",
            "Starts With",
            "Ends With",
            "Regex"});
            this.comboBox3.Location = new System.Drawing.Point(3, 3);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(94, 23);
            this.comboBox3.TabIndex = 1;
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 2;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.Controls.Add(this.textBox4, 1, 1);
            this.tableLayoutPanel15.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(103, 23);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(94, 23);
            this.textBox4.TabIndex = 0;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Partial",
            "Starts With",
            "Ends With",
            "Regex"});
            this.comboBox4.Location = new System.Drawing.Point(3, 3);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(94, 23);
            this.comboBox4.TabIndex = 1;
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 2;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel16.Controls.Add(this.textBox5, 1, 1);
            this.tableLayoutPanel16.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 2;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel16.TabIndex = 0;
            // 
            // textBox5
            // 
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(103, 23);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(94, 23);
            this.textBox5.TabIndex = 0;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "Partial",
            "Starts With",
            "Ends With",
            "Regex"});
            this.comboBox5.Location = new System.Drawing.Point(3, 3);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(94, 23);
            this.comboBox5.TabIndex = 1;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 3;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.label4, 1, 1);
            this.tableLayoutPanel13.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(93, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 80);
            this.label4.TabIndex = 0;
            this.label4.Text = "~";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Date";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 514);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Main";
            this.Text = "TSManager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_start_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_start_m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_end_h)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_time_end_m)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tableLayoutPanel16.ResumeLayout(false);
            this.tableLayoutPanel16.PerformLayout();
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox tbox_tsdir;
        private Button btn_tsdir_browse;
        private FolderBrowserDialog folderBrowserDialog_tspath;
        private TableLayoutPanel tableLayoutPanel3;
        private TextBox tbox_fname_regex;
        private Button btn_tsdir_update;
        private ListView lview_files;
        private ColumnHeader lview_files_ch_filename;
        private ColumnHeader lview_files_ch_metadata;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private Button btn_list_update;
        private Button btn_list_reset;
        private TableLayoutPanel tableLayoutPanel6;
        private Button btn_file_getinfo;
        private Button btn_file_geterr;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel9;
        private Button btn_filt_service_checkall;
        private Button btn_filt_service_uncheckall;
        private CheckedListBox checkedlbox_filter_services;
        private TableLayoutPanel tableLayoutPanel10;
        private TableLayoutPanel tableLayoutPanel11;
        private TextBox tbox_filter_progname;
        private ComboBox cbox_filter_progname_type;
        private Label label1;
        private TextBox tbox_move_dest;
        private Button btn_move_destdir_browse;
        private FolderBrowserDialog folderBrowserDialog_move_destdir;
        private Button btn_move_copy;
        private Button btn_move_move;
        private Button btn_move_delete;
        private Button btn_rule_export;
        private TableLayoutPanel tableLayoutPanel12;
        private Label label2;
        private Label label3;
        private DateTimePicker dateTime_filter_from;
        private DateTimePicker dateTime_filter_to;
        private TableLayoutPanel tableLayoutPanel14;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private TableLayoutPanel tableLayoutPanel15;
        private TextBox textBox4;
        private ComboBox comboBox4;
        private TableLayoutPanel tableLayoutPanel16;
        private TextBox textBox5;
        private ComboBox comboBox5;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label16;
        private Label label15;
        private Label label6;
        private NumericUpDown num_time_start_h;
        private NumericUpDown num_time_start_m;
        private NumericUpDown num_time_end_h;
        private NumericUpDown num_time_end_m;
        private Label label7;
        private TableLayoutPanel tableLayoutPanel13;
        private Label label4;
        private Label label5;
    }
}