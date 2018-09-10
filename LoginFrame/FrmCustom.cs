using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace LoginFrame
{
    public partial class FrmCustom : Form
    {
        public FrmCustom(string state, String barcode, Frm客户分类 frmQueryBook)
        {
            InitializeComponent();
            this.state = state;
            this.barcode = barcode;
            this.frmQueryBook = frmQueryBook;
        }
        private string state, barcode;
        private BookType type = new BookType();
        private Frm客户分类 frmQueryBook;

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (this.Txt_Number.Text == "")
            {
                MessageBox.Show("编码输入不能为空!");
                return;
            }
            if (this.Txt_Name.Text == "")
            {
                MessageBox.Show("名称输入不能为空!");
                return;
            }

            BindData();
            if (DAL.dalBook.AddRank(type))
                MessageBox.Show("添加成功!");
            else
                MessageBox.Show("添加失败!");

            this.Close();
        }

        private void BindData()
        {
            type.Number = this.Txt_Number.Text; //名称
            type.Name = this.Txt_Name.Text; //联系人         
            type.amount = double.Parse(this.Txt_Amount.Text);   //SelectedValue.ToString(); //地区
            type.rateA = double.Parse(this.Txt_RateA.Text);
             
        }
        private void Btn_Confirm_Click(object sender, EventArgs e)
        {
            BindData();
            this.Btn_Update.Visible = true;
            this.Btn_Confirm.Visible = false;
            if (DAL.dalBook.EditRank(type))
                MessageBox.Show("更新成功!");
            else
                MessageBox.Show("更新失败!");
            //FrmQueryBook frmQueryBook = (FrmQueryBook)this.Parent;
            //frmQueryBook.BindData("refresh");
            this.Close();
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCustom_Load(object sender, EventArgs e)
        {
            if (state != "update")
            {
                this.Btn_Confirm.Visible = false;
                this.Btn_Update.Visible = false;
            }
            else
            {
                this.Txt_Number.ReadOnly = true;
                this.Txt_Name.ReadOnly = true;
                this.Txt_Amount.ReadOnly = true;
                this.Txt_RateA.ReadOnly = true;
                this.Btn_Confirm.Visible = false;
                this.Btn_Add.Visible = false;

                type = DAL.dalBook.getSomeRank(barcode);
                this.Txt_Id.Text = type.Id.ToString() ;
                this.Txt_Number.Text = type.Number;
                this.Txt_Name.Text = type.Name;
                this.Txt_Amount.Text = type.amount.ToString();
                this.Txt_RateA.Text = type.rateA.ToString(); 
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            this.Txt_Number.ReadOnly = false;
            this.Txt_Name.ReadOnly = false;
            this.Txt_Amount.ReadOnly = false;
            this.Txt_RateA.ReadOnly = false;

            this.Btn_Update.Visible = false;
            this.Btn_Confirm.Visible = true;
        }
    }
}
