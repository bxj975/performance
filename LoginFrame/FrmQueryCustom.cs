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
    public partial class FrmQueryCustom : Form
    {
        DataTable dsLog;
        public FrmQueryCustom()  //初始化组件
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
            if (this.Txt_Number.Text != "")
            {
                sqlstr += "  and U_Number like '%" + this.Txt_Number.Text + "%'";
            }
            if (this.Txt_Name.Text != "")
            {
                sqlstr += "  and U_Name like '%" + this.Txt_Name.Text + "%'";
            }
            if (this.Txt_Tel.Text != "")
            {
                sqlstr += "  and U_Tel like '%" + this.Txt_Tel.Text + "%'";
            }
            if (this.cb_Type.SelectedValue.ToString() != "0")
            {
                sqlstr += "  and U_Grade=" + this.cb_Type.SelectedValue.ToString();
            }
            if (this.Txt_Recommend.Text != "")
            {
                string number = this.Txt_Recommend.Text;
                int uid = DAL.performance.getC_ID(number);
                string UID=uid.ToString();
                sqlstr += "  and U_Introduce=" + UID;
            }
            if (this.txt_publishDate.Text != "")
            {
                sqlstr += "  and convert(char(11),U_LoginDate,20) ='" + this.txt_publishDate.Text + "'";
            }
            
            HWhere.Text = sqlstr;
            BindData("");

            string rows = this.textBox1.Text;
            DAL.dalBook.Update ("U_Row",rows,1);
        }
       
        public void BindData(string strClass)
        {
            string Number=this.textBox1.Text;
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
            dsLog = BLL.bllBook.GetBook(NowPage, PageSize, out AllPage, out DataCount, HWhere.Text);
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
                this.Btn_Del.Enabled = true;
            }
            else
            {
                this.Btn_Update.Enabled = false;
                this.Btn_Del.Enabled = false;
            }     
        }

        /*开始加载窗体后*/
        private void FrmQueryBook_Load(object sender, EventArgs e)
        {
            this.cb_Type.DataSource = DAL.dalCustom.getType("CustomType","C_Id","C_Name");
            this.cb_Type.DisplayMember = "C_Name";
            this.cb_Type.ValueMember = "C_Id";
            this.checkBox1.Checked = DAL.dalBook.getBool(1);
            this.textBox1.Text = DAL.dalBook.getString(1);
            this.HPageSize.Text = DAL.dalBook.getString(1);
            if(checkBox1.Checked)
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
                FrmAddCustom frmAddBook = new FrmAddCustom("update", barcode, this);
                frmAddBook.ShowDialog();
            }
        }

        private void Btn_Del_Click(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.BaseCollection)(dataGridView_Book.SelectedRows)).Count != 1)
            {
                MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (MessageBox.Show("删除吗?", "提示", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {

                    String barcode = this.dataGridView_Book.CurrentRow.Cells[0].Value.ToString();
                    if (BLL.bllBook.DelBook(barcode))
                        MessageBox.Show("删除成功!");
                    else
                        MessageBox.Show("删除失败!");

                    BindData("refresh");
                }
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FrmAddCustom frm = new FrmAddCustom(null, null, null);
            frm.ShowDialog();
            /*string path="c:/ee.xls";    //测试
            DAL.ExcelIO excel=new DAL.ExcelIO() ;
            DataTable dsLog = excel.ImportExcel(path);
            this.dataGridView_Book.DataSource = dsLog.DefaultView;*/
        }

       
        private void dataGridView_Book_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Update_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                DAL.dalBook.Update("U_Check", "1", 1);
            else
                DAL.dalBook.Update("U_Check", "0", 1);
        }
    }
 }
