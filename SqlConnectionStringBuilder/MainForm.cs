using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Windows.Forms;

namespace SqlConnectionStringBuilder
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        private System.Data.SqlClient.SqlConnectionStringBuilder sqlConnStr = new System.Data.SqlClient.SqlConnectionStringBuilder() { DataSource = "(local)", IntegratedSecurity = true };
        private SqlConnection cn;
        private DataTable dt;
        private bool isLanguageConnected = false;
        private bool isDatabaseNameConnected = false;
        private bool reset, enlist;
        private int loadBalanceTimeout, minPoolSize, maxPoolSize;

        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void MainFormLoad(object sender, EventArgs e)
        {
            cmbNetworkLibrary.SelectedIndex = 0;
            cmbSizeUnit.SelectedIndex = 0;
            cmbTimeUnit.SelectedIndex = 0;
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void BtnExitClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void BtnCopyClick(object sender, EventArgs e)
        {
            string connString = txtConnectionString.Text.Trim();
            if (connString != string.Empty)
            {
                Clipboard.SetText(connString);
                if (Clipboard.ContainsText())
                    MessageBox.Show("已经复制连接字符串到剪贴板！");
            }
        }

        void BtnTestClick(object sender, EventArgs e)
        {
            Visible = false;
            testConnectionWorker.RunWorkerAsync();
        }

        void TestConnection()
        {
            try
            {
                cn = new SqlConnection(sqlConnStr.ConnectionString);
                cn.Open();
                cn.Close();
                MessageBox.Show("连接数据库成功！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("连接数据库失败！", "测试连接", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void ChkIntegratedCheckedChanged(object sender, EventArgs e)
        {
            txtUserID.Enabled = !chkIntegrated.Checked;
            txtPassword.Enabled = !chkIntegrated.Checked;
            if (chkIntegrated.Checked)
            {
                sqlConnStr.Remove("User ID");
                sqlConnStr.Remove("Password");
                sqlConnStr.IntegratedSecurity = true;
            }
            else
            {
                sqlConnStr.Remove("Integrated Security");
                string UserID = txtUserID.Text.Trim();
                string Password = txtPassword.Text.Trim();
                if (UserID != string.Empty)
                    sqlConnStr.UserID = UserID;
                if (Password != string.Empty)
                    sqlConnStr.Password = Password;
            }
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            isDatabaseNameConnected = false;
            isLanguageConnected = false;
        }

        void CmbNetworkLibrarySelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbNetworkLibrary.Text.Trim())
            {
                case "TCP/IP":
                    sqlConnStr.Remove("Network Library");
                    break;
                case "Shared Memory":
                    sqlConnStr.NetworkLibrary = "dbmslpcn";
                    break;
                case "Named Pipes":
                    sqlConnStr.NetworkLibrary = "dbnmpntw";
                    break;
                case "Multiprotocol":
                    sqlConnStr.NetworkLibrary = "dbmsrpcn";
                    break;
                case "Apple Talk":
                    sqlConnStr.NetworkLibrary = "dbmsadsn";
                    break;
                case "VIA":
                    sqlConnStr.NetworkLibrary = "dbmsgnet";
                    break;
                case "IPX/SPX":
                    sqlConnStr.NetworkLibrary = "dbmsspxn";
                    break;
            }
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void CmbSizeUnitSelectedIndexChanged(object sender, EventArgs e)
        {
            TxtPacketSizeTextChanged(sender, e);
        }

        void CmbTimeUnitSelectedIndexChanged(object sender, EventArgs e)
        {
            TxtTimeOutTextChanged(sender, e);
        }

        void TxtDataSourceTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.DataSource = txtDataSource.Text.Trim();
            if (sqlConnStr.DataSource == string.Empty)
                sqlConnStr.Remove("Data Source");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            isDatabaseNameConnected = false;
            isLanguageConnected = false;
        }

        void TxtUserIDTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.UserID = txtUserID.Text.Trim();
            if (sqlConnStr.UserID == string.Empty)
                sqlConnStr.Remove("User ID");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            isDatabaseNameConnected = false;
            isLanguageConnected = false;
        }

        void TxtPasswordTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.Password = txtPassword.Text.Trim();
            if (sqlConnStr.Password == string.Empty)
                sqlConnStr.Remove("Password");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            isDatabaseNameConnected = false;
            isLanguageConnected = false;
        }

        void CmbDatabaseNameSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDatabaseName.Items.Count > 0)
            {
                if (cmbDatabaseName.Text == string.Empty)
                    sqlConnStr.Remove("Initial Catalog");
                else
                    sqlConnStr.InitialCatalog = cmbDatabaseName.Text;
                txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            }
        }

        void TxtInitialFileNameTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.AttachDBFilename = txtInitialFileName.Text.Trim();
            if (sqlConnStr.AttachDBFilename == string.Empty)
                sqlConnStr.Remove("AttachDBFilename");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void ChkPersistSecurityInfoCheckedChanged(object sender, EventArgs e)
        {
            sqlConnStr.PersistSecurityInfo = chkPersistSecurityInfo.Checked;
            if (!sqlConnStr.PersistSecurityInfo)
                sqlConnStr.Remove("PersistSecurityInfo");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void ChkEncryptCheckedChanged(object sender, EventArgs e)
        {
            sqlConnStr.Encrypt = chkEncrypt.Checked;
            if (!sqlConnStr.Encrypt)
                sqlConnStr.Remove("Encrypt");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void ChkPoolingCheckedChanged(object sender, EventArgs e)
        {
            sqlConnStr.Pooling = chkPooling.Checked;
            if (sqlConnStr.Pooling)
            {
                chkReset.Enabled = chkEnlist.Enabled = txtConnectionLifetime.Enabled = txtMinPoolSize.Enabled = txtMaxPoolSize.Enabled = true;
                if (!reset)
                    sqlConnStr.ConnectionReset = reset;
                if (!enlist)
                    sqlConnStr.Enlist = enlist;
                if (loadBalanceTimeout > 0)
                    sqlConnStr.LoadBalanceTimeout = loadBalanceTimeout;
                if (minPoolSize > 0)
                    sqlConnStr.MinPoolSize = minPoolSize;
                if (maxPoolSize != 100)
                    sqlConnStr.MaxPoolSize = maxPoolSize;
                sqlConnStr.Remove("Pooling");
            }
            else
            {
                chkReset.Enabled = chkEnlist.Enabled = txtConnectionLifetime.Enabled = txtMinPoolSize.Enabled = txtMaxPoolSize.Enabled = false;
                reset = sqlConnStr.ConnectionReset;
                sqlConnStr.Remove("Connection Reset");
                enlist = sqlConnStr.Enlist;
                sqlConnStr.Remove("Enlist");
                loadBalanceTimeout = sqlConnStr.LoadBalanceTimeout;
                sqlConnStr.Remove("Load Balance Timeout");
                minPoolSize = sqlConnStr.MinPoolSize;
                sqlConnStr.Remove("Min Pool Size");
                maxPoolSize = sqlConnStr.MaxPoolSize;
                sqlConnStr.Remove("Max Pool Size");
            }
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void ChkResetCheckedChanged(object sender, EventArgs e)
        {
            sqlConnStr.ConnectionReset = chkReset.Checked;
            if (sqlConnStr.ConnectionReset)
                sqlConnStr.Remove("Connection Reset");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void ChkEnlistCheckedChanged(object sender, EventArgs e)
        {
            sqlConnStr.Enlist = chkEnlist.Checked;
            if (sqlConnStr.Enlist)
                sqlConnStr.Remove("Enlist");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtConnectionLifetimeTextChanged(object sender, EventArgs e)
        {
            int connectionLifetime = 0;
            if (txtConnectionLifetime.Text.Length > 0)
                connectionLifetime = Int32.Parse(txtConnectionLifetime.Text);
            if (connectionLifetime == 0)
                sqlConnStr.Remove("Load Balance Timeout");
            else
                sqlConnStr.LoadBalanceTimeout = connectionLifetime;
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtConnectionLifetimeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') || (txtConnectionLifetime.Text.Length == 2 && e.KeyChar != '\b'))
                e.Handled = true;
        }

        void TxtMinPoolSizeTextChanged(object sender, System.EventArgs e)
        {
            int MinPoolSize = 0;
            if (txtMinPoolSize.Text.Length > 0)
                MinPoolSize = Int32.Parse(txtMinPoolSize.Text);
            if (MinPoolSize == 0)
                sqlConnStr.Remove("Min Pool Size");
            else
                sqlConnStr.MinPoolSize = MinPoolSize;
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtMaxPoolSizeTextChanged(object sender, EventArgs e)
        {
            int MaxPoolSize = 0;
            if (txtMaxPoolSize.Text.Length > 0)
                MaxPoolSize = Int32.Parse(txtMaxPoolSize.Text);
            if (MaxPoolSize == 100)
                sqlConnStr.Remove("Max Pool Size");
            else
                sqlConnStr.MaxPoolSize = MaxPoolSize;
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtMaxPoolSizeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') || (txtMaxPoolSize.Text.Length == 5 && e.KeyChar != '\b'))
                e.Handled = true;
        }

        void TxtMinPoolSizeKeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') || (txtMinPoolSize.Text.Length == 5 && e.KeyChar != '\b'))
                e.Handled = true;
        }

        void TxtPacketSizeTextChanged(object sender, EventArgs e)
        {
            if (txtPacketSize.Text.Length > 0)
            {
                long PacketSize = Int32.Parse(txtPacketSize.Text);
                if (cmbSizeUnit.Text == "KB")
                    PacketSize *= 1024;
                if (PacketSize >= 512 && PacketSize <= 32768)
                    sqlConnStr.PacketSize = (int)PacketSize;
                else
                    sqlConnStr.Remove("Packet Size");
            }
            if (txtPacketSize.Text.Length == 0 || sqlConnStr.PacketSize == 8192)
                sqlConnStr.Remove("Packet Size");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtTimeOutTextChanged(object sender, System.EventArgs e)
        {
            if (txtTimeOut.Text.Length > 0)
                sqlConnStr.ConnectTimeout = Int32.Parse(txtTimeOut.Text);
            if (cmbTimeUnit.Text == "分钟")
                sqlConnStr.ConnectTimeout *= 60;
            if (txtTimeOut.Text.Length == 0 || sqlConnStr.ConnectTimeout == 0 || sqlConnStr.ConnectTimeout == 15)
                sqlConnStr.Remove("Connect Timeout");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtPacketSizeKeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtPacketSize.SelectionLength == 0 && (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') || (txtPacketSize.Text.Length - txtPacketSize.SelectionLength == 5 && e.KeyChar != '\b')))
                e.Handled = true;
        }

        void TxtTimeOutKeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar) || e.KeyChar == '\b') || (txtTimeOut.Text.Length - txtTimeOut.SelectionLength == 2 && e.KeyChar != '\b'))
                e.Handled = true;
        }

        void TxtWorkstationIDTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.WorkstationID = txtWorkstationID.Text.Trim();
            if (sqlConnStr.WorkstationID == string.Empty)
                sqlConnStr.Remove("Workstation ID");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void TxtApplicationNameTextChanged(object sender, EventArgs e)
        {
            sqlConnStr.ApplicationName = txtApplicationName.Text.Trim();
            if (sqlConnStr.ApplicationName == string.Empty || sqlConnStr.ApplicationName == ".Net SqlClient Data Provider")
                sqlConnStr.Remove("Application Name");
            txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
        }

        void CmbDatabaseNameClick(object sender, EventArgs e)
        {
            if (!isDatabaseNameConnected)
            {
                try
                {
                    Thread thDatabaseNames = new Thread(GetDatabaseNames);
                    thDatabaseNames.Start();
                    btnExit.Enabled = btnCopy.Enabled = btnTest.Enabled = false;
                    btnTest.Text = "连接数据库中";
                    thDatabaseNames.Join();
                    btnExit.Enabled = btnCopy.Enabled = btnTest.Enabled = true;
                    btnTest.Text = "测试连接";
                    cmbDatabaseName.DataSource = dt;
                    isDatabaseNameConnected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败！", "获取数据库", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void GetDatabaseNames()
        {
            try
            {
                cn = new SqlConnection(sqlConnStr.ConnectionString);
                cn.Open();
                dt = cn.GetSchema("Databases");
                cn.Close();
                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception)
            {

            }
        }

        void CmbLanguageSelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.Items.Count > 0)
            {
                if (cmbLanguage.Text == string.Empty)
                    sqlConnStr.Remove("Current Language");
                else
                    sqlConnStr.CurrentLanguage = cmbLanguage.Text;
                txtConnectionString.Text = sqlConnStr.ConnectionString + ";";
            }
        }

        void CmbLanguageClick(object sender, EventArgs e)
        {
            if (!isLanguageConnected)
            {
                try
                {
                    Thread thDatabaseLanguages = new Thread(GetDatabaseLanguages);
                    thDatabaseLanguages.Start();
                    btnExit.Enabled = btnCopy.Enabled = btnTest.Enabled = false;
                    btnTest.Text = "连接数据库中";
                    thDatabaseLanguages.Join();
                    btnExit.Enabled = btnCopy.Enabled = btnTest.Enabled = true;
                    btnTest.Text = "测试连接";
                    cmbLanguage.DataSource = dt;
                    isLanguageConnected = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("连接数据库失败！", "获取数据库语言", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void GetDatabaseLanguages()
        {
            try
            {
                cn = new SqlConnection(sqlConnStr.ConnectionString);
                cn.Open();
                dt = new DataTable();
                new SqlDataAdapter(new SqlCommand("exec sp_helplanguage", cn)).Fill(dt);
                cn.Close();
                DataRow dr = dt.NewRow();
                dt.Rows.InsertAt(dr, 0);
            }
            catch (Exception)
            {

            }
        }

        private void testConnectionWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            TestConnection();
        }

        private void testConnectionWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            Visible = true;
        }
    }
}
