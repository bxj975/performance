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
    public partial class FrmGrade : Form
    {
        public FrmGrade()
        {
            InitializeComponent();
        }
        private Adjust adjust = new Adjust();
        private void BindData()
        {    
            adjust.No = Int32.Parse(this.textBox_No.Text); //名称
            adjust.custom = Int32.Parse(this.textBox_Custom.Text); //联系人         
            adjust.product = Int32.Parse(this.comboBox_Product.SelectedValue.ToString());
            adjust.note = this.textBox_Note.Text;  //
            adjust.clerk = LoginRoler.U_Id;
            adjust.publishDate = DateTime.Now;
        }

        private void FrmGrade_Load(object sender, EventArgs e)
        {
            DAL.dalCustom dal=new DAL.dalCustom();
            this.textBox_No.Text = dal.notenum().ToString();

            this.comboBox_Product.DataSource = DAL.dalCustom.getType("CustomType", "C_Id", "C_Name");
            this.comboBox_Product.DisplayMember = "C_Name";
            this.comboBox_Product.ValueMember = "C_Id";
        }

        private void buttona_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
              if (this.textBox_Name.Text == "")
            {
                MessageBox.Show("会员输入不能为空!");
                return;
            }

              if (this.comboBox_Product.Text == "请选择")
              {
                  MessageBox.Show("级别选择不能为空!");
                  return;
              }

            BindData();
            if (DAL.performance.AddGrade(adjust) && DAL.performance.AddGrade2(adjust))
                MessageBox.Show("修改成功!");
            else
                MessageBox.Show("修改失败!");
            this.Close();
        }
        string UName;
        public void FrmUName_getUName(string UserName)
        {
            UName = UserName;
            this.textBox_Custom.Text = UserName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUName frm = new FrmUName("");
            frm.getUName += new GetUName(FrmUName_getUName);
            frm.ShowDialog();
        }

        private void textBox_Custom_TextChanged(object sender, EventArgs e)
        {
            int UID = Int32.Parse(UName);
            this.textBox_Name.Text = DAL.performance.getName(UName) + "-" + DAL.performance.getString("U_Name", UID);
            //this.textBox_Name.Text = DAL.performance.getName(UName);
            this.textBox_Amount.Text = DAL.performance.getGrade(UName);
        }
    }
}
