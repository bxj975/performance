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
    public partial class FrmSet : Form
    {
        public FrmSet()
        {
            InitializeComponent();
        }
        
        //窗体加载
        private void FrmSet_Load(object sender, EventArgs e)
        {
            dataBind();
            this.dataGridView1.ReadOnly = true;
        }
      

        /// <summary>
        /// 绑定数据源
        /// </summary>
        public void dataBind()
        {
            DataSet ds = DAL.performance.S_DataSet();
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            toolStripStatusLabel2.Text = dataGridView1.Rows.Count.ToString();
        }

        //显示全部
        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            dataBind();
        }

        //新增
        private void toolStripLabel添加_Click(object sender, EventArgs e)
        {
            FrmSettle frm = new FrmSettle(this);
            frm.ShowDialog();
        }

        //退出
        private void toolStripLabel退出_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            FrmQueryGrade frm = new FrmQueryGrade();
            frm.ShowDialog();
        }

    }
}
