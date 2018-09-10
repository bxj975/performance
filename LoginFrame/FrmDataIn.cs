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
    public partial class FrmDataInOut : Form
    {
        public FrmDataInOut()
        {
            InitializeComponent();
        }
        string State, barcode, Sqlname, T_Id, T_Name;
        private Frm客户分类 frm;
        public void Message(string State, string barcode, string Sqlname, string T_Id, string T_Name, Frm客户分类 frm)
        {
            this.State = State;
            this.barcode = barcode;
            this.Sqlname = Sqlname;
            this.T_Id = T_Id;
            this.T_Name = T_Name;
            this.frm = frm;
        }
        private void FrmDataInOut_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.txt_FileName.Text = this.openFileDialog1.FileName;
            }
      }
       
        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
