using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Model;

namespace LoginFrame
{
    public partial class FrmSettle : Form
    {
        public FrmSettle(FrmSet frmset)
        {
            InitializeComponent();
            this.frmset = frmset;
            this.ControlBox = false; 
        }
        bool step = false;
        private FrmSet frmset;
        private Adjust adjust = new Adjust();
        private void BindData()
        {
            adjust.note = this.comboBox_Month.Text;  //
            adjust.clerk = LoginRoler.U_Id;
            adjust.publishDate = DateTime.Now; 
        }

        private void FrmSettle_Load(object sender, EventArgs e)
        {

            StringBuilder str = new StringBuilder();
            str.Append("请在月末最后一天或月初第一天执行月结操作/n");
            str.Append("该操作将会修改会员级别，从而影响业绩计算系数/n");
            str.Append("请谨慎操作！");
            //this.label1.Text = str.ToString();
            this.label1.Text = "请在月末最后一天或月初第一天执行月结操作,该操作将会修改会员级别，从而影响业绩计算系数,请谨慎操作！";
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (this.comboBox_Month.Text == "")
            {
                MessageBox.Show("月份选择不能为空!");
                return;
            }
            BindData();
            if (DAL.performance.AddSettle(adjust))
                MessageBox.Show("添加成功!");
            else
                MessageBox.Show("添加失败!");
            frmset.dataBind();

            string Result = DAL.performance.AddSettle4();
            MessageBox.Show(Result);
            step = true;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (step)
                DAL.performance.UpdateReset();

        }
    }
}
