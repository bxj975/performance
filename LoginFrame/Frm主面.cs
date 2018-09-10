using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;


namespace LoginFrame
{
    public partial class Frm主面 : Form
    {
        public Frm主面()
        {
            InitializeComponent();
            this.ControlBox = false; 
        }
        //现在时间
        private void timer1_Tick(object sender, EventArgs e)
        {
            tool_NowTime.Text = DateTime.Now.ToString();
        }

        private void toolStripLabel_5_Click(object sender, EventArgs e)
        {
            DialogResult button = MessageBox.Show("确定要退出系统?", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);

            if (button == DialogResult.Yes)
            {
                Application.ExitThread();
            }
        }

        private void ToolStripMenuItem_Custom_Click(object sender, EventArgs e)
        {
            FrmQueryCustom frm = new FrmQueryCustom();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_AddCustom_Click(object sender, EventArgs e)
        {
            FrmAddCustom frm = new FrmAddCustom(null, null, null);
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Submit_Click(object sender, EventArgs e)
        {
            FrmPerformance frm = new FrmPerformance();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Pay_Click(object sender, EventArgs e)
        {
            FrmPay frm = new FrmPay();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Adjust_Click(object sender, EventArgs e)
        {
            FrmAdjust frm = new FrmAdjust();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Settle_Click(object sender, EventArgs e)
        {
            FrmSet frm = new FrmSet();
            frm.ShowDialog();
        }

        private void toolStripMenuItem_Password_Click(object sender, EventArgs e)
        {
            Frm密码修改 frm = new Frm密码修改();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Grade_Click(object sender, EventArgs e)
        {
            Frm客户分类 frm = new Frm客户分类();
            frm.Message("CustomType", "C_Id", "C_Name");
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Type_Click(object sender, EventArgs e)
        {
            Frm客户分类 frm = new Frm客户分类();
            frm.Message("ProductType", "P_Id", "P_Name");
            frm.ShowDialog();
        }

        private void toolStripMenuItem_Exit_Click(object sender, EventArgs e)
        {
            toolStripLabel_5_Click(sender, e);
        }

        private void toolStripButton_1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Submit_Click(sender, e);
        }

        private void toolStripLabel_2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Pay_Click(sender, e);
        }

        private void toolStripButton_3_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_AddCustom_Click(sender, e);
        }

        private void toolStripMenuItem_Help_Click(object sender, EventArgs e)
        {
            new Common().ShowHelp();
        }

        private void toolStripMenuItem_About_Click(object sender, EventArgs e)
        {
            new Common().ShowAbout();
        }

        private void Frm主面_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void ToolStripMenuItem_PayQ_Click(object sender, EventArgs e)
        {
            FrmQueryPay frm = new FrmQueryPay();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_AdjustQ_Click(object sender, EventArgs e)
        {
            FrmQueryAdjust frm = new FrmQueryAdjust();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_SubmitQ_Click(object sender, EventArgs e)
        {
            FrmQuerySubmit frm = new FrmQuerySubmit();
            frm.ShowDialog();
        }

        private void ToolStripMenuItem_Check_Click(object sender, EventArgs e)
        {
            FrmQueryReward frm = new FrmQueryReward();
            frm.ShowDialog();
        }

        private void 操作员设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm管理员管理 frm = new Frm管理员管理();
            frm.ShowDialog();
        }

        private void 会员级别修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrade frm = new FrmGrade();
            frm.ShowDialog();
        }

        private void 级别调整查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQueryGrade frm = new FrmQueryGrade();
            frm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Custom_Click(sender, e);
        }

        private void Frm主面_Load(object sender, EventArgs e)
        {
            this.tool_UserName.Text = LoginRoler.U_Name;//用户名
        }

        private void toolStripLabel_4_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem_Check_Click(sender, e);
        }
    }
}
