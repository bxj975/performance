using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using BLL;
using Model;

namespace LoginFrame
{
    public delegate void GetName(string name);

    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        public event GetName getName;
        public string Pagetype = "";//操作类型
        public int Uid;
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 注册
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            string UserName = this.txt_username.Text.Trim();//姓名
            string UName = this.textBox_Name.Text.Trim();//姓名
            bool Sex = false;//性别
            if (this.radio_women.Checked)
            {
                Sex = true;
            }
            string Tel = this.textBox_Tel.Text;//出身日期
            string pwd = this.txt_pwd.Text.Trim();//密码1
            string pwd2 = this.txt_pwd2.Text.Trim();//密码2

            if (UserName == "")
            {
                MessageBox.Show("用户名输入不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (pwd == "")
            {
                MessageBox.Show("密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else if (pwd2 == "")
            {
                MessageBox.Show("确认密码不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            else if (pwd != pwd2)
            {
                MessageBox.Show("密码输入不相同,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.txt_pwd2.Text = "";
            }
            else
            {
                BU_UserInfo Bll = new BU_UserInfo();
                int a = Bll.ExistsName(UserName);
                if (a != 0)
                {
                    MessageBox.Show("用户名已经存在,请修改", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MU_UserInfo info = new MU_UserInfo();
                    //密码处理,经过加密
                    byte[] result = Encoding.Default.GetBytes(pwd2);//pwd2为输入密码的文本框
                    MD5 md5 = new MD5CryptoServiceProvider();
                    byte[] output = md5.ComputeHash(result);
                    info.U_PassWord = BitConverter.ToString(output).Replace("-", "");
                    info.U_Name = UserName;
                    info.U_RelName = UName;
                    info.U_Sex = Sex;
                    info.U_Telephone = Tel;
                    info.U_LoginTime = DateTime.Now;
                    if (Pagetype == "AddAdmin")
                    {
                        info.U_RoleType = 2;//管理员
                    }
                    else
                    {
                        info.U_RoleType = 1;//普通用户
                    }
                    int Result = Bll.Add(info);
                    if (Result == 0)
                    {
                        MessageBox.Show("注册失败,请重新注册", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("注册成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    getName(UserName);
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 传递参数
        /// </summary>
        /// <param name="sid">主键</param>
        /// <param name="type">添加 | 修改</param>
        public void Message(int UID,string type)
        {
            this.Uid = UID;
            this.Pagetype = type;
        }

        private void login_Load(object sender, EventArgs e)
        {
            if (Pagetype == "update")
            {
                DAL.DU_UserInfo du = new DAL.DU_UserInfo();
                MU_UserInfo use = du.GetModel(Uid);
                this.txt_username.Text=use.U_Name ;
                this.textBox_Name.Text = use.U_RelName; 
                if (use.U_Sex)

                    this.radio_women.Checked = true;
                else
                    this.radion_man.Checked = true; 
                this.textBox_Tel.Text = use.U_Telephone;
                this.label2.Visible = false;
                this.txt_pwd.Visible = false;
                this.label3.Visible = false;
                this.txt_pwd2.Visible = false;
                this.button1.Visible = false;
                this.txt_username.ReadOnly = true;
            }
            else
            this.button3.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string UserName = this.txt_username.Text.Trim();//姓名
            string UName = this.textBox_Name.Text.Trim();//姓名
            bool Sex = false;//性别
            if (this.radio_women.Checked)
            {
                Sex = true;
            }
            string Tel = this.textBox_Tel.Text;//出身日期
            if (UserName == "")
            {
                MessageBox.Show("用户名输入不能为空,请重新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                    MU_UserInfo info = new MU_UserInfo();
                    info.U_Id = Uid;
                    info.U_Name = UserName;
                    info.U_RelName = UName;
                    info.U_Sex = Sex;
                    info.U_Telephone = Tel;
                    
                    DAL.DU_UserInfo du=new DAL.DU_UserInfo();
                    if (du.Update(info))
                    {
                        MessageBox.Show("修改成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    this.Close();
                }
            }
    }
}
