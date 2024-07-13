namespace FormsEjercicio1
{
    partial class SingUpForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSubmit = new Button();
            labelFullname = new Label();
            tbFullName = new TextBox();
            tbEmail = new TextBox();
            tbAddress = new TextBox();
            labelEmail = new Label();
            labelAddress = new Label();
            labelUserName = new Label();
            tbUserName = new TextBox();
            labelPassword = new Label();
            tbPassword = new TextBox();
            labelConfirmPassword = new Label();
            tbPasswordConfirm = new TextBox();
            errorFullName = new Label();
            errorEmail = new Label();
            errorAddress = new Label();
            errorUserName = new Label();
            errorPassword = new Label();
            errorPasswordConfirm = new Label();
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(383, 249);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 29);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += Button1_Click;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Location = new Point(13, 20);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(61, 15);
            labelFullname.TabIndex = 8;
            labelFullname.Text = "FullName:";
            labelFullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(13, 38);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(218, 23);
            tbFullName.TabIndex = 1;
            tbFullName.TextChanged += TbFullName_TextChanged;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(13, 111);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(218, 23);
            tbEmail.TabIndex = 2;
            tbEmail.TextChanged += TbEmail_TextChanged;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(13, 185);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(218, 23);
            tbAddress.TabIndex = 3;
            tbAddress.TextChanged += TbAddress_TextChanged;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(13, 93);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(13, 167);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(52, 15);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Address:";
            labelAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(255, 20);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(65, 15);
            labelUserName.TabIndex = 11;
            labelUserName.Text = "UserName:";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(255, 38);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(218, 23);
            tbUserName.TabIndex = 4;
            tbUserName.TextChanged += TbUserName_TextChanged;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(255, 93);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(255, 111);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(218, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.TextChanged += TbPassword_TextChanged;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(255, 167);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(107, 15);
            labelConfirmPassword.TabIndex = 13;
            labelConfirmPassword.Text = "Confirm Password:";
            labelConfirmPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Location = new Point(255, 185);
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.Size = new Size(218, 23);
            tbPasswordConfirm.TabIndex = 6;
            tbPasswordConfirm.UseSystemPasswordChar = true;
            tbPasswordConfirm.TextChanged += TbPasswordConfirm_TextChanged;
            // 
            // errorFullName
            // 
            errorFullName.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorFullName.ForeColor = Color.Red;
            errorFullName.Location = new Point(13, 64);
            errorFullName.Name = "errorFullName";
            errorFullName.RightToLeft = RightToLeft.No;
            errorFullName.Size = new Size(218, 29);
            errorFullName.TabIndex = 14;
            errorFullName.Text = "Error de FullName";
            // 
            // errorEmail
            // 
            errorEmail.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorEmail.ForeColor = Color.Red;
            errorEmail.Location = new Point(13, 137);
            errorEmail.Name = "errorEmail";
            errorEmail.RightToLeft = RightToLeft.No;
            errorEmail.Size = new Size(218, 30);
            errorEmail.TabIndex = 15;
            errorEmail.Text = "Error de Email";
            errorEmail.Click += Label1_Click;
            // 
            // errorAddress
            // 
            errorAddress.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorAddress.ForeColor = Color.Red;
            errorAddress.Location = new Point(13, 211);
            errorAddress.Name = "errorAddress";
            errorAddress.RightToLeft = RightToLeft.No;
            errorAddress.Size = new Size(218, 35);
            errorAddress.TabIndex = 16;
            errorAddress.Text = "Error de Address";
            // 
            // errorUserName
            // 
            errorUserName.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorUserName.ForeColor = Color.Red;
            errorUserName.Location = new Point(255, 64);
            errorUserName.Name = "errorUserName";
            errorUserName.RightToLeft = RightToLeft.No;
            errorUserName.Size = new Size(218, 29);
            errorUserName.TabIndex = 17;
            errorUserName.Text = "Error de UserName";
            // 
            // errorPassword
            // 
            errorPassword.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorPassword.ForeColor = Color.Red;
            errorPassword.Location = new Point(255, 137);
            errorPassword.Name = "errorPassword";
            errorPassword.RightToLeft = RightToLeft.No;
            errorPassword.Size = new Size(218, 30);
            errorPassword.TabIndex = 18;
            errorPassword.Text = "Error de Password";
            // 
            // errorPasswordConfirm
            // 
            errorPasswordConfirm.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold);
            errorPasswordConfirm.ForeColor = Color.Red;
            errorPasswordConfirm.Location = new Point(255, 211);
            errorPasswordConfirm.Name = "errorPasswordConfirm";
            errorPasswordConfirm.RightToLeft = RightToLeft.No;
            errorPasswordConfirm.Size = new Size(218, 35);
            errorPasswordConfirm.TabIndex = 19;
            errorPasswordConfirm.Text = "Error de Password Confirm";
            // 
            // SingUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(497, 290);
            Controls.Add(errorPasswordConfirm);
            Controls.Add(errorPassword);
            Controls.Add(errorUserName);
            Controls.Add(errorAddress);
            Controls.Add(errorEmail);
            Controls.Add(errorFullName);
            Controls.Add(labelConfirmPassword);
            Controls.Add(tbPasswordConfirm);
            Controls.Add(labelPassword);
            Controls.Add(tbPassword);
            Controls.Add(labelUserName);
            Controls.Add(tbUserName);
            Controls.Add(labelAddress);
            Controls.Add(labelEmail);
            Controls.Add(tbAddress);
            Controls.Add(tbEmail);
            Controls.Add(tbFullName);
            Controls.Add(labelFullname);
            Controls.Add(btnSubmit);
            Name = "SingUpForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SingUp Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubmit;
        private Label labelFullname;
        private TextBox tbFullName;
        private TextBox tbEmail;
        private TextBox tbAddress;
        private Label labelEmail;
        private Label labelAddress;
        private Label labelUserName;
        private TextBox tbUserName;
        private Label labelPassword;
        private TextBox tbPassword;
        private Label labelConfirmPassword;
        private TextBox tbPasswordConfirm;
        private Label errorFullName;
        private Label errorEmail;
        private Label errorAddress;
        private Label errorUserName;
        private Label errorPassword;
        private Label errorPasswordConfirm;
    }
}
