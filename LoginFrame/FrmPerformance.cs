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
    public partial class FrmPerformance : Form
    {
        public FrmPerformance()
        {
            InitializeComponent();
            this.ControlBox = false; 
        }
        private Adjust adjust = new Adjust();
        bool step1 = false, step2 = false, step3 = false, step4 = false, step5 = false, step6 = false;
        
        private void BindData()
        {
            adjust.No = Int32.Parse(this.textBox_No.Text); //名称
            adjust.custom = Int32.Parse(this.textBox_Custom.Text); //联系人         
            adjust.custom2 = this.textBox_Name2.Text; //联系人  
            if (textBox_Custom2.Text == "")
                adjust.custom1 = 0;
            else
                adjust.custom1 = Int32.Parse(textBox_Custom2.Text);
            adjust.amount = Decimal.Parse(this.textBox_Amount.Text);
            adjust.product = Int32.Parse(this.comboBox_Product.SelectedValue.ToString());
            adjust.note = this.textBox_Note.Text;  //
            adjust.clerk = LoginRoler.U_Id;
            adjust.publishDate = DateTime.Now;
        }

        private void FrmPerformance_Load(object sender, EventArgs e)
        {
            DAL.dalCustom dal=new DAL.dalCustom();
            this.textBox_No.Text = dal.notenum().ToString();

            this.comboBox_Product.DataSource = DAL.dalCustom.getType("ProductType", "P_Id", "P_Name");
            this.comboBox_Product.DisplayMember = "P_Name";
            this.comboBox_Product.ValueMember = "P_Id";

        }

        private void buttona_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Confirm_Click(object sender, EventArgs e)
        {
            if (this.textBox_Name.Text == "")
            {
                MessageBox.Show("会员选择不能为空!");
                return;
            }
            if (this.textBox_Amount.Text == "")
            {
                MessageBox.Show("数量输入不能为空!");
                return;
            }
            if (this.comboBox_Product.Text == "请选择")
            {
                MessageBox.Show("产品选择不能为空!");
                return;
            }            
            BindData();
            if (DAL.performance.AddPerformance(adjust))
                MessageBox.Show("添加成功!");
            else
                MessageBox.Show("添加失败!");

            DAL.performance.AddPerfRank(adjust);
            
            step1 = true;
            this.buttona_Cancel.Visible = false;    
            this.button_Confirm.Visible = false;
            this.button4.Visible = true; 
        }
       
        private void button5_Click(object sender, EventArgs e)
        {
            if (step1 == true)
            {
                BindData();
                int Result = DAL.performance.AddPerformance2(adjust);
                switch (Result)
                {
                    case 0: MessageBox.Show("未有业绩核算生成!");
                        break;
                    case 1: MessageBox.Show("一人业绩核算生成!");
                        break;
                    case 2: MessageBox.Show("两人业绩核算生成!");
                        break;
                    default: MessageBox.Show("操作未执行!");
                        break;
                }
                step2 = true;
                this.button5.Visible = false;
            }
            else
            {
                MessageBox.Show("请按步骤操作!");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (step2 == true)
            {
                BindData();
                int Result = DAL.performance.AddPerformance3(adjust);
                string SResult=Result.ToString();
                MessageBox.Show(SResult+"人团队业绩生成!");
                step3 = true;
                this.button2.Visible = false;
            }
            else
            {
                MessageBox.Show("请按步骤操作!");
                return;
            }         
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (step3 == true)
            {
                BindData();
                int Result = DAL.performance.AddPerformance4(adjust);
                if (Result == 0)
                    MessageBox.Show("加油！");
                else
                {
                    string SResult = DAL.performance.getString("U_Number", Result);
                    MessageBox.Show(SResult + "领取团队奖");
                }
                step4 = true;
                this.button1.Visible = false;
            }
            else
            {
                MessageBox.Show("请按步骤操作!");
                return;
            }         
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (step1 == true && step2 == true && step3 == true && step4 == true && step5 == true && step6 == true)
            this.Close();
            else
            {
                MessageBox.Show("未操作完毕!");
                return;
            }
        }

        private void button_Person_Click(object sender, EventArgs e)
        {
            if (step4 == true)
            {
                BindData();
                int Result = DAL.performance.AddSettle2(adjust);
                string Sresult = Result.ToString();
                MessageBox.Show(Sresult + "人获得管理津贴!");

                step5 = true;
                this.button_Person.Visible = false;
            }
            else
            {
                MessageBox.Show("请按步骤操作!");
                return;
            }
        }

        private void button_Team_Click(object sender, EventArgs e)
        {

            if (step5 == true)
            {
                BindData();
                int Result = DAL.performance.AddSettle3(adjust);
                string Sresult = Result.ToString();
                MessageBox.Show(Sresult + "人完成代理商核算操作!");

                step6 = true;
                this.button_Team.Visible = false;
            }
            else
            {
                MessageBox.Show("请按步骤操作!");
                return;
            }
        }


        string UName, UName2;
        public void FrmUName_getUName(string UserName)
        {
            UName = UserName;
            this.textBox_Custom.Text = UserName;
        }

        public void FrmUName_getUName2(string UserName)
        {
            UName2 = UserName;
            this.textBox_Custom2.Text = UserName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmUName frm = new FrmUName("");
            frm.getUName += new GetUName(FrmUName_getUName);
            frm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmUName frm = new FrmUName("and U_Grade=14 or U_Grade=15 ");
            frm.getUName += new GetUName(FrmUName_getUName2);
            frm.ShowDialog();
        }

        private void textBox_Custom_TextChanged(object sender, EventArgs e)
        {
            int UID = Int32.Parse(UName);
            this.textBox_Name.Text = DAL.performance.getName(UName) + "-" + DAL.performance.getString("U_Name", UID);
            //this.textBox_Name.Text = DAL.performance.getName(UName);
        }

        private void textBox_Custom2_TextChanged(object sender, EventArgs e)
        {
            int UID2 = Int32.Parse(UName2);
            this.textBox_Name2.Text = DAL.performance.getName(UName2) + "-" + DAL.performance.getString("U_Name", UID2);
            //this.textBox_Name2.Text = DAL.performance.getName(UName2);
        }

    }
}
