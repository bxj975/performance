namespace LoginFrame
{
    partial class FrmQueryWorkR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQueryWorkR));
            this.dataGridView_Book = new System.Windows.Forms.DataGridView();
            this.LBHome = new System.Windows.Forms.Button();
            this.LBUp = new System.Windows.Forms.Button();
            this.LBNext = new System.Windows.Forms.Button();
            this.LBEnd = new System.Windows.Forms.Button();
            this.HNowPage = new System.Windows.Forms.TextBox();
            this.HPageSize = new System.Windows.Forms.TextBox();
            this.HAllPage = new System.Windows.Forms.TextBox();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.HWhere = new System.Windows.Forms.TextBox();
            this.HSelectID = new System.Windows.Forms.TextBox();
            this.PageMes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView_Book
            // 
            this.dataGridView_Book.AllowUserToAddRows = false;
            this.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Book.Location = new System.Drawing.Point(12, 3);
            this.dataGridView_Book.Name = "dataGridView_Book";
            this.dataGridView_Book.RowTemplate.Height = 23;
            this.dataGridView_Book.Size = new System.Drawing.Size(834, 518);
            this.dataGridView_Book.TabIndex = 1;
            // 
            // LBHome
            // 
            this.LBHome.Enabled = false;
            this.LBHome.Location = new System.Drawing.Point(697, 537);
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
            this.LBUp.Location = new System.Drawing.Point(729, 537);
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
            this.LBNext.Location = new System.Drawing.Point(761, 537);
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
            this.LBEnd.Location = new System.Drawing.Point(793, 537);
            this.LBEnd.Name = "LBEnd";
            this.LBEnd.Size = new System.Drawing.Size(26, 26);
            this.LBEnd.TabIndex = 6;
            this.LBEnd.Text = ">>";
            this.LBEnd.UseVisualStyleBackColor = true;
            this.LBEnd.Click += new System.EventHandler(this.LBEnd_Click);
            // 
            // HNowPage
            // 
            this.HNowPage.Location = new System.Drawing.Point(216, 540);
            this.HNowPage.Name = "HNowPage";
            this.HNowPage.Size = new System.Drawing.Size(56, 21);
            this.HNowPage.TabIndex = 9;
            this.HNowPage.Text = "1";
            this.HNowPage.Visible = false;
            // 
            // HPageSize
            // 
            this.HPageSize.Location = new System.Drawing.Point(278, 540);
            this.HPageSize.Name = "HPageSize";
            this.HPageSize.Size = new System.Drawing.Size(56, 21);
            this.HPageSize.TabIndex = 10;
            this.HPageSize.Text = "16";
            this.HPageSize.Visible = false;
            // 
            // HAllPage
            // 
            this.HAllPage.Location = new System.Drawing.Point(340, 540);
            this.HAllPage.Name = "HAllPage";
            this.HAllPage.Size = new System.Drawing.Size(56, 21);
            this.HAllPage.TabIndex = 11;
            this.HAllPage.Text = "0";
            this.HAllPage.Visible = false;
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(426, 535);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(84, 28);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "查看";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click);
            // 
            // HWhere
            // 
            this.HWhere.Location = new System.Drawing.Point(154, 540);
            this.HWhere.Name = "HWhere";
            this.HWhere.Size = new System.Drawing.Size(56, 21);
            this.HWhere.TabIndex = 8;
            this.HWhere.Visible = false;
            // 
            // HSelectID
            // 
            this.HSelectID.Location = new System.Drawing.Point(93, 540);
            this.HSelectID.Name = "HSelectID";
            this.HSelectID.Size = new System.Drawing.Size(56, 21);
            this.HSelectID.TabIndex = 7;
            this.HSelectID.Visible = false;
            // 
            // PageMes
            // 
            this.PageMes.AutoSize = true;
            this.PageMes.Location = new System.Drawing.Point(21, 548);
            this.PageMes.Name = "PageMes";
            this.PageMes.Size = new System.Drawing.Size(41, 12);
            this.PageMes.TabIndex = 2;
            this.PageMes.Text = "待查询";
            // 
            // FrmQueryWorkR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(858, 579);
            this.Controls.Add(this.HSelectID);
            this.Controls.Add(this.HAllPage);
            this.Controls.Add(this.HPageSize);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.LBNext);
            this.Controls.Add(this.HNowPage);
            this.Controls.Add(this.HWhere);
            this.Controls.Add(this.dataGridView_Book);
            this.Controls.Add(this.LBUp);
            this.Controls.Add(this.LBHome);
            this.Controls.Add(this.LBEnd);
            this.Controls.Add(this.PageMes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQueryWorkR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "业务联系查询";
            this.Load += new System.EventHandler(this.FrmQueryWorkR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Book;
        private System.Windows.Forms.Button LBHome;
        private System.Windows.Forms.Button LBUp;
        private System.Windows.Forms.Button LBNext;
        private System.Windows.Forms.Button LBEnd;
        private System.Windows.Forms.TextBox HNowPage;
        private System.Windows.Forms.TextBox HPageSize;
        private System.Windows.Forms.TextBox HAllPage;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.TextBox HWhere;
        private System.Windows.Forms.TextBox HSelectID;
        private System.Windows.Forms.Label PageMes;
    }
}