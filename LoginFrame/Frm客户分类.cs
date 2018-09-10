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
    public partial class Frm客户分类 : Form
    {
        public string Sqlname, T_Id, T_Name, barcode;
        public Frm客户分类()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 传递参数
        /// </summary>
        /// <param name="Sqlname">数据库名</param>
        public void Message(string Sqlname, string T_Id, string T_Name)
        {
            this.Sqlname = Sqlname;
            this.T_Id = T_Id;
            this.T_Name = T_Name ;
        }

        //退出
        private void toolStripLabel退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //人员新增
        private void toolStripLabel添加_Click(object sender, EventArgs e)
        {
            if (Sqlname == "CustomType")
            {
                FrmCustom frm = new FrmCustom(null, null, null);
                frm.ShowDialog();
            }
            else
            {
                FrmProduct frm = new FrmProduct(null, null, null);
                frm.ShowDialog();
            }
        }

        //修改
        private void toolStripLabel修改_Click(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.BaseCollection)(dataGridView1.SelectedRows)).Count > 1)
            {
                MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
               
                 barcode = dataGridView1.CurrentRow.Cells[0].Value.ToString ();

                 if (Sqlname == "CustomType")
                 {
                     FrmCustom frm = new FrmCustom("update", barcode, null);
                    frm.ShowDialog();
                 }
                else
                 {
                     FrmProduct frm = new FrmProduct("update", barcode, null);
                     frm.ShowDialog();
                 }
                // frm.getName += new GetState(login_getName);        
            }
        }

        /// <summary>
        /// 绑定数据源
        /// </summary>
        public void dataBind()
        {
            DataSet ds = DAL.dalCustom.c_DataSet(Sqlname);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            toolStripStatusLabel2.Text = dataGridView1.Rows.Count.ToString();
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                toolStripLabel修改.Enabled = true;
                toolStripLabel删除.Enabled = true;
            }
            else
            {
                toolStripLabel修改.Enabled = false;
                toolStripLabel删除.Enabled = false;
            }
        }

        //删除
        private void toolStripLabel删除_Click(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.BaseCollection)(dataGridView1.SelectedRows)).Count > 1)
            {
                MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                int UserID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);

                if (DAL.dalCustom.deleteTypeName(UserID, Sqlname, T_Id) > 0)
                {
                    MessageBox.Show("删除成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    Frm客户分类_Load(sender, e);
                }
                else
                    MessageBox.Show("删除失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
        //显示全部
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            dataBind();
        }

        //窗体加载
        private void Frm客户分类_Load(object sender, EventArgs e)
        {
            dataBind();
            this.dataGridView1.ReadOnly = true;

            if (Sqlname == "CustomType")
                this.Text = "会员级别";
            else
                this.Text = "产品分类";
        }

    }
}
