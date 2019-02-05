namespace KodeKeeper
{
	partial class f_EditConnection
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
			this.label1 = new System.Windows.Forms.Label();
			this.tb_HostName = new System.Windows.Forms.TextBox();
			this.num_Port = new System.Windows.Forms.NumericUpDown();
			this.cb_Protocol = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.tb_ConnectionName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lbl_Pwd = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tb_Username = new System.Windows.Forms.TextBox();
			this.tb_HomeFolder = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.num_PingInterval = new System.Windows.Forms.NumericUpDown();
			this.label11 = new System.Windows.Forms.Label();
			this.rb_Keepalive_Off = new System.Windows.Forms.RadioButton();
			this.rb_Keepalive_NullSsh = new System.Windows.Forms.RadioButton();
			this.rb_Keepalive_DummyCommand = new System.Windows.Forms.RadioButton();
			this.label12 = new System.Windows.Forms.Label();
			this.btn_ProxySettings = new System.Windows.Forms.Button();
			this.btn_SshSettings = new System.Windows.Forms.Button();
			this.btn_TunnelSettings = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.cb_Authentication = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btn_SaveConnection = new System.Windows.Forms.Button();
			this.btn_Cancel = new System.Windows.Forms.Button();
			this.panel4 = new System.Windows.Forms.Panel();
			this.btn_BrowseKey = new System.Windows.Forms.Button();
			this.tb_KeyFile = new System.Windows.Forms.TextBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btn_ViewPass = new System.Windows.Forms.Button();
			this.tb_Password = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cb_Projects = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.num_Port)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.num_PingInterval)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(150, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Host Name: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_HostName
			// 
			this.tb_HostName.Location = new System.Drawing.Point(159, 89);
			this.tb_HostName.Name = "tb_HostName";
			this.tb_HostName.Size = new System.Drawing.Size(239, 20);
			this.tb_HostName.TabIndex = 2;
			// 
			// num_Port
			// 
			this.num_Port.Location = new System.Drawing.Point(159, 115);
			this.num_Port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.num_Port.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_Port.Name = "num_Port";
			this.num_Port.Size = new System.Drawing.Size(86, 20);
			this.num_Port.TabIndex = 3;
			this.num_Port.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_Port.ValueChanged += new System.EventHandler(this.num_Port_ValueChanged);
			// 
			// cb_Protocol
			// 
			this.cb_Protocol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Protocol.FormattingEnabled = true;
			this.cb_Protocol.Items.AddRange(new object[] {
            "Ftp",
            "Sftp",
            "Scp",
            "Amazon S3",
            "Webdav"});
			this.cb_Protocol.Location = new System.Drawing.Point(159, 62);
			this.cb_Protocol.Name = "cb_Protocol";
			this.cb_Protocol.Size = new System.Drawing.Size(156, 21);
			this.cb_Protocol.TabIndex = 1;
			this.cb_Protocol.SelectedIndexChanged += new System.EventHandler(this.cb_Protocol_SelectedIndexChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label3.Location = new System.Drawing.Point(3, 59);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 27);
			this.label3.TabIndex = 5;
			this.label3.Text = "Connection Protocol: ";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(150, 26);
			this.label2.TabIndex = 6;
			this.label2.Text = "Port Number: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_ConnectionName
			// 
			this.tb_ConnectionName.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tb_ConnectionName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.tb_ConnectionName.Location = new System.Drawing.Point(159, 3);
			this.tb_ConnectionName.Name = "tb_ConnectionName";
			this.tb_ConnectionName.Size = new System.Drawing.Size(394, 26);
			this.tb_ConnectionName.TabIndex = 0;
			this.tb_ConnectionName.Text = "https://winscp.net/eng/docs/rawsettings";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Location = new System.Drawing.Point(3, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(150, 32);
			this.label4.TabIndex = 7;
			this.label4.Text = "Connection Name: ";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label5.Location = new System.Drawing.Point(3, 165);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(150, 26);
			this.label5.TabIndex = 9;
			this.label5.Text = "Username: ";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbl_Pwd
			// 
			this.lbl_Pwd.AutoSize = true;
			this.lbl_Pwd.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbl_Pwd.Location = new System.Drawing.Point(3, 191);
			this.lbl_Pwd.Name = "lbl_Pwd";
			this.lbl_Pwd.Size = new System.Drawing.Size(150, 26);
			this.lbl_Pwd.TabIndex = 11;
			this.lbl_Pwd.Text = "Password: ";
			this.lbl_Pwd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label7.Location = new System.Drawing.Point(3, 217);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(150, 26);
			this.label7.TabIndex = 12;
			this.label7.Text = "Key: ";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label8.Location = new System.Drawing.Point(3, 138);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(150, 27);
			this.label8.TabIndex = 13;
			this.label8.Text = "Authentication Method: ";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tb_Username
			// 
			this.tb_Username.Location = new System.Drawing.Point(159, 168);
			this.tb_Username.Name = "tb_Username";
			this.tb_Username.Size = new System.Drawing.Size(239, 20);
			this.tb_Username.TabIndex = 5;
			// 
			// tb_HomeFolder
			// 
			this.tb_HomeFolder.Location = new System.Drawing.Point(159, 246);
			this.tb_HomeFolder.Name = "tb_HomeFolder";
			this.tb_HomeFolder.Size = new System.Drawing.Size(239, 20);
			this.tb_HomeFolder.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label9.Location = new System.Drawing.Point(3, 243);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(150, 26);
			this.label9.TabIndex = 17;
			this.label9.Text = "Default directory: ";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label10.Location = new System.Drawing.Point(3, 293);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(150, 24);
			this.label10.TabIndex = 19;
			this.label10.Text = "Keepalive ping interval: ";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// num_PingInterval
			// 
			this.num_PingInterval.Location = new System.Drawing.Point(3, 2);
			this.num_PingInterval.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
			this.num_PingInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.num_PingInterval.Name = "num_PingInterval";
			this.num_PingInterval.Size = new System.Drawing.Size(86, 20);
			this.num_PingInterval.TabIndex = 12;
			this.num_PingInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label11.Location = new System.Drawing.Point(3, 269);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(150, 24);
			this.label11.TabIndex = 21;
			this.label11.Text = "Keepalive ping type: ";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// rb_Keepalive_Off
			// 
			this.rb_Keepalive_Off.AutoSize = true;
			this.rb_Keepalive_Off.Location = new System.Drawing.Point(3, 2);
			this.rb_Keepalive_Off.Name = "rb_Keepalive_Off";
			this.rb_Keepalive_Off.Size = new System.Drawing.Size(39, 17);
			this.rb_Keepalive_Off.TabIndex = 9;
			this.rb_Keepalive_Off.TabStop = true;
			this.rb_Keepalive_Off.Text = "Off";
			this.rb_Keepalive_Off.UseVisualStyleBackColor = true;
			// 
			// rb_Keepalive_NullSsh
			// 
			this.rb_Keepalive_NullSsh.AutoSize = true;
			this.rb_Keepalive_NullSsh.Location = new System.Drawing.Point(48, 2);
			this.rb_Keepalive_NullSsh.Name = "rb_Keepalive_NullSsh";
			this.rb_Keepalive_NullSsh.Size = new System.Drawing.Size(147, 17);
			this.rb_Keepalive_NullSsh.TabIndex = 10;
			this.rb_Keepalive_NullSsh.TabStop = true;
			this.rb_Keepalive_NullSsh.Text = "Send NULL SSH packets";
			this.rb_Keepalive_NullSsh.UseVisualStyleBackColor = true;
			// 
			// rb_Keepalive_DummyCommand
			// 
			this.rb_Keepalive_DummyCommand.AutoSize = true;
			this.rb_Keepalive_DummyCommand.Location = new System.Drawing.Point(201, 2);
			this.rb_Keepalive_DummyCommand.Name = "rb_Keepalive_DummyCommand";
			this.rb_Keepalive_DummyCommand.Size = new System.Drawing.Size(195, 17);
			this.rb_Keepalive_DummyCommand.TabIndex = 11;
			this.rb_Keepalive_DummyCommand.TabStop = true;
			this.rb_Keepalive_DummyCommand.Text = "Execute dummy protocol commands";
			this.rb_Keepalive_DummyCommand.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label12.Location = new System.Drawing.Point(86, 3);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(17, 20);
			this.label12.TabIndex = 25;
			this.label12.Text = "s";
			// 
			// btn_ProxySettings
			// 
			this.btn_ProxySettings.Location = new System.Drawing.Point(3, 2);
			this.btn_ProxySettings.Name = "btn_ProxySettings";
			this.btn_ProxySettings.Size = new System.Drawing.Size(75, 23);
			this.btn_ProxySettings.TabIndex = 13;
			this.btn_ProxySettings.Text = "Proxy";
			this.btn_ProxySettings.UseVisualStyleBackColor = true;
			// 
			// btn_SshSettings
			// 
			this.btn_SshSettings.Location = new System.Drawing.Point(84, 2);
			this.btn_SshSettings.Name = "btn_SshSettings";
			this.btn_SshSettings.Size = new System.Drawing.Size(75, 23);
			this.btn_SshSettings.TabIndex = 14;
			this.btn_SshSettings.Text = "SSH";
			this.btn_SshSettings.UseVisualStyleBackColor = true;
			// 
			// btn_TunnelSettings
			// 
			this.btn_TunnelSettings.Location = new System.Drawing.Point(165, 2);
			this.btn_TunnelSettings.Name = "btn_TunnelSettings";
			this.btn_TunnelSettings.Size = new System.Drawing.Size(75, 23);
			this.btn_TunnelSettings.TabIndex = 15;
			this.btn_TunnelSettings.Text = "Tunnel";
			this.btn_TunnelSettings.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.cb_Authentication, 1, 5);
			this.tableLayoutPanel1.Controls.Add(this.label13, 0, 15);
			this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.tb_ConnectionName, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 3);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 4);
			this.tableLayoutPanel1.Controls.Add(this.label8, 0, 5);
			this.tableLayoutPanel1.Controls.Add(this.label5, 0, 6);
			this.tableLayoutPanel1.Controls.Add(this.label10, 0, 14);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Pwd, 0, 7);
			this.tableLayoutPanel1.Controls.Add(this.label7, 0, 8);
			this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
			this.tableLayoutPanel1.Controls.Add(this.cb_Protocol, 1, 2);
			this.tableLayoutPanel1.Controls.Add(this.label11, 0, 10);
			this.tableLayoutPanel1.Controls.Add(this.tb_HostName, 1, 3);
			this.tableLayoutPanel1.Controls.Add(this.num_Port, 1, 4);
			this.tableLayoutPanel1.Controls.Add(this.tb_HomeFolder, 1, 9);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 10);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 14);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 15);
			this.tableLayoutPanel1.Controls.Add(this.btn_SaveConnection, 0, 16);
			this.tableLayoutPanel1.Controls.Add(this.btn_Cancel, 1, 16);
			this.tableLayoutPanel1.Controls.Add(this.tb_Username, 1, 6);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 1, 8);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 7);
			this.tableLayoutPanel1.Controls.Add(this.label6, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.cb_Projects, 1, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 17;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(556, 419);
			this.tableLayoutPanel1.TabIndex = 31;
			// 
			// cb_Authentication
			// 
			this.cb_Authentication.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Authentication.FormattingEnabled = true;
			this.cb_Authentication.Items.AddRange(new object[] {
            "Password",
            "Key",
            "Key but attempt to use stored keys"});
			this.cb_Authentication.Location = new System.Drawing.Point(159, 141);
			this.cb_Authentication.Name = "cb_Authentication";
			this.cb_Authentication.Size = new System.Drawing.Size(239, 21);
			this.cb_Authentication.TabIndex = 4;
			this.cb_Authentication.SelectedIndexChanged += new System.EventHandler(this.cb_Authentication_SelectedIndexChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label13.Location = new System.Drawing.Point(3, 317);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(150, 26);
			this.label13.TabIndex = 32;
			this.label13.Text = "Additional Options: ";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.rb_Keepalive_Off);
			this.panel1.Controls.Add(this.rb_Keepalive_NullSsh);
			this.panel1.Controls.Add(this.rb_Keepalive_DummyCommand);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(156, 269);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(400, 24);
			this.panel1.TabIndex = 22;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.num_PingInterval);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(156, 293);
			this.panel2.Margin = new System.Windows.Forms.Padding(0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(400, 24);
			this.panel2.TabIndex = 23;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btn_ProxySettings);
			this.panel3.Controls.Add(this.btn_SshSettings);
			this.panel3.Controls.Add(this.btn_TunnelSettings);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(156, 317);
			this.panel3.Margin = new System.Windows.Forms.Padding(0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(400, 26);
			this.panel3.TabIndex = 33;
			// 
			// btn_SaveConnection
			// 
			this.btn_SaveConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_SaveConnection.Location = new System.Drawing.Point(3, 393);
			this.btn_SaveConnection.Name = "btn_SaveConnection";
			this.btn_SaveConnection.Size = new System.Drawing.Size(150, 23);
			this.btn_SaveConnection.TabIndex = 16;
			this.btn_SaveConnection.Text = "Save Connection";
			this.btn_SaveConnection.UseVisualStyleBackColor = true;
			this.btn_SaveConnection.Click += new System.EventHandler(this.btn_SaveConnection_Click);
			// 
			// btn_Cancel
			// 
			this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_Cancel.Location = new System.Drawing.Point(403, 393);
			this.btn_Cancel.Name = "btn_Cancel";
			this.btn_Cancel.Size = new System.Drawing.Size(150, 23);
			this.btn_Cancel.TabIndex = 17;
			this.btn_Cancel.Text = "Cancel and Close";
			this.btn_Cancel.UseVisualStyleBackColor = true;
			this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.btn_BrowseKey);
			this.panel4.Controls.Add(this.tb_KeyFile);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(156, 217);
			this.panel4.Margin = new System.Windows.Forms.Padding(0);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(400, 26);
			this.panel4.TabIndex = 39;
			// 
			// btn_BrowseKey
			// 
			this.btn_BrowseKey.Location = new System.Drawing.Point(192, 2);
			this.btn_BrowseKey.Name = "btn_BrowseKey";
			this.btn_BrowseKey.Size = new System.Drawing.Size(50, 22);
			this.btn_BrowseKey.TabIndex = 19;
			this.btn_BrowseKey.Text = "Browse";
			this.btn_BrowseKey.UseVisualStyleBackColor = true;
			// 
			// tb_KeyFile
			// 
			this.tb_KeyFile.Location = new System.Drawing.Point(3, 3);
			this.tb_KeyFile.Name = "tb_KeyFile";
			this.tb_KeyFile.Size = new System.Drawing.Size(191, 20);
			this.tb_KeyFile.TabIndex = 7;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.btn_ViewPass);
			this.panel5.Controls.Add(this.tb_Password);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(156, 191);
			this.panel5.Margin = new System.Windows.Forms.Padding(0);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(400, 26);
			this.panel5.TabIndex = 40;
			// 
			// btn_ViewPass
			// 
			this.btn_ViewPass.Location = new System.Drawing.Point(192, 1);
			this.btn_ViewPass.Name = "btn_ViewPass";
			this.btn_ViewPass.Size = new System.Drawing.Size(50, 22);
			this.btn_ViewPass.TabIndex = 20;
			this.btn_ViewPass.Text = "View";
			this.btn_ViewPass.UseVisualStyleBackColor = true;
			// 
			// tb_Password
			// 
			this.tb_Password.Location = new System.Drawing.Point(3, 2);
			this.tb_Password.Name = "tb_Password";
			this.tb_Password.PasswordChar = '•';
			this.tb_Password.Size = new System.Drawing.Size(191, 20);
			this.tb_Password.TabIndex = 6;
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label6.Location = new System.Drawing.Point(3, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(150, 27);
			this.label6.TabIndex = 41;
			this.label6.Text = "Project:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// cb_Projects
			// 
			this.cb_Projects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_Projects.FormattingEnabled = true;
			this.cb_Projects.Location = new System.Drawing.Point(159, 35);
			this.cb_Projects.Name = "cb_Projects";
			this.cb_Projects.Size = new System.Drawing.Size(156, 21);
			this.cb_Projects.TabIndex = 42;
			// 
			// f_EditConnection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(556, 419);
			this.ControlBox = false;
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(572, 398);
			this.Name = "f_EditConnection";
			this.Text = "Edit Connection";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.f_EditConnection_KeyDown);
			((System.ComponentModel.ISupportInitialize)(this.num_Port)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.num_PingInterval)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tb_HostName;
		private System.Windows.Forms.NumericUpDown num_Port;
		private System.Windows.Forms.ComboBox cb_Protocol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox tb_ConnectionName;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lbl_Pwd;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox tb_Username;
		private System.Windows.Forms.TextBox tb_HomeFolder;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.NumericUpDown num_PingInterval;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.RadioButton rb_Keepalive_Off;
		private System.Windows.Forms.RadioButton rb_Keepalive_NullSsh;
		private System.Windows.Forms.RadioButton rb_Keepalive_DummyCommand;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btn_ProxySettings;
		private System.Windows.Forms.Button btn_SshSettings;
		private System.Windows.Forms.Button btn_TunnelSettings;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btn_SaveConnection;
		private System.Windows.Forms.Button btn_Cancel;
		private System.Windows.Forms.ComboBox cb_Authentication;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Button btn_BrowseKey;
		private System.Windows.Forms.TextBox tb_KeyFile;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Button btn_ViewPass;
		private System.Windows.Forms.TextBox tb_Password;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox cb_Projects;
	}
}