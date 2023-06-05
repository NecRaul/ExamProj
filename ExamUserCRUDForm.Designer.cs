namespace ExamProj
{
    partial class ExamUserCRUDForm
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
            this.teacherChk = new DevExpress.XtraEditors.CheckEdit();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)this.usernameTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.passwordTxt.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)this.teacherChk.Properties).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLbl
            // 
            this.usernameLbl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.usernameLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLbl.Appearance.Options.UseBackColor = true;
            this.usernameLbl.Appearance.Options.UseFont = true;
            this.usernameLbl.Location = new System.Drawing.Point(8, 9);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(2);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(101, 25);
            this.usernameLbl.TabIndex = 0;
            this.usernameLbl.Text = "Username:";
            // 
            // passwordLbl
            // 
            this.passwordLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordLbl.Appearance.Options.UseFont = true;
            this.passwordLbl.Location = new System.Drawing.Point(8, 48);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(2);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(95, 25);
            this.passwordLbl.TabIndex = 1;
            this.passwordLbl.Text = "Password:";
            // 
            // usernameTxt
            // 
            this.usernameTxt.Location = new System.Drawing.Point(114, 6);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTxt.Properties.Appearance.Options.UseFont = true;
            this.usernameTxt.Size = new System.Drawing.Size(200, 32);
            this.usernameTxt.TabIndex = 2;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(114, 44);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTxt.Properties.Appearance.Options.UseFont = true;
            this.passwordTxt.Size = new System.Drawing.Size(200, 32);
            this.passwordTxt.TabIndex = 3;
            // 
            // teacherChk
            // 
            this.teacherChk.Location = new System.Drawing.Point(320, 7);
            this.teacherChk.Name = "teacherChk";
            this.teacherChk.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teacherChk.Properties.Appearance.Options.UseFont = true;
            this.teacherChk.Properties.Caption = "Teacher?";
            this.teacherChk.Size = new System.Drawing.Size(112, 29);
            this.teacherChk.TabIndex = 4;
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Location = new System.Drawing.Point(319, 44);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 32);
            this.saveBtn.TabIndex = 5;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // ExamUserCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 87);
            this.Controls.Add(usernameLbl);
            this.Controls.Add(passwordLbl);
            this.Controls.Add(usernameTxt);
            this.Controls.Add(passwordTxt);
            this.Controls.Add(teacherChk);
            this.Controls.Add(saveBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExamUserCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User CRUD";
            this.AcceptButton = saveBtn;
            ((System.ComponentModel.ISupportInitialize)this.teacherChk.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.passwordTxt.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)this.usernameTxt.Properties).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.CheckEdit teacherChk;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private DevExpress.XtraEditors.TextEdit usernameTxt;
        private DevExpress.XtraEditors.LabelControl passwordLbl;
        private DevExpress.XtraEditors.LabelControl usernameLbl;
    }
}