namespace LoginFrame
{
    partial class FrmProduct
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProduct));
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.txt_bookTypeName = new System.Windows.Forms.TextBox();
            this.Txt_Number = new System.Windows.Forms.TextBox();
            this.Txt_Name = new System.Windows.Forms.TextBox();
            this.Txt_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_RateB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_RateA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Confirm = new System.Windows.Forms.Button();
            this.Btn_Update = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "名 称:";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(352, 288);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(48, 23);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "添加";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "编 号:";
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(406, 288);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(48, 23);
            this.Btn_Cancel.TabIndex = 13;
            this.Btn_Cancel.Text = "取消";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // txt_bookTypeName
            // 
            this.txt_bookTypeName.Location = new System.Drawing.Point(191, 32);
            this.txt_bookTypeName.Name = "txt_bookTypeName";
            this.txt_bookTypeName.ReadOnly = true;
            this.txt_bookTypeName.Size = new System.Drawing.Size(167, 21);
            this.txt_bookTypeName.TabIndex = 14;
            // 
            // Txt_Number
            // 
            this.Txt_Number.Location = new System.Drawing.Point(191, 74);
            this.Txt_Number.Name = "Txt_Number";
            this.Txt_Number.Size = new System.Drawing.Size(167, 21);
            this.Txt_Number.TabIndex = 15;
            // 
            // Txt_Name
            // 
            this.Txt_Name.Location = new System.Drawing.Point(191, 116);
            this.Txt_Name.Name = "Txt_Name";
            this.Txt_Name.Size = new System.Drawing.Size(167, 21);
            this.Txt_Name.TabIndex = 16;
            // 
            // Txt_Amount
            // 
            this.Txt_Amount.Location = new System.Drawing.Point(191, 158);
            this.Txt_Amount.Name = "Txt_Amount";
            this.Txt_Amount.Size = new System.Drawing.Size(167, 21);
            this.Txt_Amount.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "金 额:";
            // 
            // Txt_RateB
            // 
            this.Txt_RateB.Location = new System.Drawing.Point(191, 240);
            this.Txt_RateB.Name = "Txt_RateB";
            this.Txt_RateB.Size = new System.Drawing.Size(167, 21);
            this.Txt_RateB.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(101, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 21;
            this.label5.Text = "系数B:";
            // 
            // Txt_RateA
            // 
            this.Txt_RateA.Location = new System.Drawing.Point(191, 198);
            this.Txt_RateA.Name = "Txt_RateA";
            this.Txt_RateA.Size = new System.Drawing.Size(167, 21);
            this.Txt_RateA.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(101, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 19;
            this.label6.Text = "系数A:";
            // 
            // Btn_Confirm
            // 
            this.Btn_Confirm.Location = new System.Drawing.Point(298, 288);
            this.Btn_Confirm.Name = "Btn_Confirm";
            this.Btn_Confirm.Size = new System.Drawing.Size(48, 23);
            this.Btn_Confirm.TabIndex = 24;
            this.Btn_Confirm.Text = "确定";
            this.Btn_Confirm.UseVisualStyleBackColor = true;
            this.Btn_Confirm.Click += new System.EventHandler(this.Btn_Confirm_Click);
            // 
            // Btn_Update
            // 
            this.Btn_Update.Location = new System.Drawing.Point(244, 288);
            this.Btn_Update.Name = "Btn_Update";
            this.Btn_Update.Size = new System.Drawing.Size(48, 23);
            this.Btn_Update.TabIndex = 23;
            this.Btn_Update.Text = "修改";
            this.Btn_Update.UseVisualStyleBackColor = true;
            this.Btn_Update.Click += new System.EventHandler(this.Btn_Update_Click_1);
            // 
            // FrmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 344);
            this.Controls.Add(this.Btn_Confirm);
            this.Controls.Add(this.Btn_Update);
            this.Controls.Add(this.Txt_RateB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_RateA);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_Name);
            this.Controls.Add(this.Txt_Number);
            this.Controls.Add(this.txt_bookTypeName);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProduct";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "产品类别";
            this.Load += new System.EventHandler(this.FrmProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.TextBox txt_bookTypeName;
        private System.Windows.Forms.TextBox Txt_Number;
        private System.Windows.Forms.TextBox Txt_Name;
        private System.Windows.Forms.TextBox Txt_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_RateB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_RateA;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Confirm;
        private System.Windows.Forms.Button Btn_Update;
    }
}