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
            SuspendLayout();
            // 
            // btnSubmit
            // 
            btnSubmit.Font = new Font("Segoe UI", 11F);
            btnSubmit.Location = new Point(237, 226);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(90, 28);
            btnSubmit.TabIndex = 7;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += Button1_Click;
            // 
            // labelFullname
            // 
            labelFullname.AutoSize = true;
            labelFullname.Location = new Point(61, 30);
            labelFullname.Name = "labelFullname";
            labelFullname.Size = new Size(61, 15);
            labelFullname.TabIndex = 8;
            labelFullname.Text = "FullName:";
            labelFullname.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(140, 27);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(187, 23);
            tbFullName.TabIndex = 1;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(140, 56);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(187, 23);
            tbEmail.TabIndex = 2;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(140, 85);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(187, 23);
            tbAddress.TabIndex = 3;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(83, 59);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(39, 15);
            labelEmail.TabIndex = 9;
            labelEmail.Text = "Email:";
            labelEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Location = new Point(70, 88);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(52, 15);
            labelAddress.TabIndex = 10;
            labelAddress.Text = "Address:";
            labelAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Location = new Point(57, 133);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(65, 15);
            labelUserName.TabIndex = 11;
            labelUserName.Text = "UserName:";
            labelUserName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbUserName
            // 
            tbUserName.Location = new Point(140, 130);
            tbUserName.Name = "tbUserName";
            tbUserName.Size = new Size(187, 23);
            tbUserName.TabIndex = 4;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Location = new Point(62, 162);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(60, 15);
            labelPassword.TabIndex = 12;
            labelPassword.Text = "Password:";
            labelPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(140, 159);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(187, 23);
            tbPassword.TabIndex = 5;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // labelConfirmPassword
            // 
            labelConfirmPassword.AutoSize = true;
            labelConfirmPassword.Location = new Point(15, 191);
            labelConfirmPassword.Name = "labelConfirmPassword";
            labelConfirmPassword.Size = new Size(107, 15);
            labelConfirmPassword.TabIndex = 13;
            labelConfirmPassword.Text = "Confirm Password:";
            labelConfirmPassword.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tbPasswordConfirm
            // 
            tbPasswordConfirm.Location = new Point(140, 188);
            tbPasswordConfirm.Name = "tbPasswordConfirm";
            tbPasswordConfirm.Size = new Size(187, 23);
            tbPasswordConfirm.TabIndex = 6;
            tbPasswordConfirm.UseSystemPasswordChar = true;
            // 
            // SingUpForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(352, 270);
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
    }
}
