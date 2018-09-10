namespace LoginFrame
{
    partial class Frm客户分类
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm客户分类));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel添加 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel修改 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel删除 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel退出 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripLabel添加,
            this.toolStripLabel修改,
            this.toolStripLabel删除,
            this.toolStripSeparator2,
            this.toolStripLabel退出});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(633, 69);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 69);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(57, 66);
            this.toolStripButton1.Text = "显示全部";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripLabel添加
            // 
            this.toolStripLabel添加.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel添加.Image")));
            this.toolStripLabel添加.Name = "toolStripLabel添加";
            this.toolStripLabel添加.Size = new System.Drawing.Size(57, 66);
            this.toolStripLabel添加.Text = "新增分类";
            this.toolStripLabel添加.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel添加.Click += new System.EventHandler(this.toolStripLabel添加_Click);
            // 
            // toolStripLabel修改
            // 
            this.toolStripLabel修改.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel修改.Image")));
            this.toolStripLabel修改.Name = "toolStripLabel修改";
            this.toolStripLabel修改.Size = new System.Drawing.Size(57, 66);
            this.toolStripLabel修改.Text = "信息修改";
            this.toolStripLabel修改.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel修改.Click += new System.EventHandler(this.toolStripLabel修改_Click);
            // 
            // toolStripLabel删除
            // 
            this.toolStripLabel删除.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel删除.Image")));
            this.toolStripLabel删除.Name = "toolStripLabel删除";
            this.toolStripLabel删除.Size = new System.Drawing.Size(57, 66);
            this.toolStripLabel删除.Text = "信息删除";
            this.toolStripLabel删除.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel删除.Visible = false;
            this.toolStripLabel删除.Click += new System.EventHandler(this.toolStripLabel删除_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 69);
            // 
            // toolStripLabel退出
            // 
            this.toolStripLabel退出.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLabel退出.Image")));
            this.toolStripLabel退出.Name = "toolStripLabel退出";
            this.toolStripLabel退出.Size = new System.Drawing.Size(54, 66);
            this.toolStripLabel退出.Text = "退  出";
            this.toolStripLabel退出.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLabel退出.Click += new System.EventHandler(this.toolStripLabel退出_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 398);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(633, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "总记录数量：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)
                        | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(609, 323);
            this.dataGridView1.TabIndex = 11;
            // 
            // Frm客户分类
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 420);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(641, 447);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(641, 447);
            this.Name = "Frm客户分类";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分类";
            this.Load += new System.EventHandler(this.Frm客户分类_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripLabel添加;
        private System.Windows.Forms.ToolStripButton toolStripLabel修改;
        private System.Windows.Forms.ToolStripButton toolStripLabel删除;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripLabel退出;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}