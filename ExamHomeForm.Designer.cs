namespace ExamProj
{
    partial class ExamHomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExamHomeForm));
            this.userBtn = new DevExpress.XtraEditors.SimpleButton();
            this.questionBtn = new DevExpress.XtraEditors.SimpleButton();
            this.examBtn = new DevExpress.XtraEditors.SimpleButton();
            this.welcomeLbl = new DevExpress.XtraEditors.LabelControl();
            this.logOutBtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // userBtn
            // 
            this.userBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userBtn.Appearance.Options.UseFont = true;
            this.userBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("userBtn.ImageOptions.Image");
            this.userBtn.Location = new System.Drawing.Point(12, 51);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(400, 50);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.Click += new System.EventHandler(this.userBtn_Click);
            // 
            // questionBtn
            // 
            this.questionBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionBtn.Appearance.Options.UseFont = true;
            this.questionBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("questionBtn.ImageOptions.Image");
            this.questionBtn.Location = new System.Drawing.Point(12, 109);
            this.questionBtn.Name = "questionBtn";
            this.questionBtn.Size = new System.Drawing.Size(400, 50);
            this.questionBtn.TabIndex = 1;
            this.questionBtn.Text = "Questions";
            this.questionBtn.Click += new System.EventHandler(this.questionBtn_Click);
            // 
            // examBtn
            // 
            this.examBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.examBtn.Appearance.Options.UseFont = true;
            this.examBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("examBtn.ImageOptions.Image");
            this.examBtn.Location = new System.Drawing.Point(12, 165);
            this.examBtn.Name = "examBtn";
            this.examBtn.Size = new System.Drawing.Size(400, 50);
            this.examBtn.TabIndex = 2;
            this.examBtn.Text = "Exam";
            this.examBtn.Click += new System.EventHandler(this.examBtn_Click);
            // 
            // welcomeLbl
            // 
            this.welcomeLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.welcomeLbl.Appearance.Options.UseFont = true;
            this.welcomeLbl.Appearance.Options.UseTextOptions = true;
            this.welcomeLbl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.welcomeLbl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.welcomeLbl.Location = new System.Drawing.Point(12, 12);
            this.welcomeLbl.Name = "welcomeLbl";
            this.welcomeLbl.Size = new System.Drawing.Size(400, 33);
            this.welcomeLbl.TabIndex = 3;
            // 
            // logOutBtn
            // 
            this.logOutBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logOutBtn.Appearance.Options.UseFont = true;
            this.logOutBtn.ImageOptions.Image = (System.Drawing.Image)resources.GetObject("logOutBtn.ImageOptions.Image");
            this.logOutBtn.Location = new System.Drawing.Point(12, 221);
            this.logOutBtn.Name = "logOutBtn";
            this.logOutBtn.Size = new System.Drawing.Size(400, 50);
            this.logOutBtn.TabIndex = 4;
            this.logOutBtn.Text = "Log Out";
            this.logOutBtn.Click += new System.EventHandler(this.logOutBtn_Click);
            // 
            // ExamHomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 283);
            this.Controls.Add(logOutBtn);
            this.Controls.Add(welcomeLbl);
            this.Controls.Add(examBtn);
            this.Controls.Add(questionBtn);
            this.Controls.Add(userBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ExamHomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home screen";
            this.ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton userBtn;
        private DevExpress.XtraEditors.SimpleButton questionBtn;
        private DevExpress.XtraEditors.SimpleButton examBtn;
        private DevExpress.XtraEditors.LabelControl welcomeLbl;
        private DevExpress.XtraEditors.SimpleButton logOutBtn;
    }
}