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
    public partial class FrmAdjust : Form
    {
        public FrmAdjust()
        {
            InitializeComponent();
        }
        private Adjust adjust = new Adjust();
       // public String barcode, state, Sqlname, typeSqlname,username;
     
        private void BindData()
        {    
            adjust.No = Int32.Parse(this.textBox_No.Text); //名称
            adjust.custom = Int32.Parse(this.textBox_Custom.Text); //联系人         
            adjust.amount = Int32.Parse(this.textBox_Amount.Text);
            if (this.radioButton_Reduce.Checked == true)
            {
                adjust.adjust = "减少";
            }
            else
            {
                adjust.adjust = "增加";
                //book.recommend = Int32.Parse(this.txt_Recommend.Text);
            }
            adjust.rank = this.comboBox_Type.Text; 
            adjust.note = this.textBox_Note.Text;  //
            adjust.clerk = LoginRoler.U_Id;
            adjust.publishDate = DateTime.Now;
        }
      
        private void FrmAdjust_Load(object sender, EventArgs e)
        {
            DAL.dalCustom dal=new DAL.dalCustom();
            this.textBox_No.Text = dal.notenum().ToString() ;
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
              if (this.textBox_Amount.Text == "")
            {
                MessageBox.Show("金额输入不能为空!");
                return;
            }
              if (this.comboBox_Type.Text == "")
            {
                MessageBox.Show("调整类型不能为空!");
                return;
            }
            
            BindData();
            if (DAL.performance.AddAdjust(adjust) && DAL.performance.AddAdjust2(adjust))
                MessageBox.Show("调整成功!");
            else
                MessageBox.Show("调整失败!");

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
            //this.textBox_Name.Text = DAL.performance.getName(UName);
            int UID = Int32.Parse(UName);
            this.textBox_Name.Text = DAL.performance.getName(UName) + "-" + DAL.performance.getString("U_Name", UID);
        }
    }
}
