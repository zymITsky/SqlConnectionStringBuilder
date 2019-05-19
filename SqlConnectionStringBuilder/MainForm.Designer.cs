/*
 * Created by SharpDevelop.
 * User: Administrator
 * Date: 2014/5/21
 * Time: 10:12
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SqlConnectionStringBuilder
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblDataSource = new System.Windows.Forms.Label();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.grpAuth = new System.Windows.Forms.GroupBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.chkIntegrated = new System.Windows.Forms.CheckBox();
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.txtInitialFileName = new System.Windows.Forms.TextBox();
            this.lblInitialFileName = new System.Windows.Forms.Label();
            this.cmbDatabaseName = new System.Windows.Forms.ComboBox();
            this.lblDatabaseName = new System.Windows.Forms.Label();
            this.grpSecure = new System.Windows.Forms.GroupBox();
            this.chkEncrypt = new System.Windows.Forms.CheckBox();
            this.chkPersistSecurityInfo = new System.Windows.Forms.CheckBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblApplicationName = new System.Windows.Forms.Label();
            this.txtApplicationName = new System.Windows.Forms.TextBox();
            this.lblWorkstationID = new System.Windows.Forms.Label();
            this.txtWorkstationID = new System.Windows.Forms.TextBox();
            this.lblNetworkLibrary = new System.Windows.Forms.Label();
            this.cmbNetworkLibrary = new System.Windows.Forms.ComboBox();
            this.lblPacketSize = new System.Windows.Forms.Label();
            this.txtPacketSize = new System.Windows.Forms.TextBox();
            this.cmbSizeUnit = new System.Windows.Forms.ComboBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.cmbTimeUnit = new System.Windows.Forms.ComboBox();
            this.lblLanguage = new System.Windows.Forms.Label();
            this.cmbLanguage = new System.Windows.Forms.ComboBox();
            this.grpConnectionPooling = new System.Windows.Forms.GroupBox();
            this.txtMaxPoolSize = new System.Windows.Forms.TextBox();
            this.lblMaxPoolSize = new System.Windows.Forms.Label();
            this.lblByte2 = new System.Windows.Forms.Label();
            this.lblByte1 = new System.Windows.Forms.Label();
            this.txtMinPoolSize = new System.Windows.Forms.TextBox();
            this.lblMinPoolSize = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.txtConnectionLifetime = new System.Windows.Forms.TextBox();
            this.lblConnectionLifetime = new System.Windows.Forms.Label();
            this.chkEnlist = new System.Windows.Forms.CheckBox();
            this.chkReset = new System.Windows.Forms.CheckBox();
            this.chkPooling = new System.Windows.Forms.CheckBox();
            this.testConnectionWorker = new System.ComponentModel.BackgroundWorker();
            this.grpAuth.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.grpSecure.SuspendLayout();
            this.grpConnectionPooling.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDataSource
            // 
            this.lblDataSource.Location = new System.Drawing.Point(12, 14);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(44, 15);
            this.lblDataSource.TabIndex = 0;
            this.lblDataSource.Text = "数据源";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(63, 11);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(219, 20);
            this.txtDataSource.TabIndex = 1;
            this.txtDataSource.Text = "(local)";
            this.txtDataSource.TextChanged += new System.EventHandler(this.TxtDataSourceTextChanged);
            // 
            // grpAuth
            // 
            this.grpAuth.Controls.Add(this.txtPassword);
            this.grpAuth.Controls.Add(this.lblPassword);
            this.grpAuth.Controls.Add(this.txtUserID);
            this.grpAuth.Controls.Add(this.lblUserID);
            this.grpAuth.Controls.Add(this.chkIntegrated);
            this.grpAuth.Location = new System.Drawing.Point(11, 51);
            this.grpAuth.Name = "grpAuth";
            this.grpAuth.Size = new System.Drawing.Size(271, 131);
            this.grpAuth.TabIndex = 2;
            this.grpAuth.TabStop = false;
            this.grpAuth.Text = "服务器身份验证";
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(65, 89);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(186, 20);
            this.txtPassword.TabIndex = 4;
            this.txtPassword.TextChanged += new System.EventHandler(this.TxtPasswordTextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.Location = new System.Drawing.Point(12, 92);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(36, 18);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "密码";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(65, 56);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(186, 20);
            this.txtUserID.TabIndex = 2;
            this.txtUserID.TextChanged += new System.EventHandler(this.TxtUserIDTextChanged);
            // 
            // lblUserID
            // 
            this.lblUserID.Location = new System.Drawing.Point(12, 60);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(47, 21);
            this.lblUserID.TabIndex = 1;
            this.lblUserID.Text = "用户名";
            // 
            // chkIntegrated
            // 
            this.chkIntegrated.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkIntegrated.Checked = true;
            this.chkIntegrated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkIntegrated.Location = new System.Drawing.Point(12, 27);
            this.chkIntegrated.Name = "chkIntegrated";
            this.chkIntegrated.Size = new System.Drawing.Size(196, 21);
            this.chkIntegrated.TabIndex = 0;
            this.chkIntegrated.Text = "Windows 身份验证模式";
            this.chkIntegrated.UseVisualStyleBackColor = true;
            this.chkIntegrated.CheckedChanged += new System.EventHandler(this.ChkIntegratedCheckedChanged);
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.txtInitialFileName);
            this.grpDatabase.Controls.Add(this.lblInitialFileName);
            this.grpDatabase.Controls.Add(this.cmbDatabaseName);
            this.grpDatabase.Controls.Add(this.lblDatabaseName);
            this.grpDatabase.Location = new System.Drawing.Point(10, 196);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(271, 96);
            this.grpDatabase.TabIndex = 3;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "使用数据库";
            // 
            // txtInitialFileName
            // 
            this.txtInitialFileName.Location = new System.Drawing.Point(97, 57);
            this.txtInitialFileName.Name = "txtInitialFileName";
            this.txtInitialFileName.Size = new System.Drawing.Size(154, 20);
            this.txtInitialFileName.TabIndex = 3;
            this.txtInitialFileName.TextChanged += new System.EventHandler(this.TxtInitialFileNameTextChanged);
            // 
            // lblInitialFileName
            // 
            this.lblInitialFileName.Location = new System.Drawing.Point(11, 62);
            this.lblInitialFileName.Name = "lblInitialFileName";
            this.lblInitialFileName.Size = new System.Drawing.Size(68, 17);
            this.lblInitialFileName.TabIndex = 2;
            this.lblInitialFileName.Text = "附加数据库";
            // 
            // cmbDatabaseName
            // 
            this.cmbDatabaseName.DisplayMember = "DATABASE_NAME";
            this.cmbDatabaseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatabaseName.FormattingEnabled = true;
            this.cmbDatabaseName.Location = new System.Drawing.Point(97, 25);
            this.cmbDatabaseName.Name = "cmbDatabaseName";
            this.cmbDatabaseName.Size = new System.Drawing.Size(155, 21);
            this.cmbDatabaseName.TabIndex = 1;
            this.cmbDatabaseName.SelectedIndexChanged += new System.EventHandler(this.CmbDatabaseNameSelectedIndexChanged);
            this.cmbDatabaseName.Click += new System.EventHandler(this.CmbDatabaseNameClick);
            // 
            // lblDatabaseName
            // 
            this.lblDatabaseName.Location = new System.Drawing.Point(12, 28);
            this.lblDatabaseName.Name = "lblDatabaseName";
            this.lblDatabaseName.Size = new System.Drawing.Size(70, 20);
            this.lblDatabaseName.TabIndex = 0;
            this.lblDatabaseName.Text = "数据库名称";
            // 
            // grpSecure
            // 
            this.grpSecure.Controls.Add(this.chkEncrypt);
            this.grpSecure.Controls.Add(this.chkPersistSecurityInfo);
            this.grpSecure.Location = new System.Drawing.Point(10, 304);
            this.grpSecure.Name = "grpSecure";
            this.grpSecure.Size = new System.Drawing.Size(270, 67);
            this.grpSecure.TabIndex = 4;
            this.grpSecure.TabStop = false;
            this.grpSecure.Text = "安全性";
            // 
            // chkEncrypt
            // 
            this.chkEncrypt.Location = new System.Drawing.Point(164, 27);
            this.chkEncrypt.Name = "chkEncrypt";
            this.chkEncrypt.Size = new System.Drawing.Size(87, 26);
            this.chkEncrypt.TabIndex = 1;
            this.chkEncrypt.Text = "加密连接";
            this.chkEncrypt.UseVisualStyleBackColor = true;
            this.chkEncrypt.CheckedChanged += new System.EventHandler(this.ChkEncryptCheckedChanged);
            // 
            // chkPersistSecurityInfo
            // 
            this.chkPersistSecurityInfo.Location = new System.Drawing.Point(16, 27);
            this.chkPersistSecurityInfo.Name = "chkPersistSecurityInfo";
            this.chkPersistSecurityInfo.Size = new System.Drawing.Size(99, 26);
            this.chkPersistSecurityInfo.TabIndex = 0;
            this.chkPersistSecurityInfo.Text = "保存安全信息";
            this.chkPersistSecurityInfo.UseVisualStyleBackColor = true;
            this.chkPersistSecurityInfo.CheckedChanged += new System.EventHandler(this.ChkPersistSecurityInfoCheckedChanged);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(10, 388);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.ReadOnly = true;
            this.txtConnectionString.Size = new System.Drawing.Size(634, 96);
            this.txtConnectionString.TabIndex = 5;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(13, 499);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(152, 28);
            this.btnTest.TabIndex = 6;
            this.btnTest.Text = "测试连接";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.BtnTestClick);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(255, 499);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(152, 28);
            this.btnCopy.TabIndex = 7;
            this.btnCopy.Text = "复制连接字符串";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopyClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(492, 499);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "退出";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.BtnExitClick);
            // 
            // lblApplicationName
            // 
            this.lblApplicationName.Location = new System.Drawing.Point(307, 14);
            this.lblApplicationName.Name = "lblApplicationName";
            this.lblApplicationName.Size = new System.Drawing.Size(83, 15);
            this.lblApplicationName.TabIndex = 9;
            this.lblApplicationName.Text = "应用程序名称";
            // 
            // txtApplicationName
            // 
            this.txtApplicationName.Location = new System.Drawing.Point(406, 10);
            this.txtApplicationName.Name = "txtApplicationName";
            this.txtApplicationName.Size = new System.Drawing.Size(238, 20);
            this.txtApplicationName.TabIndex = 10;
            this.txtApplicationName.Text = ".Net SqlClient Data Provider";
            this.txtApplicationName.TextChanged += new System.EventHandler(this.TxtApplicationNameTextChanged);
            // 
            // lblWorkstationID
            // 
            this.lblWorkstationID.Location = new System.Drawing.Point(307, 49);
            this.lblWorkstationID.Name = "lblWorkstationID";
            this.lblWorkstationID.Size = new System.Drawing.Size(93, 17);
            this.lblWorkstationID.TabIndex = 11;
            this.lblWorkstationID.Text = "本地计算机名称";
            // 
            // txtWorkstationID
            // 
            this.txtWorkstationID.Location = new System.Drawing.Point(406, 46);
            this.txtWorkstationID.Name = "txtWorkstationID";
            this.txtWorkstationID.Size = new System.Drawing.Size(238, 20);
            this.txtWorkstationID.TabIndex = 12;
            this.txtWorkstationID.TextChanged += new System.EventHandler(this.TxtWorkstationIDTextChanged);
            // 
            // lblNetworkLibrary
            // 
            this.lblNetworkLibrary.Location = new System.Drawing.Point(307, 83);
            this.lblNetworkLibrary.Name = "lblNetworkLibrary";
            this.lblNetworkLibrary.Size = new System.Drawing.Size(83, 22);
            this.lblNetworkLibrary.TabIndex = 13;
            this.lblNetworkLibrary.Text = "连接方式";
            // 
            // cmbNetworkLibrary
            // 
            this.cmbNetworkLibrary.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNetworkLibrary.FormattingEnabled = true;
            this.cmbNetworkLibrary.Items.AddRange(new object[] {
            "TCP/IP",
            "Shared Memory",
            "Named Pipes",
            "Multiprotocol",
            "Apple Talk",
            "VIA",
            "IPX/SPX"});
            this.cmbNetworkLibrary.Location = new System.Drawing.Point(406, 80);
            this.cmbNetworkLibrary.Name = "cmbNetworkLibrary";
            this.cmbNetworkLibrary.Size = new System.Drawing.Size(238, 21);
            this.cmbNetworkLibrary.TabIndex = 14;
            this.cmbNetworkLibrary.SelectedIndexChanged += new System.EventHandler(this.CmbNetworkLibrarySelectedIndexChanged);
            // 
            // lblPacketSize
            // 
            this.lblPacketSize.Location = new System.Drawing.Point(307, 117);
            this.lblPacketSize.Name = "lblPacketSize";
            this.lblPacketSize.Size = new System.Drawing.Size(93, 23);
            this.lblPacketSize.TabIndex = 15;
            this.lblPacketSize.Text = "数据包大小";
            // 
            // txtPacketSize
            // 
            this.txtPacketSize.Location = new System.Drawing.Point(406, 114);
            this.txtPacketSize.Name = "txtPacketSize";
            this.txtPacketSize.Size = new System.Drawing.Size(172, 20);
            this.txtPacketSize.TabIndex = 16;
            this.txtPacketSize.Text = "8192";
            this.txtPacketSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPacketSize.TextChanged += new System.EventHandler(this.TxtPacketSizeTextChanged);
            this.txtPacketSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtPacketSizeKeyPress);
            // 
            // cmbSizeUnit
            // 
            this.cmbSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSizeUnit.FormattingEnabled = true;
            this.cmbSizeUnit.Items.AddRange(new object[] {
            "Bytes",
            "KB"});
            this.cmbSizeUnit.Location = new System.Drawing.Point(584, 114);
            this.cmbSizeUnit.Name = "cmbSizeUnit";
            this.cmbSizeUnit.Size = new System.Drawing.Size(60, 21);
            this.cmbSizeUnit.TabIndex = 17;
            this.cmbSizeUnit.SelectedIndexChanged += new System.EventHandler(this.CmbSizeUnitSelectedIndexChanged);
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.Location = new System.Drawing.Point(307, 150);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(93, 20);
            this.lblTimeOut.TabIndex = 18;
            this.lblTimeOut.Text = "过期时间";
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.Location = new System.Drawing.Point(406, 146);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(172, 20);
            this.txtTimeOut.TabIndex = 19;
            this.txtTimeOut.Text = "15";
            this.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtTimeOut.TextChanged += new System.EventHandler(this.TxtTimeOutTextChanged);
            this.txtTimeOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtTimeOutKeyPress);
            // 
            // cmbTimeUnit
            // 
            this.cmbTimeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimeUnit.FormattingEnabled = true;
            this.cmbTimeUnit.Items.AddRange(new object[] {
            "秒",
            "分钟"});
            this.cmbTimeUnit.Location = new System.Drawing.Point(585, 146);
            this.cmbTimeUnit.Name = "cmbTimeUnit";
            this.cmbTimeUnit.Size = new System.Drawing.Size(59, 21);
            this.cmbTimeUnit.TabIndex = 20;
            this.cmbTimeUnit.SelectedIndexChanged += new System.EventHandler(this.CmbTimeUnitSelectedIndexChanged);
            // 
            // lblLanguage
            // 
            this.lblLanguage.Location = new System.Drawing.Point(307, 182);
            this.lblLanguage.Name = "lblLanguage";
            this.lblLanguage.Size = new System.Drawing.Size(79, 16);
            this.lblLanguage.TabIndex = 21;
            this.lblLanguage.Text = "语言";
            // 
            // cmbLanguage
            // 
            this.cmbLanguage.DisplayMember = "alias";
            this.cmbLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLanguage.FormattingEnabled = true;
            this.cmbLanguage.Location = new System.Drawing.Point(406, 178);
            this.cmbLanguage.Name = "cmbLanguage";
            this.cmbLanguage.Size = new System.Drawing.Size(238, 21);
            this.cmbLanguage.TabIndex = 22;
            this.cmbLanguage.SelectedIndexChanged += new System.EventHandler(this.CmbLanguageSelectedIndexChanged);
            this.cmbLanguage.Click += new System.EventHandler(this.CmbLanguageClick);
            // 
            // grpConnectionPooling
            // 
            this.grpConnectionPooling.Controls.Add(this.txtMaxPoolSize);
            this.grpConnectionPooling.Controls.Add(this.lblMaxPoolSize);
            this.grpConnectionPooling.Controls.Add(this.lblByte2);
            this.grpConnectionPooling.Controls.Add(this.lblByte1);
            this.grpConnectionPooling.Controls.Add(this.txtMinPoolSize);
            this.grpConnectionPooling.Controls.Add(this.lblMinPoolSize);
            this.grpConnectionPooling.Controls.Add(this.lblSecond);
            this.grpConnectionPooling.Controls.Add(this.txtConnectionLifetime);
            this.grpConnectionPooling.Controls.Add(this.lblConnectionLifetime);
            this.grpConnectionPooling.Controls.Add(this.chkEnlist);
            this.grpConnectionPooling.Controls.Add(this.chkReset);
            this.grpConnectionPooling.Controls.Add(this.chkPooling);
            this.grpConnectionPooling.Location = new System.Drawing.Point(308, 206);
            this.grpConnectionPooling.Name = "grpConnectionPooling";
            this.grpConnectionPooling.Size = new System.Drawing.Size(335, 165);
            this.grpConnectionPooling.TabIndex = 23;
            this.grpConnectionPooling.TabStop = false;
            this.grpConnectionPooling.Text = "连接池";
            // 
            // txtMaxPoolSize
            // 
            this.txtMaxPoolSize.Location = new System.Drawing.Point(152, 124);
            this.txtMaxPoolSize.Name = "txtMaxPoolSize";
            this.txtMaxPoolSize.Size = new System.Drawing.Size(131, 20);
            this.txtMaxPoolSize.TabIndex = 10;
            this.txtMaxPoolSize.Text = "100";
            this.txtMaxPoolSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMaxPoolSize.TextChanged += new System.EventHandler(this.TxtMaxPoolSizeTextChanged);
            this.txtMaxPoolSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMaxPoolSizeKeyPress);
            // 
            // lblMaxPoolSize
            // 
            this.lblMaxPoolSize.Location = new System.Drawing.Point(21, 127);
            this.lblMaxPoolSize.Name = "lblMaxPoolSize";
            this.lblMaxPoolSize.Size = new System.Drawing.Size(102, 22);
            this.lblMaxPoolSize.TabIndex = 9;
            this.lblMaxPoolSize.Text = "最大连接池大小";
            // 
            // lblByte2
            // 
            this.lblByte2.Location = new System.Drawing.Point(289, 127);
            this.lblByte2.Name = "lblByte2";
            this.lblByte2.Size = new System.Drawing.Size(39, 17);
            this.lblByte2.TabIndex = 8;
            this.lblByte2.Text = "字节";
            // 
            // lblByte1
            // 
            this.lblByte1.Location = new System.Drawing.Point(289, 93);
            this.lblByte1.Name = "lblByte1";
            this.lblByte1.Size = new System.Drawing.Size(39, 17);
            this.lblByte1.TabIndex = 8;
            this.lblByte1.Text = "字节";
            // 
            // txtMinPoolSize
            // 
            this.txtMinPoolSize.Location = new System.Drawing.Point(152, 90);
            this.txtMinPoolSize.Name = "txtMinPoolSize";
            this.txtMinPoolSize.Size = new System.Drawing.Size(131, 20);
            this.txtMinPoolSize.TabIndex = 7;
            this.txtMinPoolSize.Text = "0";
            this.txtMinPoolSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMinPoolSize.TextChanged += new System.EventHandler(this.TxtMinPoolSizeTextChanged);
            this.txtMinPoolSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtMinPoolSizeKeyPress);
            // 
            // lblMinPoolSize
            // 
            this.lblMinPoolSize.Location = new System.Drawing.Point(21, 93);
            this.lblMinPoolSize.Name = "lblMinPoolSize";
            this.lblMinPoolSize.Size = new System.Drawing.Size(102, 21);
            this.lblMinPoolSize.TabIndex = 6;
            this.lblMinPoolSize.Text = "最小连接池大小";
            // 
            // lblSecond
            // 
            this.lblSecond.Location = new System.Drawing.Point(289, 60);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(25, 17);
            this.lblSecond.TabIndex = 5;
            this.lblSecond.Text = "秒";
            // 
            // txtConnectionLifetime
            // 
            this.txtConnectionLifetime.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "0"});
            this.txtConnectionLifetime.Location = new System.Drawing.Point(152, 56);
            this.txtConnectionLifetime.Name = "txtConnectionLifetime";
            this.txtConnectionLifetime.Size = new System.Drawing.Size(131, 20);
            this.txtConnectionLifetime.TabIndex = 4;
            this.txtConnectionLifetime.Text = "0";
            this.txtConnectionLifetime.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtConnectionLifetime.TextChanged += new System.EventHandler(this.TxtConnectionLifetimeTextChanged);
            this.txtConnectionLifetime.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtConnectionLifetimeKeyPress);
            // 
            // lblConnectionLifetime
            // 
            this.lblConnectionLifetime.Location = new System.Drawing.Point(21, 60);
            this.lblConnectionLifetime.Name = "lblConnectionLifetime";
            this.lblConnectionLifetime.Size = new System.Drawing.Size(78, 17);
            this.lblConnectionLifetime.TabIndex = 3;
            this.lblConnectionLifetime.Text = "连接生存期";
            // 
            // chkEnlist
            // 
            this.chkEnlist.Checked = true;
            this.chkEnlist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEnlist.Location = new System.Drawing.Point(228, 25);
            this.chkEnlist.Name = "chkEnlist";
            this.chkEnlist.Size = new System.Drawing.Size(102, 21);
            this.chkEnlist.TabIndex = 2;
            this.chkEnlist.Text = "启用事务登记";
            this.chkEnlist.UseVisualStyleBackColor = true;
            this.chkEnlist.CheckedChanged += new System.EventHandler(this.ChkEnlistCheckedChanged);
            // 
            // chkReset
            // 
            this.chkReset.Checked = true;
            this.chkReset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReset.Location = new System.Drawing.Point(130, 24);
            this.chkReset.Name = "chkReset";
            this.chkReset.Size = new System.Drawing.Size(83, 24);
            this.chkReset.TabIndex = 1;
            this.chkReset.Text = "重置连接";
            this.chkReset.UseVisualStyleBackColor = true;
            this.chkReset.CheckedChanged += new System.EventHandler(this.ChkResetCheckedChanged);
            // 
            // chkPooling
            // 
            this.chkPooling.Checked = true;
            this.chkPooling.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPooling.Location = new System.Drawing.Point(21, 25);
            this.chkPooling.Name = "chkPooling";
            this.chkPooling.Size = new System.Drawing.Size(88, 23);
            this.chkPooling.TabIndex = 0;
            this.chkPooling.Text = "启用连接池";
            this.chkPooling.UseVisualStyleBackColor = true;
            this.chkPooling.CheckedChanged += new System.EventHandler(this.ChkPoolingCheckedChanged);
            // 
            // testConnectionWorker
            // 
            this.testConnectionWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.testConnectionWorker_DoWork);
            this.testConnectionWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.testConnectionWorker_RunWorkerCompleted);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 546);
            this.Controls.Add(this.grpConnectionPooling);
            this.Controls.Add(this.cmbLanguage);
            this.Controls.Add(this.lblLanguage);
            this.Controls.Add(this.cmbTimeUnit);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.cmbSizeUnit);
            this.Controls.Add(this.txtPacketSize);
            this.Controls.Add(this.lblPacketSize);
            this.Controls.Add(this.cmbNetworkLibrary);
            this.Controls.Add(this.lblNetworkLibrary);
            this.Controls.Add(this.txtWorkstationID);
            this.Controls.Add(this.lblWorkstationID);
            this.Controls.Add(this.txtApplicationName);
            this.Controls.Add(this.lblApplicationName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.grpSecure);
            this.Controls.Add(this.grpDatabase);
            this.Controls.Add(this.grpAuth);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.lblDataSource);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL Server 连接字符串构造及测试工具";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.grpAuth.ResumeLayout(false);
            this.grpAuth.PerformLayout();
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.grpSecure.ResumeLayout(false);
            this.grpConnectionPooling.ResumeLayout(false);
            this.grpConnectionPooling.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Label lblByte2;
		private System.Windows.Forms.TextBox txtMaxPoolSize;
		private System.Windows.Forms.Label lblMaxPoolSize;
		private System.Windows.Forms.TextBox txtMinPoolSize;
		private System.Windows.Forms.Label lblByte1;
		private System.Windows.Forms.Label lblMinPoolSize;
		private System.Windows.Forms.TextBox txtConnectionLifetime;
		private System.Windows.Forms.Label lblSecond;
		private System.Windows.Forms.Label lblConnectionLifetime;
		private System.Windows.Forms.CheckBox chkPooling;
		private System.Windows.Forms.CheckBox chkReset;
		private System.Windows.Forms.CheckBox chkEnlist;
		private System.Windows.Forms.GroupBox grpConnectionPooling;
		private System.Windows.Forms.ComboBox cmbLanguage;
		private System.Windows.Forms.Label lblLanguage;
		private System.Windows.Forms.ComboBox cmbTimeUnit;
		private System.Windows.Forms.TextBox txtTimeOut;
		private System.Windows.Forms.Label lblTimeOut;
		private System.Windows.Forms.ComboBox cmbSizeUnit;
		private System.Windows.Forms.TextBox txtPacketSize;
		private System.Windows.Forms.Label lblPacketSize;
		private System.Windows.Forms.ComboBox cmbNetworkLibrary;
		private System.Windows.Forms.Label lblNetworkLibrary;
		private System.Windows.Forms.TextBox txtWorkstationID;
		private System.Windows.Forms.Label lblWorkstationID;
		private System.Windows.Forms.TextBox txtApplicationName;
		private System.Windows.Forms.Label lblApplicationName;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Button btnCopy;
		private System.Windows.Forms.Button btnTest;
		private System.Windows.Forms.TextBox txtConnectionString;
		private System.Windows.Forms.CheckBox chkEncrypt;
		private System.Windows.Forms.CheckBox chkPersistSecurityInfo;
		private System.Windows.Forms.GroupBox grpSecure;
		private System.Windows.Forms.TextBox txtInitialFileName;
		private System.Windows.Forms.Label lblInitialFileName;
		private System.Windows.Forms.ComboBox cmbDatabaseName;
		private System.Windows.Forms.Label lblDatabaseName;
		private System.Windows.Forms.GroupBox grpDatabase;
		private System.Windows.Forms.TextBox txtPassword;
		private System.Windows.Forms.Label lblPassword;
		private System.Windows.Forms.TextBox txtUserID;
		private System.Windows.Forms.Label lblUserID;
		private System.Windows.Forms.CheckBox chkIntegrated;
		private System.Windows.Forms.GroupBox grpAuth;
		private System.Windows.Forms.TextBox txtDataSource;
		private System.Windows.Forms.Label lblDataSource;
        private System.ComponentModel.BackgroundWorker testConnectionWorker;
	}
}
