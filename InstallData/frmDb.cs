using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Security.AccessControl;
using System.Windows.Forms;

namespace InstallData
{
    public partial class frmDb : Form
    {
        private string serverName,userName,password,path2;
        private bool IsConn1=false ,IsConn2=false;
        public frmDb(string path)
        {
            InitializeComponent();
            this.path2 = path;
        }   
        private void frmDb_Load(object sender, EventArgs e)
        {
            btnTest.Enabled = false; ;
            button1.Enabled = false;
            btnNext.Enabled = false;
            this.CenterToParent();//窗体在父窗体中居中
            this.txbPwd.Focus();
        }
        private void btnTest_Click(object sender, EventArgs e)
        {
            serverName = txbServer.Text.Trim();
            userName = txbUserName.Text.Trim();
            password = txbPwd.Text.Trim();
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=master;User ID=" + userName + ";password=" + password;
            IsConn1 = TestConnection(connectionString);
            if (IsConn1)
            {
                this.lblInfo.Text = "数据库连接测试成功!";
                this.btnNext.Enabled = true;
                this.button1.Enabled = true;
            }
            else
                lblInfo.Text = "数据库连接测试失败!";

        }
            
         private bool TestConnection(string conn)
        {
            SqlConnection connection = new SqlConnection(conn);
            bool connect;
             try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)//Broken)  
                {
                    connect = true;
                    return connect;
                }
                else
                {
                    connect = false;
                    return connect;
                }
            }
            catch
            {
                connect = false;
                return connect;
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
        /// <summary>
        /// 附加数据库方法
        /// </summary>
        /// <param name="strSql">连接数据库字符串，连接master系统数据库</param>
        /// <param name="DataName">数据库名字</param>
        /// <param name="strMdf">数据库文件MDF的路径</param>
        /// <param name="strLdf">数据库文件LDF的路径</param>
        /// <param name="path">安装目录</param>
        private void CreateDataBase(string strSql, string DataName, string strMdf, string strLdf, string path)
        {
            if (lblInfo.Text == "数据库连接测试成功!")
            {
                SqlConnection myConn = new SqlConnection(strSql);
                String str = null;
                try
                {
                    str = " EXEC sp_attach_db @dbname='" + DataName + "',@filename1='" + strMdf + "',@filename2='" + strLdf + "'";
                    SqlCommand myCommand = new SqlCommand(str, myConn);
                    myConn.Open();
                    myCommand.ExecuteNonQuery();
                    MessageBox.Show("数据库安装成功！点击确定继续");//需Using System.Windows.Forms
                }
                catch (Exception e)
                {
                    throw e;
                    //MessageBox.Show("数据库安装失败！" + e.Message + "\n\n" + "您可以手动附加数据");
                    //System.Diagnostics.Process.Start(path);//打开安装目录
                }
                finally
                {
                    myConn.Close();
                }
            }

            else
                MessageBox.Show("数据库连接测试末成功");
        }

        private static void SetFullControl(string path)
        {
            FileInfo info = new FileInfo(path);
            FileSecurity fs = info.GetAccessControl();
            fs.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
            info.SetAccessControl(fs);
        }

            
        //附加数据库
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=" + serverName + ";Initial Catalog=jingranCRM;User ID=" + userName + ";password=" + password;
            IsConn2 = TestConnection(connectionString);
            if (IsConn2)
                MessageBox.Show("数据库已安装");    
            else
            {
                string strSql = "Server=" + serverName + ";Database=master;User Id=" + userName + ";Password=" + password + ";";//连接数据库字符
                string DataName = "jingranCRM";//数据库名
                //if (dbName != null)
                //{
                //DataName = dbName;
                //}
                string strMdf = path2 + DataName + ".mdf";//MDF文件路径，这里需注意文件名要与刚添加的数据库文件名一样！
                string strLdf = path2 + DataName + ".ldf";//LDF文件路径
                SetFullControl(strMdf);
                SetFullControl(strLdf);
                this.CreateDataBase(strSql, DataName, strMdf, strLdf, path2);//开始创建数据库
            }       
        }   

        //取消按钮
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }
        //下一步按钮
        private void btnNext_Click(object sender, EventArgs e)
        {         
            this.DialogResult = DialogResult.OK;
            this.Close();
        }   

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radioButton1.Checked == true)
            {
                btnNext.Enabled = true;
                button1.Enabled = false;
                button2.Enabled = false;
                txbServer.ReadOnly = true;
                txbUserName.ReadOnly = true;
                txbPwd.ReadOnly = true;
            }
            else
            {
                btnNext.Enabled = false;
                txbPwd.ReadOnly = false;
                button1.Enabled = true ;
                button2.Enabled = true;
            }
        }

        private void txbPwd_TextChanged(object sender, EventArgs e)
        {
             if (txbPwd.Text == "")
                btnTest.Enabled =false;
            else
                btnTest.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txbServer.ReadOnly = false;
            txbUserName.ReadOnly = false;
        }
    }
}
