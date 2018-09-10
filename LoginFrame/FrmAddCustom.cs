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
    public partial class FrmAddCustom : Form
    {
        public FrmAddCustom(string state,String barcode,FrmQueryCustom frmQueryBook)
        {
            InitializeComponent();
            this.state = state;
            this.barcode = barcode;
            this.frmQueryBook = frmQueryBook;
        }
        private string state, barcode;
        private Book book = new Book();
        private FrmQueryCustom frmQueryBook;   
      
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (this.txt_Name.Text == "")
            {
                MessageBox.Show("名称输入不能为空!");
                return;
            }
            if (this.txt_Number.Text == "")
            {
                MessageBox.Show("编号输入不能为空!");
                return;
            }
            string number = this.txt_Number.Text;
            DAL.dalCustom dal=new DAL.dalCustom();
            int result = dal.ExistsName(number);
            if (result != 0)
            {
                MessageBox.Show("此编号已被使用!请更换.");
                return;
            }
            BindDataA();
            if (DAL.dalBook.AddBook(book))
            {
                MessageBox.Show("添加成功!");
                int Uid = 0;
                string UID = this.txt_Recommend.Text;
                if (UID == "")
                {
                    Uid = 0;
                }
                else Uid = Int32.Parse(UID);
                string Name = this.txt_Name.Text;
                int result2= DAL.performance.addCust(Uid, Name);
                string result3 = result2.ToString();
                MessageBox.Show(result3 + "人添加!");
            }
            else
                MessageBox.Show("添加失败!");
           
            this.Close(); 
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            this.txt_Name.ReadOnly = false;
            this.comboBoxSex.Enabled = true;
            this.txt_Note.ReadOnly = false;
            this.txt_Tel.ReadOnly = false;
            this.Btn_Update.Visible = false;
            this.Btn_Confirm.Visible = true;
            this.textBox_Bank.ReadOnly = false;
            this.textBox_BankN.ReadOnly = false;
            this.textBox_BankName.ReadOnly = false;
        }

        private void BindDataA()
        {
            book.bookName = this.txt_Number.Text; //名称
            book.Name = this.txt_Name.Text; //联系人         
            book.area = this.comboBoxSex.Text;    //SelectedValue.ToString(); //地区
            book.tele = this.txt_Tel.Text;
            if (this.txt_Recommend.Text == "")
            {
                book.recommend = 0;
            }
            else
            {
                book.recommend = Int32.Parse(this.txt_Recommend.Text);
            }
            book.note = this.txt_Note.Text;  //
            book.clerk = LoginRoler.U_Id;
            book.publishDate = DateTime.Now;
            book.bank = this.textBox_Bank.Text;  //
            book.bankn = this.textBox_BankN.Text;  //
            book.bankname = this.textBox_BankName.Text;  //
            //book.qq = double.Parse(this.txt_Count1.Text);  //  
            //book.weixin = double.Parse(this.txt_Count2.Text);  //
            //book.email = double.Parse(this.txt_Pay1.Text);  //
            //book.www = double.Parse(this.txt_Pay2.Text);  //
            //book.team = this.txt_Team1.Text;
            //book.move = double.Parse(this.txt_Team2.Text);
            //book.address = this.txt_Person.Text;//
            //book.publishDate = this.dtp_Date.Value;           
        }
        private void BindDataB()
        {

            book.barcode = Int32.Parse(barcode);
            book.Name = this.txt_Name.Text; //联系人         
            book.area = this.comboBoxSex.Text ; //地区
            book.tele = this.txt_Tel.Text;
            book.note = this.txt_Note.Text;
            book.bank = this.textBox_Bank.Text;  //
            book.bankn = this.textBox_BankN.Text;  //
            book.bankname = this.textBox_BankName.Text;
           
            //if (this.dtp_publishDate == null)
            //{
            //   this.dtp_publishDate.Value  = DateTime.Now ;
            //}
           
            /*try
            {
                book.price = Convert.ToSingle(this.txt_price.Text);  //图书价格
            }
            catch
            {
                MessageBox.Show("图书价格请输入正确的格式!");
                this.txt_price.SelectAll();
                this.txt_price.Focus();
                return;
            }
            try
            {
                book.count = Convert.ToInt32(this.txt_count.Text);  //图书库存
            }
            catch
            {
                MessageBox.Show("图书库存请输入正确的格式!");
                this.txt_count.SelectAll();
                this.txt_count.Focus();
                return;
            }*/
        }

        private void FrmAddBook_Load(object sender, EventArgs e)
        {
            if (state != "update")
            {             
                //FileStream fs = new FileStream("pic/NoImage.jpg", FileMode.Open, FileAccess.Read);
                //BinaryReader bw = new BinaryReader(fs);
                //book.bookPhoto = bw.ReadBytes((int)fs.Length);
                this.Btn_Confirm.Visible = false;
                this.Btn_Update.Visible = false;
            }
            else 
            {
                this.Btn_Clerk.Enabled = false;
                this.txt_Number.ReadOnly = true;
                this.txt_Name.ReadOnly = true;
                this.txt_Tel.ReadOnly = true;
                this.txt_Note.ReadOnly = true;
                this.comboBoxSex.Enabled = false;             
                this.dtp_Date.Enabled = false;        
                this.Btn_Add.Visible = false;
                this.Btn_Confirm.Visible = false;
                this.textBox_Bank.ReadOnly = true;
                this.textBox_BankN.ReadOnly = true;
                this.textBox_BankName.ReadOnly = true;
                book = BLL.bllBook.getSomeBook(barcode);
                int Uid=Int32.Parse(barcode);
                int U_id = DAL.performance.getInt("U_Introduce", Uid);
                if (U_id != 0)
                    this.Txt_Clerk.Text = DAL.performance.getString("U_Number", U_id);
                this.txt_Id.Text = book.barcode.ToString();
                int grade = book.bookType;
                string rank = DAL.performance.getNameC(grade);
                this.txt_Grade.Text = rank;
                this.txt_Number.Text = book.bookName;
                this.txt_Name.Text = book.Name;              
                this.comboBoxSex.Text = book.area.ToString();
                this.txt_Count1.Text = book.qq.ToString(); 
                this.txt_Count2.Text = book.weixin.ToString();
                this.txt_Pay1.Text = book.email.ToString();
                this.txt_Pay2.Text = book.www.ToString();
                this.txt_Team2.Text = book.move.ToString(); 
                this.txt_Note.Text = book.note;
                this.txt_Tel.Text = book.tele;
                this.txt_Person.Text = book.address; ;
                this.dtp_Date.Value = book.publishDate;
                bool team = book.team;
                if (team)
                {
                    this.txt_Team1.Text = "已领取";
                }
                else
                {
                    this.txt_Team1.Text = "未获得";
                }
                this.textBox_Bank.Text = book.bank;
                this.textBox_BankN.Text = book.bankn;
                this.textBox_BankName.Text = book.bankname;
             }         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string UName;
        public void FrmUName_getUName(string UserName)
        {
            UName = UserName;
            this.txt_Recommend.Text = UserName;
        }

        private void Btn_Clerk_Click(object sender, EventArgs e)
        {
            FrmUName frm = new FrmUName("");
            frm.getUName += new GetUName(FrmUName_getUName);
            frm.ShowDialog();
        }

        private void txt_Recommend_TextChanged(object sender, EventArgs e)
        {
            int UID = Int32.Parse(UName);
            this.Txt_Clerk.Text = DAL.performance.getName(UName) + "-" + DAL.performance.getString("U_Name", UID);
        }

        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            BindDataB();
            if (BLL.bllBook.EditBook(book))
                MessageBox.Show("更新成功!");
            else
                MessageBox.Show("更新失败!");
            //FrmQueryBook frmQueryBook = (FrmQueryBook)this.Parent;
            frmQueryBook.BindData("refresh");        
            this.Close();
        }
    }
}
