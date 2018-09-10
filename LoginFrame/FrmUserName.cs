using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;
using BLL;
using DAL;

using System.Security;
using System.Security.Cryptography;
using System.Xml;

namespace LoginFrame
{
    public delegate void GetUserName(string name); 
    public partial class FrmUserName : Form
    {
        public string sqlname;
        public FrmUserName(string SqlName)
        {
            InitializeComponent();
            this.sqlname = SqlName;
        }
        public event GetUserName getUserName ;
         
        private void FrmUserName_Load(object sender, EventArgs e)
        {
            DataTable dsLog = dalCustom.getUserName(sqlname,"").Tables[0];
            this.dataGridView1.DataSource = dsLog.DefaultView;
            
             for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                this.dataGridView1.Rows[i].Cells[0].Value = false;
             }
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            int IdNum=0,Num=0;
            string UserName="";
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if ((bool)this.dataGridView1.Rows[i].Cells[0].Value)
                {
                    IdNum += 1;
                }
                label1.Text = IdNum.ToString(); 
            }

            for (int j = 0; j < dataGridView1.RowCount; j++)
            {
                if ((bool)this.dataGridView1.Rows[j].Cells[0].Value)
                {
                    Num += 1;
                    if (Num != IdNum)
                        UserName += dataGridView1.Rows[j].Cells[1].Value.ToString() + ",";
                    else
                        UserName += dataGridView1.Rows[j].Cells[1].Value.ToString();
                }
            }
            label1.Text = UserName;
            getUserName(UserName);
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBox1.Checked)
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    this.dataGridView1.Rows[i].Cells[0].Value = false;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            if (userName == "")
            {
                FrmUserName_Load(sender, e);
            }
            else
            {
                string where = "and  U_Name like '%" + userName + "%' ";
                DataTable dsLog = dalCustom.getUserName(sqlname,where).Tables[0];
                this.dataGridView1.DataSource = dsLog.DefaultView;
            }
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = null;
        }
    }
}
