namespace ExamProj
{
    partial class ExamCRUDForm
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
            this.gridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuestionID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAnswerName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsCorrect = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isCorrectCheck = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.questionTxt = new DevExpress.XtraEditors.MemoEdit();
            this.difficultyCmb = new DevExpress.XtraEditors.ComboBoxEdit();
            this.saveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.questionLbl = new DevExpress.XtraEditors.LabelControl();
            this.difficultyLbl = new DevExpress.XtraEditors.LabelControl();
            this.answerLbl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCorrectCheck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyCmb.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl
            // 
            this.gridControl.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl.Location = new System.Drawing.Point(103, 146);
            this.gridControl.MainView = this.gridView;
            this.gridControl.Margin = new System.Windows.Forms.Padding(2);
            this.gridControl.Name = "gridControl";
            this.gridControl.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.isCorrectCheck});
            this.gridControl.Size = new System.Drawing.Size(741, 130);
            this.gridControl.TabIndex = 0;
            this.gridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView});
            // 
            // gridView
            // 
            this.gridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colQuestionID,
            this.colAnswerName,
            this.colIsCorrect});
            this.gridView.DetailHeight = 239;
            this.gridView.GridControl = this.gridControl;
            this.gridView.Name = "gridView";
            this.gridView.OptionsCustomization.AllowColumnMoving = false;
            this.gridView.OptionsCustomization.AllowGroup = false;
            this.gridView.OptionsCustomization.AllowSort = false;
            this.gridView.OptionsDetail.EnableMasterViewMode = false;
            this.gridView.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.FieldName = "ID";
            this.colID.Name = "colID";
            this.colID.OptionsColumn.AllowEdit = false;
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colQuestionID
            // 
            this.colQuestionID.FieldName = "QuestionID";
            this.colQuestionID.Name = "colQuestionID";
            this.colQuestionID.OptionsColumn.AllowEdit = false;
            this.colQuestionID.Visible = true;
            this.colQuestionID.VisibleIndex = 1;
            // 
            // colAnswerName
            // 
            this.colAnswerName.FieldName = "AnswerName";
            this.colAnswerName.Name = "colAnswerName";
            this.colAnswerName.Visible = true;
            this.colAnswerName.VisibleIndex = 2;
            // 
            // colIsCorrect
            // 
            this.colIsCorrect.ColumnEdit = this.isCorrectCheck;
            this.colIsCorrect.FieldName = "IsCorrect";
            this.colIsCorrect.Name = "colIsCorrect";
            this.colIsCorrect.Visible = true;
            this.colIsCorrect.VisibleIndex = 3;
            // 
            // isCorrectCheck
            // 
            this.isCorrectCheck.AutoHeight = false;
            this.isCorrectCheck.Name = "isCorrectCheck";
            // 
            // questionTxt
            // 
            this.questionTxt.Location = new System.Drawing.Point(103, 8);
            this.questionTxt.Margin = new System.Windows.Forms.Padding(2);
            this.questionTxt.Name = "questionTxt";
            this.questionTxt.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTxt.Properties.Appearance.Options.UseFont = true;
            this.questionTxt.Size = new System.Drawing.Size(741, 99);
            this.questionTxt.TabIndex = 6;
            // 
            // difficultyCmb
            // 
            this.difficultyCmb.Location = new System.Drawing.Point(103, 111);
            this.difficultyCmb.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyCmb.Name = "difficultyCmb";
            this.difficultyCmb.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyCmb.Properties.Appearance.Options.UseFont = true;
            this.difficultyCmb.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyCmb.Properties.AppearanceDropDown.Options.UseFont = true;
            this.difficultyCmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.difficultyCmb.Properties.DropDownRows = 3;
            this.difficultyCmb.Properties.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.difficultyCmb.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.difficultyCmb.Size = new System.Drawing.Size(741, 32);
            this.difficultyCmb.TabIndex = 7;
            // 
            // saveBtn
            // 
            this.saveBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveBtn.Appearance.Options.UseFont = true;
            this.saveBtn.Location = new System.Drawing.Point(732, 281);
            this.saveBtn.Margin = new System.Windows.Forms.Padding(2);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(112, 36);
            this.saveBtn.TabIndex = 8;
            this.saveBtn.Text = "Save";
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // questionLbl
            // 
            this.questionLbl.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.questionLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionLbl.Appearance.Options.UseBackColor = true;
            this.questionLbl.Appearance.Options.UseFont = true;
            this.questionLbl.Location = new System.Drawing.Point(8, 9);
            this.questionLbl.Margin = new System.Windows.Forms.Padding(2);
            this.questionLbl.Name = "questionLbl";
            this.questionLbl.Size = new System.Drawing.Size(89, 25);
            this.questionLbl.TabIndex = 9;
            this.questionLbl.Text = "Question:";
            // 
            // difficultyLbl
            // 
            this.difficultyLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.difficultyLbl.Appearance.Options.UseFont = true;
            this.difficultyLbl.Location = new System.Drawing.Point(8, 113);
            this.difficultyLbl.Margin = new System.Windows.Forms.Padding(2);
            this.difficultyLbl.Name = "difficultyLbl";
            this.difficultyLbl.Size = new System.Drawing.Size(89, 25);
            this.difficultyLbl.TabIndex = 10;
            this.difficultyLbl.Text = "Difficulty:";
            // 
            // answerLbl
            // 
            this.answerLbl.Appearance.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerLbl.Appearance.Options.UseFont = true;
            this.answerLbl.Location = new System.Drawing.Point(8, 144);
            this.answerLbl.Margin = new System.Windows.Forms.Padding(2);
            this.answerLbl.Name = "answerLbl";
            this.answerLbl.Size = new System.Drawing.Size(85, 25);
            this.answerLbl.TabIndex = 11;
            this.answerLbl.Text = "Answers:";
            // 
            // ExamCRUDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 324);
            this.MaximizeBox = false;
            this.Controls.Add(this.answerLbl);
            this.Controls.Add(this.difficultyLbl);
            this.Controls.Add(this.questionLbl);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.difficultyCmb);
            this.Controls.Add(this.questionTxt);
            this.Controls.Add(this.gridControl);
            this.Name = "ExamCRUDForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isCorrectCheck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.questionTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyCmb.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private DevExpress.XtraGrid.GridControl gridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuestionID;
        private DevExpress.XtraGrid.Columns.GridColumn colAnswerName;
        private DevExpress.XtraGrid.Columns.GridColumn colIsCorrect;
        private DevExpress.XtraEditors.MemoEdit questionTxt;
        private DevExpress.XtraEditors.ComboBoxEdit difficultyCmb;
        private DevExpress.XtraEditors.SimpleButton saveBtn;
        private DevExpress.XtraEditors.LabelControl questionLbl;
        private DevExpress.XtraEditors.LabelControl difficultyLbl;
        private DevExpress.XtraEditors.LabelControl answerLbl;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit isCorrectCheck;
    }
}