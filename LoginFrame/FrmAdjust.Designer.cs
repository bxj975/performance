namespace LoginFrame
{
    partial class FrmAdjust
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdjust));
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
            this.radioButton_Reduce = new System.Windows.Forms.RadioButton();
            this.radioButton_Add = new System.Windows.Forms.RadioButton();
            this.textBox_Custom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Type = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 12);
            this.label6.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 23;
            this.label3.Text = "会 员：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 19;
            this.label1.Text = "单据编号：";
            // 
            // button_Confirm
            // 
            this.button_Confirm.Location = new System.Drawing.Point(393, 379);
            this.button_Confirm.Name = "button_Confirm";
            this.button_Confirm.Size = new System.Drawing.Size(61, 25);
            this.button_Confirm.TabIndex = 36;
            this.button_Confirm.Text = "确定";
            this.button_Confirm.UseVisualStyleBackColor = true;
            this.button_Confirm.Click += new System.EventHandler(this.button_Confirm_Click);
            // 
            // buttona_Cancel
            // 
            this.buttona_Cancel.Location = new System.Drawing.Point(486, 379);
            this.buttona_Cancel.Name = "buttona_Cancel";
            this.buttona_Cancel.Size = new System.Drawing.Size(61, 25);
            this.buttona_Cancel.TabIndex = 40;
            this.buttona_Cancel.Text = "取消";
            this.buttona_Cancel.UseVisualStyleBackColor = true;
            this.buttona_Cancel.Click += new System.EventHandler(this.buttona_Cancel_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(276, 134);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(37, 25);
            this.button3.TabIndex = 37;
            this.button3.Text = "选择 ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(149, 137);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_Name.Size = new System.Drawing.Size(121, 21);
            this.textBox_Name.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 41;
            this.label2.Text = "调整金额：";
            // 
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(149, 187);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(121, 21);
            this.textBox_Amount.TabIndex = 42;
            // 
            // textBox_Note
            // 
            this.textBox_Note.Location = new System.Drawing.Point(149, 236);
            this.textBox_Note.Multiline = true;
            this.textBox_Note.Name = "textBox_Note";
            this.textBox_Note.Size = new System.Drawing.Size(398, 72);
            this.textBox_Note.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 47;
            this.label5.Text = "备 注：";
            // 
            // textBox_No
            // 
            this.textBox_No.Location = new System.Drawing.Point(149, 86);
            this.textBox_No.Name = "textBox_No";
            this.textBox_No.ReadOnly = true;
            this.textBox_No.Size = new System.Drawing.Size(121, 21);
            this.textBox_No.TabIndex = 50;
            // 
            // radioButton_Reduce
            // 
            this.radioButton_Reduce.AutoSize = true;
            this.radioButton_Reduce.Checked = true;
            this.radioButton_Reduce.Location = new System.Drawing.Point(341, 192);
            this.radioButton_Reduce.Name = "radioButton_Reduce";
            this.radioButton_Reduce.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Reduce.TabIndex = 57;
            this.radioButton_Reduce.TabStop = true;
            this.radioButton_Reduce.Text = "减少";
            this.radioButton_Reduce.UseVisualStyleBackColor = true;
            // 
            // radioButton_Add
            // 
            this.radioButton_Add.AutoSize = true;
            this.radioButton_Add.Location = new System.Drawing.Point(426, 192);
            this.radioButton_Add.Name = "radioButton_Add";
            this.radioButton_Add.Size = new System.Drawing.Size(47, 16);
            this.radioButton_Add.TabIndex = 58;
            this.radioButton_Add.Text = "增加";
            this.radioButton_Add.UseVisualStyleBackColor = true;
            // 
            // textBox_Custom
            // 
            this.textBox_Custom.Location = new System.Drawing.Point(426, 86);
            this.textBox_Custom.Name = "textBox_Custom";
            this.textBox_Custom.Size = new System.Drawing.Size(121, 21);
            this.textBox_Custom.TabIndex = 59;
            this.textBox_Custom.Visible = false;
            this.textBox_Custom.TextChanged += new System.EventHandler(this.textBox_Custom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 60;
            this.label4.Text = "调整类型：";
            // 
            // comboBox_Type
            // 
            this.comboBox_Type.FormattingEnabled = true;
            this.comboBox_Type.Items.AddRange(new object[] {
            "业绩核算调整",
            "业绩合计调整",
            "团队业绩调整"});
            this.comboBox_Type.Location = new System.Drawing.Point(426, 139);
            this.comboBox_Type.Name = "comboBox_Type";
            this.comboBox_Type.Size = new System.Drawing.Size(121, 20);
            this.comboBox_Type.TabIndex = 61;
            // 
            // FrmAdjust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 505);
            this.Controls.Add(this.comboBox_Type);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Custom);
            this.Controls.Add(this.radioButton_Add);
            this.Controls.Add(this.radioButton_Reduce);
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
            this.Name = "FrmAdjust";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "业绩调整";
            this.Load += new System.EventHandler(this.FrmAdjust_Load);
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
        private System.Windows.Forms.RadioButton radioButton_Reduce;
        private System.Windows.Forms.RadioButton radioButton_Add;
        private System.Windows.Forms.TextBox textBox_Custom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Type;
    }
}