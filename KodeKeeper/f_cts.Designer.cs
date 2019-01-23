namespace KodeKeeper
{
	partial class f_cts
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
			this.cb_Servers = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.gb_ServerSpecs = new System.Windows.Forms.GroupBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.btn_Logs = new System.Windows.Forms.Button();
			this.lbl_Key = new System.Windows.Forms.Label();
			this.lbl_LastUpdate = new System.Windows.Forms.Label();
			this.lbl_ProjectName = new System.Windows.Forms.Label();
			this.lbl_HostName = new System.Windows.Forms.Label();
			this.lbl_LastConnected = new System.Windows.Forms.Label();
			this.lbl_Port = new System.Windows.Forms.Label();
			this.lbl_HomeDir = new System.Windows.Forms.Label();
			this.lbl_Protocol = new System.Windows.Forms.Label();
			this.lbl_Password = new System.Windows.Forms.Label();
			this.lbl_Auth = new System.Windows.Forms.Label();
			this.lbl_Username = new System.Windows.Forms.Label();
			this.btn_Connect = new System.Windows.Forms.Button();
			this.btn_Edit = new System.Windows.Forms.Button();
			this.btn_Add = new System.Windows.Forms.Button();
			this.btn_Close = new System.Windows.Forms.Button();
			this.cb_MoreInfo = new System.Windows.Forms.CheckBox();
			this.gb_ServerSpecs.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Server: ";
			// 
			// cb_Servers
			// 
			this.cb_Servers.FormattingEnabled = true;
			this.cb_Servers.Location = new System.Drawing.Point(62, 6);
			this.cb_Servers.Name = "cb_Servers";
			this.cb_Servers.Size = new System.Drawing.Size(266, 21);
			this.cb_Servers.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(10, 25);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Host: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(10, 49);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Port: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(10, 115);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Protocol: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(10, 139);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(35, 13);
			this.label5.TabIndex = 5;
			this.label5.Text = "Auth: ";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(10, 163);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(61, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Username: ";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(10, 187);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 7;
			this.label7.Text = "Password: ";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(10, 211);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(52, 13);
			this.label8.TabIndex = 8;
			this.label8.Text = "Home dir:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(10, 235);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(87, 13);
			this.label9.TabIndex = 9;
			this.label9.Text = "Last connected: ";
			// 
			// gb_ServerSpecs
			// 
			this.gb_ServerSpecs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gb_ServerSpecs.Controls.Add(this.cb_MoreInfo);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Key);
			this.gb_ServerSpecs.Controls.Add(this.lbl_LastUpdate);
			this.gb_ServerSpecs.Controls.Add(this.lbl_ProjectName);
			this.gb_ServerSpecs.Controls.Add(this.lbl_HostName);
			this.gb_ServerSpecs.Controls.Add(this.lbl_LastConnected);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Port);
			this.gb_ServerSpecs.Controls.Add(this.lbl_HomeDir);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Protocol);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Password);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Auth);
			this.gb_ServerSpecs.Controls.Add(this.lbl_Username);
			this.gb_ServerSpecs.Controls.Add(this.btn_Logs);
			this.gb_ServerSpecs.Controls.Add(this.label12);
			this.gb_ServerSpecs.Controls.Add(this.label11);
			this.gb_ServerSpecs.Controls.Add(this.label10);
			this.gb_ServerSpecs.Controls.Add(this.label2);
			this.gb_ServerSpecs.Controls.Add(this.label9);
			this.gb_ServerSpecs.Controls.Add(this.label3);
			this.gb_ServerSpecs.Controls.Add(this.label8);
			this.gb_ServerSpecs.Controls.Add(this.label4);
			this.gb_ServerSpecs.Controls.Add(this.label7);
			this.gb_ServerSpecs.Controls.Add(this.label5);
			this.gb_ServerSpecs.Controls.Add(this.label6);
			this.gb_ServerSpecs.Location = new System.Drawing.Point(15, 33);
			this.gb_ServerSpecs.Name = "gb_ServerSpecs";
			this.gb_ServerSpecs.Size = new System.Drawing.Size(394, 101);
			this.gb_ServerSpecs.TabIndex = 10;
			this.gb_ServerSpecs.TabStop = false;
			this.gb_ServerSpecs.Text = "Connection Settings";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(10, 73);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(46, 13);
			this.label10.TabIndex = 10;
			this.label10.Text = "Project: ";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(10, 259);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(108, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Last update finished: ";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(10, 283);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(31, 13);
			this.label12.TabIndex = 12;
			this.label12.Text = "Key: ";
			// 
			// btn_Logs
			// 
			this.btn_Logs.Location = new System.Drawing.Point(13, 322);
			this.btn_Logs.Name = "btn_Logs";
			this.btn_Logs.Size = new System.Drawing.Size(105, 23);
			this.btn_Logs.TabIndex = 13;
			this.btn_Logs.Text = "Show Logs";
			this.btn_Logs.UseVisualStyleBackColor = true;
			// 
			// lbl_Key
			// 
			this.lbl_Key.AutoSize = true;
			this.lbl_Key.Location = new System.Drawing.Point(131, 283);
			this.lbl_Key.Name = "lbl_Key";
			this.lbl_Key.Size = new System.Drawing.Size(10, 13);
			this.lbl_Key.TabIndex = 24;
			this.lbl_Key.Text = " ";
			// 
			// lbl_LastUpdate
			// 
			this.lbl_LastUpdate.AutoSize = true;
			this.lbl_LastUpdate.Location = new System.Drawing.Point(131, 259);
			this.lbl_LastUpdate.Name = "lbl_LastUpdate";
			this.lbl_LastUpdate.Size = new System.Drawing.Size(10, 13);
			this.lbl_LastUpdate.TabIndex = 23;
			this.lbl_LastUpdate.Text = " ";
			// 
			// lbl_ProjectName
			// 
			this.lbl_ProjectName.AutoSize = true;
			this.lbl_ProjectName.Location = new System.Drawing.Point(131, 73);
			this.lbl_ProjectName.Name = "lbl_ProjectName";
			this.lbl_ProjectName.Size = new System.Drawing.Size(10, 13);
			this.lbl_ProjectName.TabIndex = 22;
			this.lbl_ProjectName.Text = " ";
			// 
			// lbl_HostName
			// 
			this.lbl_HostName.AutoSize = true;
			this.lbl_HostName.Location = new System.Drawing.Point(131, 25);
			this.lbl_HostName.Name = "lbl_HostName";
			this.lbl_HostName.Size = new System.Drawing.Size(10, 13);
			this.lbl_HostName.TabIndex = 14;
			this.lbl_HostName.Text = " ";
			// 
			// lbl_LastConnected
			// 
			this.lbl_LastConnected.AutoSize = true;
			this.lbl_LastConnected.Location = new System.Drawing.Point(131, 235);
			this.lbl_LastConnected.Name = "lbl_LastConnected";
			this.lbl_LastConnected.Size = new System.Drawing.Size(10, 13);
			this.lbl_LastConnected.TabIndex = 21;
			this.lbl_LastConnected.Text = " ";
			// 
			// lbl_Port
			// 
			this.lbl_Port.AutoSize = true;
			this.lbl_Port.Location = new System.Drawing.Point(131, 49);
			this.lbl_Port.Name = "lbl_Port";
			this.lbl_Port.Size = new System.Drawing.Size(10, 13);
			this.lbl_Port.TabIndex = 15;
			this.lbl_Port.Text = " ";
			// 
			// lbl_HomeDir
			// 
			this.lbl_HomeDir.AutoSize = true;
			this.lbl_HomeDir.Location = new System.Drawing.Point(131, 211);
			this.lbl_HomeDir.Name = "lbl_HomeDir";
			this.lbl_HomeDir.Size = new System.Drawing.Size(10, 13);
			this.lbl_HomeDir.TabIndex = 20;
			this.lbl_HomeDir.Text = " ";
			// 
			// lbl_Protocol
			// 
			this.lbl_Protocol.AutoSize = true;
			this.lbl_Protocol.Location = new System.Drawing.Point(131, 115);
			this.lbl_Protocol.Name = "lbl_Protocol";
			this.lbl_Protocol.Size = new System.Drawing.Size(10, 13);
			this.lbl_Protocol.TabIndex = 16;
			this.lbl_Protocol.Text = " ";
			// 
			// lbl_Password
			// 
			this.lbl_Password.AutoSize = true;
			this.lbl_Password.Location = new System.Drawing.Point(131, 187);
			this.lbl_Password.Name = "lbl_Password";
			this.lbl_Password.Size = new System.Drawing.Size(10, 13);
			this.lbl_Password.TabIndex = 19;
			this.lbl_Password.Text = " ";
			// 
			// lbl_Auth
			// 
			this.lbl_Auth.AutoSize = true;
			this.lbl_Auth.Location = new System.Drawing.Point(131, 139);
			this.lbl_Auth.Name = "lbl_Auth";
			this.lbl_Auth.Size = new System.Drawing.Size(10, 13);
			this.lbl_Auth.TabIndex = 17;
			this.lbl_Auth.Text = " ";
			// 
			// lbl_Username
			// 
			this.lbl_Username.AutoSize = true;
			this.lbl_Username.Location = new System.Drawing.Point(131, 163);
			this.lbl_Username.Name = "lbl_Username";
			this.lbl_Username.Size = new System.Drawing.Size(10, 13);
			this.lbl_Username.TabIndex = 18;
			this.lbl_Username.Text = " ";
			// 
			// btn_Connect
			// 
			this.btn_Connect.Location = new System.Drawing.Point(334, 4);
			this.btn_Connect.Name = "btn_Connect";
			this.btn_Connect.Size = new System.Drawing.Size(75, 23);
			this.btn_Connect.TabIndex = 11;
			this.btn_Connect.Text = "Connect";
			this.btn_Connect.UseVisualStyleBackColor = true;
			// 
			// btn_Edit
			// 
			this.btn_Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Edit.Enabled = false;
			this.btn_Edit.Location = new System.Drawing.Point(15, 140);
			this.btn_Edit.Name = "btn_Edit";
			this.btn_Edit.Size = new System.Drawing.Size(75, 23);
			this.btn_Edit.TabIndex = 12;
			this.btn_Edit.Text = "Edit Server";
			this.btn_Edit.UseVisualStyleBackColor = true;
			this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
			// 
			// btn_Add
			// 
			this.btn_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Add.Enabled = false;
			this.btn_Add.Location = new System.Drawing.Point(96, 139);
			this.btn_Add.Name = "btn_Add";
			this.btn_Add.Size = new System.Drawing.Size(75, 23);
			this.btn_Add.TabIndex = 13;
			this.btn_Add.Text = "Add Server";
			this.btn_Add.UseVisualStyleBackColor = true;
			this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
			// 
			// btn_Close
			// 
			this.btn_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btn_Close.Location = new System.Drawing.Point(209, 139);
			this.btn_Close.Name = "btn_Close";
			this.btn_Close.Size = new System.Drawing.Size(200, 23);
			this.btn_Close.TabIndex = 14;
			this.btn_Close.Text = "Close";
			this.btn_Close.UseVisualStyleBackColor = true;
			this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
			// 
			// cb_MoreInfo
			// 
			this.cb_MoreInfo.AutoSize = true;
			this.cb_MoreInfo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cb_MoreInfo.Location = new System.Drawing.Point(312, -1);
			this.cb_MoreInfo.Name = "cb_MoreInfo";
			this.cb_MoreInfo.Size = new System.Drawing.Size(71, 17);
			this.cb_MoreInfo.TabIndex = 25;
			this.cb_MoreInfo.Text = "More Info";
			this.cb_MoreInfo.UseVisualStyleBackColor = true;
			this.cb_MoreInfo.CheckedChanged += new System.EventHandler(this.cb_MoreInfo_CheckedChanged);
			// 
			// f_cts
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(421, 174);
			this.ControlBox = false;
			this.Controls.Add(this.btn_Close);
			this.Controls.Add(this.btn_Add);
			this.Controls.Add(this.btn_Edit);
			this.Controls.Add(this.btn_Connect);
			this.Controls.Add(this.gb_ServerSpecs);
			this.Controls.Add(this.cb_Servers);
			this.Controls.Add(this.label1);
			this.DoubleBuffered = true;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "f_cts";
			this.Text = "Connect to server";
			this.gb_ServerSpecs.ResumeLayout(false);
			this.gb_ServerSpecs.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cb_Servers;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.GroupBox gb_ServerSpecs;
		private System.Windows.Forms.Label lbl_Key;
		private System.Windows.Forms.Label lbl_LastUpdate;
		private System.Windows.Forms.Label lbl_ProjectName;
		private System.Windows.Forms.Label lbl_HostName;
		private System.Windows.Forms.Label lbl_LastConnected;
		private System.Windows.Forms.Label lbl_Port;
		private System.Windows.Forms.Label lbl_HomeDir;
		private System.Windows.Forms.Label lbl_Protocol;
		private System.Windows.Forms.Label lbl_Password;
		private System.Windows.Forms.Label lbl_Auth;
		private System.Windows.Forms.Label lbl_Username;
		private System.Windows.Forms.Button btn_Logs;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Button btn_Connect;
		private System.Windows.Forms.Button btn_Edit;
		private System.Windows.Forms.Button btn_Add;
		private System.Windows.Forms.Button btn_Close;
		private System.Windows.Forms.CheckBox cb_MoreInfo;
	}
}