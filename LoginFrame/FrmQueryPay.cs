using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginFrame
{
    public partial class FrmQueryPay : Form
    {
        DataTable dsLog;
        public FrmQueryPay()  //初始化组件
        {
            InitializeComponent();
        }
        private void dtp_publishDate_ValueChanged(object sender, EventArgs e)  //选择日期
        {
            this.txt_publishDate.Text = this.dtp_publishDate.Value.ToShortDateString();

        }
        private void txt_publishDate_DoubleClick(object sender, EventArgs e)  //双击日期框 清空
        {
            this.txt_publishDate.Text = "";
        }

        private void Btn_Query_Click(object sender, EventArgs e)  //搜索条件
        {
            string sqlstr = " where 1=1 ";
            if (this.Txt_No.Text != "")
            {
                sqlstr += "  and U_No like '%" + this.Txt_No.Text + "%'";
            }
            if (this.Txt_Number.Text != "")
            {
                sqlstr += "  and U_Custom like '%" + this.Txt_Number.Text + "%'";
            }
            if (this.txt_publishDate.Text != "")
            {
                sqlstr += "  and convert(char(11),U_LoginDate,20) ='" + this.txt_publishDate.Text + "'";
            }
            
            HWhere.Text = sqlstr;
            BindData("");

            string rows = this.textBox1.Text;
            DAL.dalBook.Update("U_Row", rows, 4);
        }
       
        public void BindData(string strClass)
        {
            string Number = this.textBox1.Text;
            int number;
            if (int.TryParse(Number, out number))
            {
                if (number < 40 && number > 10)
                {
                    this.HPageSize.Text = Number;
                }
            }
            int DataCount = 0;
            int NowPage = 1;
            int AllPage = 0;
            int PageSize = Convert.ToInt32(HPageSize.Text);
            switch (strClass) //下一页
            {
                case "next":
                    NowPage = Convert.ToInt32(HNowPage.Text) + 1;
                    break;
                case "up":
                    NowPage = Convert.ToInt32(HNowPage.Text) - 1;
                    break;
                case "end":
                    NowPage = Convert.ToInt32(HAllPage.Text);
                    break;
                case "refresh":
                    NowPage = Convert.ToInt32(HNowPage.Text);
                    break;
                default:
                    break;
            }
            dsLog = DAL.performance.GetPay(NowPage, PageSize, out AllPage, out DataCount, HWhere.Text);
            if (dsLog.Rows.Count == 0 || AllPage == 1)
            {
                LBEnd.Enabled = false;
                LBHome.Enabled = false;
                LBNext.Enabled = false;
                LBUp.Enabled = false;
            }
            else if (NowPage == 1)
            {
                LBHome.Enabled = false;
                LBUp.Enabled = false;
                LBNext.Enabled = true;
                LBEnd.Enabled = true;
            }
            else if (NowPage == AllPage)
            {
                LBHome.Enabled = true;
                LBUp.Enabled = true;
                LBNext.Enabled = false;
                LBEnd.Enabled = false;
            }
            else
            {
                LBEnd.Enabled = true;
                LBHome.Enabled = true;
                LBNext.Enabled = true;
                LBUp.Enabled = true;
            }
            this.dataGridViewSummary1.DataSource = dsLog.DefaultView;
            this.dataGridViewSummary1.SummaryColumns = new string[] { "金额" };
            this.dataGridViewSummary1.SummaryRowVisible = true;
            this.dataGridViewSummary1.SummaryRowForeColor = Color.White;
            PageMes.Text = string.Format("[每页{0}条 第{1}页／共{2}页   共{3}条]", PageSize, NowPage, AllPage, DataCount);
            HNowPage.Text = Convert.ToString(NowPage++);
            HAllPage.Text = AllPage.ToString();

        }

        /*开始加载窗体后*/
        private void FrmQueryPay_Load(object sender, EventArgs e)
        {
            this.checkBox1.Checked = DAL.dalBook.getBool(4);
            this.textBox1.Text = DAL.dalBook.getString(4);
            this.HPageSize.Text = DAL.dalBook.getString(4);
            if (checkBox1.Checked)
                BindData("");
        }

        private void LBHome_Click(object sender, EventArgs e)
        {
            BindData("");
        }

        private void LBUp_Click(object sender, EventArgs e)
        {
            BindData("up");
        }

        private void LBNext_Click(object sender, EventArgs e)
        {
            BindData("next");
        }

        private void LBEnd_Click(object sender, EventArgs e)
        {
            BindData("end");
        }
        
        string UName;
        public void FrmUName_getUName(string UserName)
        {
            UName = UserName;
            this.Txt_Number.Text = UserName;
        }
        
        private void button_Custom_Click(object sender, EventArgs e)
        {
            FrmUName frm = new FrmUName("");
            frm.getUName += new GetUName(FrmUName_getUName);
            frm.ShowDialog();
        }

        private void Txt_Number_TextChanged(object sender, EventArgs e)
        {
            this.textBox_Name.Text = DAL.performance.getName(UName);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                DAL.dalBook.Update("U_Check", "1", 4);
            else
                DAL.dalBook.Update("U_Check", "0", 4);
        }

    }
 }
