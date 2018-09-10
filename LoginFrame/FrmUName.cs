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
    public delegate void GetUName(string name); 
    public partial class FrmUName : Form
    {
        public string Where;
        public FrmUName(string where)
        {
            InitializeComponent();
            this.Where = where;
        }
        public event GetUName getUName ;

        private void FrmUName_Load(object sender, EventArgs e)
        {
            DataTable dsLog = dalCustom.getUserName(Where, "").Tables[0];
            this.dataGridView1.DataSource = dsLog.DefaultView;
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            string UserName = "";
            if (((System.Windows.Forms.BaseCollection)(dataGridView1.SelectedRows)).Count != 1)
            {
                MessageBox.Show("请选择一条数据", "提示", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                UserName = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //FrmWork frm = new FrmWork("Add", barcode, null);
                //frm.ShowDialog();
            }
            getUName(UserName);         
            this.Close();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {           
            this.Close();
        }

        private void textBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.textBox1.Text = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string userName = textBox1.Text.Trim();
            string where = "and  U_Number like '%" + userName + "%' ";
            DataTable dsLog = dalCustom.getUserName("", where).Tables[0];
            this.dataGridView1.DataSource = dsLog.DefaultView;
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Btn_Add_Click(sender, e);
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Btn_Add_Click(sender, e);
        }
    }
}
