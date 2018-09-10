namespace LoginFrame
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.txt_pwd2 = new System.Windows.Forms.TextBox();
            this.radion_man = new System.Windows.Forms.RadioButton();
            this.radio_women = new System.Windows.Forms.RadioButton();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Tel = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "性  别:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "电  话:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(77, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 27);
            this.button1.TabIndex = 7;
            this.button1.Text = "注 册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Location = new System.Drawing.Point(162, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(52, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "取 消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(128, 63);
            this.txt_username.MaxLength = 10;
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(158, 21);
            this.txt_username.TabIndex = 9;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(128, 219);
            this.txt_pwd.MaxLength = 10;
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.PasswordChar = '*';
            this.txt_pwd.Size = new System.Drawing.Size(158, 21);
            this.txt_pwd.TabIndex = 12;
            // 
            // txt_pwd2
            // 
            this.txt_pwd2.Location = new System.Drawing.Point(128, 261);
            this.txt_pwd2.MaxLength = 10;
            this.txt_pwd2.Name = "txt_pwd2";
            this.txt_pwd2.PasswordChar = '*';
            this.txt_pwd2.Size = new System.Drawing.Size(158, 21);
            this.txt_pwd2.TabIndex = 13;
            // 
            // radion_man
            // 
            this.radion_man.AutoSize = true;
            this.radion_man.Checked = true;
            this.radion_man.Location = new System.Drawing.Point(128, 144);
            this.radion_man.Name = "radion_man";
            this.radion_man.Size = new System.Drawing.Size(35, 16);
            this.radion_man.TabIndex = 15;
            this.radion_man.TabStop = true;
            this.radion_man.Text = "男";
            this.radion_man.UseVisualStyleBackColor = true;
            // 
            // radio_women
            // 
            this.radio_women.AutoSize = true;
            this.radio_women.Location = new System.Drawing.Point(207, 144);
            this.radio_women.Name = "radio_women";
            this.radio_women.Size = new System.Drawing.Size(35, 16);
            this.radio_women.TabIndex = 16;
            this.radio_women.Text = "女";
            this.radio_women.UseVisualStyleBackColor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(128, 103);
            this.textBox_Name.MaxLength = 10;
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(158, 21);
            this.textBox_Name.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 12);
            this.label6.TabIndex = 17;
            this.label6.Text = "姓  名:";
            // 
            // textBox_Tel
            // 
            this.textBox_Tel.Location = new System.Drawing.Point(128, 178);
            this.textBox_Tel.MaxLength = 10;
            this.textBox_Tel.Name = "textBox_Tel";
            this.textBox_Tel.Size = new System.Drawing.Size(158, 21);
            this.textBox_Tel.TabIndex = 19;
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Location = new System.Drawing.Point(246, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(51, 27);
            this.button3.TabIndex = 20;
            this.button3.Text = "修 改";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 383);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox_Tel);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.radio_women);
            this.Controls.Add(this.radion_man);
            this.Controls.Add(this.txt_pwd2);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(447, 468);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(347, 368);
            this.Name = "login";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户注册";
            this.Load += new System.EventHandler(this.login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.TextBox txt_pwd2;
        private System.Windows.Forms.RadioButton radion_man;
        private System.Windows.Forms.RadioButton radio_women;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Tel;
        private System.Windows.Forms.Button button3;

    }
}