namespace LoginFrame
{
    partial class FrmGrade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGrade));
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Confirm = new System.Windows.Forms.Button();
            this.buttona_Cancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.textBox_Note = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_No = new System.Windows.Forms.TextBox();
            this.textBox_Custom = new System.Windows.Forms.TextBox();
            this.comboBox_Product = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "会 员：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "单据编号：";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(390, 394);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(61, 25);
            this.button_Confirm.TabIndex = 36;
            this.button_Confirm.Text = "确定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // buttona_Cancel
            // 
            this.buttona_Cancel.Location = new System.Drawing.Point(476, 394);
            this.buttona_Cancel.Name = "buttona_Cancel";
            this.buttona_Cancel.Size = new System.Drawing.Size(61, 25);
            this.buttona_Cancel.TabIndex = 40;
            this.buttona_Cancel.Text = "取消";
            this.buttona_Cancel.UseVisualStyleBackColor = true;
            this.buttona_Cancel.Click += new System.EventHandler(this.buttona_Cancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 25);
            this.button3.TabIndex = 37;
            this.button3.Text = "选择 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(161, 139);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Name.Size = new System.Drawing.Size(121, 21);
            this.textBox_Name.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(353, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "级  别：";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(416, 139);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(121, 21);
            this.textBox_Amount.TabIndex = 42;
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(161, 238);
            this.textBox_Note.Multiline = true;
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(376, 72);
            this.textBox_Note.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "备 注：";
            // 
            // textBox_No
            // 
            this.textBox_No.Location = new System.Drawing.Point(161, 88);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.ReadOnly = true;
            this.textBox_No.Size = new System.Drawing.Size(121, 21);
            this.textBox_No.TabIndex = 50;
            // 
            // textBox_Custom
            // 
            this.textBox_Custom.Location = new System.Drawing.Point(416, 88);
            this.textBox_Custom.Name = "textBox_Custom";
            this.textBox_Custom.Size = new System.Drawing.Size(121, 21);
            this.textBox_Custom.TabIndex = 59;
            this.textBox_Custom.Visible = false;
            this.textBox_Custom.TextChanged += new System.EventHandler(this.textBox_Custom_TextChanged);
            // 
            // comboBox_Product
            // 
            this.comboBox_Product.FormattingEnabled = true;
            this.comboBox_Product.Location = new System.Drawing.Point(161, 186);
            this.comboBox_Product.Name = "comboBox_Product";
            this.comboBox_Product.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Product.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 61;
            this.label4.Text = "调整为：";
            // 
            // FrmGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 505);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_Product);
            this.Controls.Add(this.textBox_Custom);
            this.Controls.Add(this.textBox_No);
            this.Controls.Add(this.textBox_Note);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Amount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttona_Cancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Confirm);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGrade";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "会员级别调整";
            this.Load += new System.EventHandler(this.FrmGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Confirm;
        private System.Windows.Forms.Button buttona_Cancel;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.TextBox textBox_Note;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_No;
        private System.Windows.Forms.TextBox textBox_Custom;
        private System.Windows.Forms.ComboBox comboBox_Product;
        private System.Windows.Forms.Label label4;
    }
}