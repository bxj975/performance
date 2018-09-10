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
    public partial class FrmQueryWorkR : Form
    {
        public FrmQueryWorkR()  //初始化组件
        {
            InitializeComponent();
        }
        public String barcode;
 
        public void BindData(string strClass)
        {
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
            DataTable dsLog = DAL.dalCustom .Getwork(NowPage, PageSize, out AllPage, out DataCount, HWhere.Text);
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
            this.dataGridView_Book.DataSource = dsLog.DefaultView; 
            PageMes.Text = string.Format("[每页{0}条 第{1}页／共{2}页   共{3}条]", PageSize, NowPage, AllPage, DataCount);
            HNowPage.Text = Convert.ToString(NowPage++);
            HAllPage.Text = AllPage.ToString();

            if (dsLog.Rows.Count > 0)
            {
                this.Btn_Update.Enabled = true;
               // this.Btn_Del.Enabled = true;
            }
            else
            {
                this.Btn_Update.Enabled = false;
                //this.Btn_Del.Enabled = false;
            }
        }

        /*开始加载窗体后*/
        private void FrmQueryWorkR_Load(object sender, EventArgs e)
        {
            string sqlstr = " where 1=1 ";
            sqlstr += "  and U_RemindTime> GETDATE() and U_RemindTime<dateadd(day,2,(Select CONVERT(varchar(100), GETDATE(), 23)))";
            string Position=LoginRoler.U_Position;
            if (Position != "") 
            {
                switch (Position)
                {
                    case "总经理":
                        break;
                    case "部门经理":
                        sqlstr += "  and U_ClerkType in (select U_Id from U_UserInfo where U_department=" + LoginRoler.U_DpaType;
                        break;
                    default:
                        sqlstr += "  and U_ClerkType =" + LoginRoler.U_Id;
                        break;
                }
            }
            else 
            {
                sqlstr += "  and U_ClerkType =9999";
            }
            HWhere.Text = sqlstr;
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

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.BaseCollection)(dataGridView_Book.SelectedRows)).Count != 1)
            {
                MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                String barcode = this.dataGridView_Book.CurrentRow.Cells[0].Value.ToString();
                //FrmWork frm = new FrmWork("update",null,barcode);
                //frm.ShowDialog();
            }
        }
       
    }
}
