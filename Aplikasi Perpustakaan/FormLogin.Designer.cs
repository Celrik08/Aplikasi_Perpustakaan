namespace Aplikasi_Perpustakaan
{
    partial class FormLogin
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            TextUser = new TextBox();
            TextPassword = new TextBox();
            CheckPassword = new CheckBox();
            BtnKlik = new Button();
            BtnLogout = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(122, 8);
            label1.Name = "label1";
            label1.Size = new Size(58, 23);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 95);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // TextUser
            // 
            TextUser.Location = new Point(104, 58);
            TextUser.Name = "TextUser";
            TextUser.Size = new Size(146, 28);
            TextUser.TabIndex = 3;
            TextUser.KeyPress += TextUser_KeyPress;
            // 
            // TextPassword
            // 
            TextPassword.Location = new Point(104, 92);
            TextPassword.Name = "TextPassword";
            TextPassword.Size = new Size(146, 28);
            TextPassword.TabIndex = 4;
            TextPassword.KeyPress += TextPassword_KeyPress;
            // 
            // CheckPassword
            // 
            CheckPassword.AutoSize = true;
            CheckPassword.ForeColor = Color.White;
            CheckPassword.Location = new Point(12, 139);
            CheckPassword.Name = "CheckPassword";
            CheckPassword.Size = new Size(147, 24);
            CheckPassword.TabIndex = 5;
            CheckPassword.Text = "Show Password";
            CheckPassword.UseVisualStyleBackColor = true;
            CheckPassword.CheckedChanged += CheckPassword_CheckedChanged;
            // 
            // BtnKlik
            // 
            BtnKlik.Location = new Point(12, 180);
            BtnKlik.Name = "BtnKlik";
            BtnKlik.Size = new Size(85, 29);
            BtnKlik.TabIndex = 6;
            BtnKlik.Text = "Klik";
            BtnKlik.UseVisualStyleBackColor = true;
            BtnKlik.Click += BtnKlik_Click;
            // 
            // BtnLogout
            // 
            BtnLogout.Location = new Point(221, 179);
            BtnLogout.Name = "BtnLogout";
            BtnLogout.Size = new Size(85, 31);
            BtnLogout.TabIndex = 7;
            BtnLogout.Text = "Logout";
            BtnLogout.UseVisualStyleBackColor = true;
            BtnLogout.Click += BtnLogout_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 127, 255);
            ClientSize = new Size(333, 248);
            Controls.Add(BtnLogout);
            Controls.Add(BtnKlik);
            Controls.Add(CheckPassword);
            Controls.Add(TextPassword);
            Controls.Add(TextUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextUser;
        private TextBox TextPassword;
        private CheckBox CheckPassword;
        private Button BtnKlik;
        private Button BtnLogout;
    }
}