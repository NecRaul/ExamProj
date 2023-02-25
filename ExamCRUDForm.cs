using ExamProj.Class;
using ExamProj.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ExamProj
{
    public partial class ExamCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        public Question question = new Question();
        private IQuestionServices _questionServices { get; set; }
        public ExamCRUDForm(Question question, IQuestionServices _questionServices)
        {
            InitializeComponent();
            this.question = question;
            this._questionServices = _questionServices;
            questionTxt.Text = question.QuestionName;
            difficultyCmb.Text = question.Difficulty;
            if (question.Answers.Count == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    Answer answer = new Answer();
                    question.Answers.Add(answer);
                }
            }
            gridControl.DataSource = question.Answers;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            question.QuestionName = questionTxt.Text;
            question.Difficulty = difficultyCmb.Text;
            question.Answers = ((List<Answer>)gridControl.DataSource);
            if (question.ID != 0)
            {
                try
                {
                    _questionServices.UpdateQuestion(question);
                    MessageBox.Show("Question was updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unexpected error.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    _questionServices.InsertQuestion(question);
                    MessageBox.Show("Question was saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unexpected error.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            gridControl.RefreshDataSource();
        }
    }
}