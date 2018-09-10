namespace LoginFrame
{
    partial class FrmQueryCustom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryCustom));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.Txt_Recommend = new System.Windows.Forms.TextBox();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Query = new System.Windows.Forms.Button();
            this.dtp_publishDate = new System.Windows.Forms.DateTimePicker();
            this.txt_publishDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_Type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView_Book = new System.Windows.Forms.DataGridView();
            this.PageMes = new System.Windows.Forms.Label();
            this.LBHome = new System.Windows.Forms.Button();
            this.LBUp = new System.Windows.Forms.Button();
            this.LBNext = new System.Windows.Forms.Button();
            this.LBEnd = new System.Windows.Forms.Button();
            this.HSelectID = new System.Windows.Forms.TextBox();
            this.HWhere = new System.Windows.Forms.TextBox();
            this.HNowPage = new System.Windows.Forms.TextBox();
            this.HPageSize = new System.Windows.Forms.TextBox();
            this.HAllPage = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.Txt_Recommend);
            this.groupBox1.Controls.Add(this.Txt_Tel);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.Txt_Number);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Btn_Query);
            this.groupBox1.Controls.Add(this.dtp_publishDate);
            this.groupBox1.Controls.Add(this.txt_publishDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cb_Type);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Name);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "设置查询条件";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(799, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(36, 21);
            this.textBox1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(767, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 19;
            this.label7.Text = "行数:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(694, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 16);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "自动加载";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Txt_Recommend
            // 
            this.Txt_Recommend.Location = new System.Drawing.Point(77, 64);
            this.Txt_Recommend.Name = "Txt_Recommend";
            this.Txt_Recommend.Size = new System.Drawing.Size(145, 21);
            this.Txt_Recommend.TabIndex = 17;
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Location = new System.Drawing.Point(534, 30);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(145, 21);
            this.Txt_Tel.TabIndex = 16;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(774, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(61, 22);
            this.button2.TabIndex = 15;
            this.button2.Text = "新增";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(77, 28);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(145, 21);
            this.Txt_Number.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(253, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "姓名：";
            // 
            // Btn_Query
            // 
            this.Btn_Query.Location = new System.Drawing.Point(694, 28);
            this.Btn_Query.Name = "Btn_Query";
            this.Btn_Query.Size = new System.Drawing.Size(61, 22);
            this.Btn_Query.TabIndex = 9;
            this.Btn_Query.Text = "查询";
            this.Btn_Query.UseVisualStyleBackColor = true;
            this.Btn_Query.Click += new System.EventHandler(this.Btn_Query_Click);
            // 
            // dtp_publishDate
            // 
            this.dtp_publishDate.Location = new System.Drawing.Point(663, 63);
            this.dtp_publishDate.Name = "dtp_publishDate";
            this.dtp_publishDate.Size = new System.Drawing.Size(16, 21);
            this.dtp_publishDate.TabIndex = 8;
            this.dtp_publishDate.ValueChanged += new System.EventHandler(this.dtp_publishDate_ValueChanged);
            // 
            // txt_publishDate
            // 
            this.txt_publishDate.Location = new System.Drawing.Point(534, 63);
            this.txt_publishDate.Name = "txt_publishDate";
            this.txt_publishDate.Size = new System.Drawing.Size(130, 21);
            this.txt_publishDate.TabIndex = 7;
            this.txt_publishDate.DoubleClick += new System.EventHandler(this.txt_publishDate_DoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "管理人：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(463, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "登记时间：";
            // 
            // cb_Type
            // 
            this.cb_Type.FormattingEnabled = true;
            this.cb_Type.Location = new System.Drawing.Point(300, 63);
            this.cb_Type.Name = "cb_Type";
            this.cb_Type.Size = new System.Drawing.Size(145, 20);
            this.cb_Type.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "类别：";
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(300, 28);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(145, 21);
            this.Txt_Name.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "编号：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(487, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "电话：";
            // 
            // dataGridView_Book
            // 
            this.dataGridView_Book.AllowUserToAddRows = false;
            this.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Book.Location = new System.Drawing.Point(6, 112);
            this.dataGridView_Book.Name = "dataGridView_Book";
            this.dataGridView_Book.RowTemplate.Height = 23;
            this.dataGridView_Book.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Book.Size = new System.Drawing.Size(850, 500);
            this.dataGridView_Book.TabIndex = 1;
            this.dataGridView_Book.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Book_CellContentDoubleClick);
            // 
            // PageMes
            // 
            this.PageMes.AutoSize = true;
            this.PageMes.Location = new System.Drawing.Point(12, 632);
            this.PageMes.Name = "PageMes";
            this.PageMes.Size = new System.Drawing.Size(41, 12);
            this.PageMes.TabIndex = 2;
            this.PageMes.Text = "待查询";
            // 
            // LBHome
            // 
            this.LBHome.Enabled = false;
            this.LBHome.Location = new System.Drawing.Point(700, 626);
            this.LBHome.Name = "LBHome";
            this.LBHome.Size = new System.Drawing.Size(26, 26);
            this.LBHome.TabIndex = 3;
            this.LBHome.Text = "<<";
            this.LBHome.UseVisualStyleBackColor = true;
            this.LBHome.Click += new System.EventHandler(this.LBHome_Click);
            // 
            // LBUp
            // 
            this.LBUp.Enabled = false;
            this.LBUp.Location = new System.Drawing.Point(732, 626);
            this.LBUp.Name = "LBUp";
            this.LBUp.Size = new System.Drawing.Size(26, 26);
            this.LBUp.TabIndex = 4;
            this.LBUp.Text = "<";
            this.LBUp.UseVisualStyleBackColor = true;
            this.LBUp.Click += new System.EventHandler(this.LBUp_Click);
            // 
            // LBNext
            // 
            this.LBNext.Enabled = false;
            this.LBNext.Location = new System.Drawing.Point(764, 626);
            this.LBNext.Name = "LBNext";
            this.LBNext.Size = new System.Drawing.Size(26, 26);
            this.LBNext.TabIndex = 5;
            this.LBNext.Text = ">";
            this.LBNext.UseVisualStyleBackColor = true;
            this.LBNext.Click += new System.EventHandler(this.LBNext_Click);
            // 
            // LBEnd
            // 
            this.LBEnd.Enabled = false;
            this.LBEnd.Location = new System.Drawing.Point(796, 626);
            this.LBEnd.Name = "LBEnd";
            this.LBEnd.Size = new System.Drawing.Size(26, 26);
            this.LBEnd.TabIndex = 6;
            this.LBEnd.Text = ">>";
            this.LBEnd.UseVisualStyleBackColor = true;
            this.LBEnd.Click += new System.EventHandler(this.LBEnd_Click);
            // 
            // HSelectID
            // 
            this.HSelectID.Location = new System.Drawing.Point(83, 625);
            this.HSelectID.Name = "HSelectID";
            this.HSelectID.Size = new System.Drawing.Size(56, 21);
            this.HSelectID.TabIndex = 7;
            this.HSelectID.Visible = false;
            // 
            // HWhere
            // 
            this.HWhere.Location = new System.Drawing.Point(144, 625);
            this.HWhere.Name = "HWhere";
            this.HWhere.Size = new System.Drawing.Size(56, 21);
            this.HWhere.TabIndex = 8;
            this.HWhere.Visible = false;
            // 
            // HNowPage
            // 
            this.HNowPage.Location = new System.Drawing.Point(206, 625);
            this.HNowPage.Name = "HNowPage";
            this.HNowPage.Size = new System.Drawing.Size(56, 21);
            this.HNowPage.TabIndex = 9;
            this.HNowPage.Text = "1";
            this.HNowPage.Visible = false;
            // 
            // HPageSize
            // 
            this.HPageSize.Location = new System.Drawing.Point(268, 625);
            this.HPageSize.Name = "HPageSize";
            this.HPageSize.Size = new System.Drawing.Size(56, 21);
            this.HPageSize.TabIndex = 10;
            this.HPageSize.Text = "16";
            this.HPageSize.Visible = false;
            // 
            // HAllPage
            // 
            this.HAllPage.Location = new System.Drawing.Point(330, 625);
            this.HAllPage.Name = "HAllPage";
            this.HAllPage.Size = new System.Drawing.Size(56, 21);
            this.HAllPage.TabIndex = 11;
            this.HAllPage.Text = "0";
            this.HAllPage.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Enabled = false;
            this.Btn_Update.Location = new System.Drawing.Point(495, 626);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(54, 28);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "查看";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // Btn_Del
            // 
            this.Btn_Del.Enabled = false;
            this.Btn_Del.Location = new System.Drawing.Point(555, 626);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(49, 28);
            this.Btn_Del.TabIndex = 13;
            this.Btn_Del.Text = "删除";
            this.Btn_Del.UseVisualStyleBackColor = true;
            this.Btn_Del.Click += new System.EventHandler(this.Btn_Del_Click);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 626);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "返回";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmQueryCustom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(864, 665);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.HAllPage);
            this.Controls.Add(this.HPageSize);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.HNowPage);
            this.Controls.Add(this.HWhere);
            this.Controls.Add(this.HSelectID);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.PageMes);
            this.Controls.Add(this.dataGridView_Book);
            this.Controls.Add(this.LBUp);
            this.Controls.Add(this.LBEnd);
            this.Controls.Add(this.LBNext);
            this.Controls.Add(this.LBHome);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryCustom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员信息查询";
            this.Load += new System.EventHandler(this.FrmQueryBook_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtp_publishDate;
        private System.Windows.Forms.TextBox txt_publishDate;
        private System.Windows.Forms.DataGridView dataGridView_Book;
        private System.Windows.Forms.Label PageMes;
        private System.Windows.Forms.Button LBHome;
        private System.Windows.Forms.Button LBUp;
        private System.Windows.Forms.Button LBNext;
        private System.Windows.Forms.Button LBEnd;
        private System.Windows.Forms.TextBox HSelectID;
        private System.Windows.Forms.TextBox HWhere;
        private System.Windows.Forms.TextBox HNowPage;
        private System.Windows.Forms.TextBox HPageSize;
        private System.Windows.Forms.TextBox HAllPage;
        private System.Windows.Forms.Button Btn_Query;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Recommend;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
       
    }
}