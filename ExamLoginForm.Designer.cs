namespace ExamProj
{
    partial class ExamLoginForm
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
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameLbl = new DevExpress.XtraEditors.LabelControl();
            this.passwordLbl = new DevExpress.XtraEditors.LabelControl();
            this.usernameTxt = new DevExpress.XtraEditors.TextEdit();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.loginBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)this.usernameTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.passwordTxt.Properties).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.Appearance.Options.UseFont = true;
            this.usernameLbl.Location = new System.Drawing.Point(12, 12);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(94, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.Appearance.Options.UseFont = true;
            this.passwordLbl.Location = new System.Drawing.Point(12, 50);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(88, 25);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(112, 9);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxt.Properties.Appearance.Options.UseFont = true;
            this.usernameTxt.Size = new System.Drawing.Size(250, 32);
            this.usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(112, 47);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.Properties.Appearance.Options.UseFont = true;
            this.passwordTxt.Size = new System.Drawing.Size(250, 32);
            this.passwordTxt.TabIndex = 3;
            // 
            // loginBtn
            // 
            this.loginBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginBtn.Appearance.Options.UseFont = true;
            this.loginBtn.Location = new System.Drawing.Point(137, 85);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(100, 32);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // ExamLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 129);
            this.Controls.Add(loginBtn);
            this.Controls.Add(passwordTxt);
            this.Controls.Add(usernameTxt);
            this.Controls.Add(passwordLbl);
            this.Controls.Add(usernameLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExamLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.AcceptButton = loginBtn;
            ((System.ComponentModel.ISupportInitialize)this.usernameTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.passwordTxt.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion

        private DevExpress.XtraEditors.LabelControl usernameLbl;
        private DevExpress.XtraEditors.LabelControl passwordLbl;
        private DevExpress.XtraEditors.TextEdit usernameTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.SimpleButton loginBtn;
    }
}