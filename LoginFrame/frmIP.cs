using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LoginFrame
{
    public partial class frmIP : Form
    {
        private string serverName, userName, password, connectionString;
        public frmIP()
        {
            InitializeComponent();         
        }   
        private void frmIP_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            btnTest.Enabled = false; ;
            this.CenterToParent();//窗体在父窗体中居中
            this.txbServer.Text = System.Configuration.ConfigurationManager.AppSettings["IP"].ToString();
            this.txbUserName.Text = System.Configuration.ConfigurationManager.AppSettings["userID"].ToString();
            this.txbPwd.Text = System.Configuration.ConfigurationManager.AppSettings["password"].ToString();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {       
            serverName = txbServer.Text.Trim();    
            userName = txbUserName.Text.Trim();
            password = txbPwd.Text.Trim();
            connectionString = "Data Source=" + serverName + ";Initial Catalog=jingranCRM;User ID=" + userName + ";password=" + password;
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)//Broken)
                {
                    lblInfo.Text = "数据库连接测试成功!";
                    btnNext.Enabled = true;
                    button2.Enabled = true;
                }
            }
            catch
            {
                lblInfo.Text = "数据库连接测试失败!";
            }
            finally
            {
                CloseConnection(connection);
            }
        }     

        /// <summary>
        /// 关闭数据库
        /// </summary>
        /// <param name="connection"></param>
        private void CloseConnection(SqlConnection connection)
        {
            if (connection != null)
            {
                //关闭数据库
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
        
        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定退出吗?", "退出", MessageBoxButtons.OKCancel) == DialogResult.OK)
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        //下一步按钮
        private void btnNext_Click(object sender, EventArgs e)
        {         
            this.DialogResult = DialogResult.OK;
            this.Close();
            Application.Exit(); 
        }   

        private void txbPwd_TextChanged(object sender, EventArgs e)
        {
             if (txbPwd.Text == "")
                btnTest.Enabled =false;
            else
                btnTest.Enabled = true;
        }

        /// <summary>
        /// 更新连接字符串
        /// </summary>
        /// <param name="newName"> 连接字符串名称 </param>
        /// <param name="newConString"> 连接字符串内容 </param>
        /// <param name="newProviderName"> 数据提供程序名称 </param>
        private static void UpdateConnectionStringsConfig(string newName,string newConString,string newProviderName)
        {
            bool isModified = false;    // 记录该连接串是否已经存在
            // 如果要更改的连接串已经存在
            if (ConfigurationManager.ConnectionStrings["strConn"] != null)
            {
                isModified = true;
            }
            // 新建一个连接字符串实例
            ConnectionStringSettings mySettings = new ConnectionStringSettings(newName, newConString, newProviderName);
            // 打开可执行的配置文件*.exe.config
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // 如果连接串已存在，首先删除它
            if (isModified)
            {
                config.ConnectionStrings.ConnectionStrings.Remove("strConn");
            }
            // 将新的连接串添加到配置文件中.
            config.ConnectionStrings.ConnectionStrings.Add(mySettings);
            // 保存对配置文件所作的更改
            config.Save(ConfigurationSaveMode.Modified);
            // 强制重新载入配置文件的ConnectionStrings配置节
            ConfigurationManager.RefreshSection("ConnectionStrings");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            button1.Enabled = false;
            txbServer.ReadOnly = false;
            txbUserName.ReadOnly = false;
            txbPwd.ReadOnly = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            txbServer.ReadOnly = true;
            txbUserName.ReadOnly = true;
            txbPwd.ReadOnly = true;
            UpdateConnectionStringsConfig("strConn", connectionString, "System.Data.SqlClient");
            UpdateAppConfig("IP", serverName);
            UpdateAppConfig("userID", userName);
            UpdateAppConfig("password", password);
        }
        ///<summary>
        ///在＊.exe.config文件中appSettings配置节增加一对键、值对
        ///</summary>
        ///<param name="newKey"></param>
        ///<param name="newValue"></param>
        private static void UpdateAppConfig(string newKey, string newValue)
        {
            bool isModified = false;
            foreach (string key in ConfigurationManager.AppSettings)
            {
                if (key == newKey)
                {
                    isModified = true;
                }
            }
            // Open App.Config of executable
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            // You need to remove the old settings object before you can replace it
            if (isModified)
            {
                config.AppSettings.Settings.Remove(newKey);
            }
            // Add an Application Setting.
            config.AppSettings.Settings.Add(newKey, newValue);
            // Save the changes in App.config file.
            config.Save(ConfigurationSaveMode.Modified);
            // Force a reload of a changed section.
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
