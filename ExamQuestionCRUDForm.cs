using ExamProj.Class;
using ExamProj.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ExamProj
{
    public partial class ExamQuestionCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        public Question question = new Question();
        private IQuestionServices _questionServices { get; set; }
        public ExamQuestionCRUDForm(Question question, IQuestionServices _questionServices)
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
                    answer.AnswerName = "";
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
            if (question.QuestionName == "")
            {
                MessageBox.Show("Question can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (question.Difficulty == "")
            {
                MessageBox.Show("Difficulty can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (question.Answers.Any(x => x.AnswerName == ""))
            {
                MessageBox.Show($"Answer {question.Answers.IndexOf(question.Answers.FirstOrDefault(x => x.AnswerName == "")) + 1} can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (question.Answers.Count != question.Answers.Select(x => x.AnswerName).Distinct().Count())
            {
                MessageBox.Show("Multiple answers can't be the same!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (question.Answers.Where(x => x.IsCorrect).ToList().Count > 1)
            {
                MessageBox.Show("There can only be one correct answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (question.Answers.Where(x => x.IsCorrect).ToList().Count == 0)
            {
                MessageBox.Show("There must be a correct answer!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
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