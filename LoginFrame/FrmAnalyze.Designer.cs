namespace LoginFrame
{
    partial class FrmAnalyze
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnalyze));
            this.dataGridView_Book = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.发送AAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.塔楼ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.email已发送ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息导入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.Btn_Del = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Book
            // 
            this.dataGridView_Book.AllowUserToAddRows = false;
            this.dataGridView_Book.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Book.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView_Book.Location = new System.Drawing.Point(6, 0);
            this.dataGridView_Book.Name = "dataGridView_Book";
            this.dataGridView_Book.RowTemplate.Height = 23;
            this.dataGridView_Book.Size = new System.Drawing.Size(850, 500);
            this.dataGridView_Book.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.发送AAToolStripMenuItem,
            this.塔楼ToolStripMenuItem,
            this.email已发送ToolStripMenuItem,
            this.导出ToolStripMenuItem,
            this.客户信息导入ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(143, 114);
            
            // 
            // 发送AAToolStripMenuItem
            // 
            this.发送AAToolStripMenuItem.Name = "发送AAToolStripMenuItem";
            this.发送AAToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.发送AAToolStripMenuItem.Text = "联系客户";
            
            // 
            // 塔楼ToolStripMenuItem
            // 
            this.塔楼ToolStripMenuItem.Name = "塔楼ToolStripMenuItem";
            this.塔楼ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.塔楼ToolStripMenuItem.Text = "QQ已发送";
            // 
            // email已发送ToolStripMenuItem
            // 
            this.email已发送ToolStripMenuItem.Name = "email已发送ToolStripMenuItem";
            this.email已发送ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.email已发送ToolStripMenuItem.Text = "E_mail已发送";
            // 
            // 导出ToolStripMenuItem
            // 
            this.导出ToolStripMenuItem.Name = "导出ToolStripMenuItem";
            this.导出ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.导出ToolStripMenuItem.Text = "客户信息导出";
            // 
            // 客户信息导入ToolStripMenuItem
            // 
            this.客户信息导入ToolStripMenuItem.Name = "客户信息导入ToolStripMenuItem";
            this.客户信息导入ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.客户信息导入ToolStripMenuItem.Text = "客户信息导入";
            // 
            // Btn_Update
            // 
            this.Btn_Update.Enabled = false;
            this.Btn_Update.Location = new System.Drawing.Point(391, 517);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(54, 28);
            this.Btn_Update.TabIndex = 12;
            this.Btn_Update.Text = "查看";
            this.Btn_Update.UseVisualStyleBackColor = true;
          
            // 
            // Btn_Del
            // 
            this.Btn_Del.Enabled = false;
            this.Btn_Del.Location = new System.Drawing.Point(451, 518);
            this.Btn_Del.Name = "Btn_Del";
            this.Btn_Del.Size = new System.Drawing.Size(49, 27);
            this.Btn_Del.TabIndex = 13;
            this.Btn_Del.Text = "删除";
            this.Btn_Del.UseVisualStyleBackColor = true;
            
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(530, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 14;
            this.button1.Text = "联  系";
            this.button1.UseVisualStyleBackColor = true;
            
            // 
            // FrmAnalyze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(858, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_Del);
            this.Controls.Add(this.dataGridView_Book);
            this.Controls.Add(this.Btn_Update);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAnalyze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "业务分析";
            this.Load += new System.EventHandler(this.FrmAnalyze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Book)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Book;
        private System.Windows.Forms.Button Btn_Update;
        private System.Windows.Forms.Button Btn_Del;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 发送AAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 塔楼ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem email已发送ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 导出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息导入ToolStripMenuItem;
    }
}