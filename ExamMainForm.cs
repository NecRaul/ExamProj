using ExamProj.Class;
using ExamProj.Context;
using ExamProj.Repositories;
using ExamProj.Services;
using ExamProj.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ExamProj
{
    public partial class ExamMainForm : DevExpress.XtraEditors.XtraForm
    {
        public List<Question> questions = new List<Question>();
        public List<string> userAnswers = new List<string>();
        public List<int> userRadioGroupIndices = new List<int>();
        public int questionNumber;
        private IQuestionServices _questionServices { get; set; }
        public ExamMainForm()
        {
            InitializeComponent();
            Random random = new Random();
            _questionServices = new QuestionServices(new Repository<Question>(new ExamDbContext()));
            List<Question> easyQuestions = _questionServices.GetAllQuestions().Where(x => x.Difficulty == "Easy").ToList();
            List<Question> normalQuestions = _questionServices.GetAllQuestions().Where(x => x.Difficulty == "Normal").ToList();
            List<Question> hardQuestions = _questionServices.GetAllQuestions().Where(x => x.Difficulty == "Hard").ToList();
            questions.AddRange(easyQuestions.OrderBy(x => random.Next()).Take(10).ToList());
            questions.AddRange(normalQuestions.OrderBy(x => random.Next()).Take(10).ToList());
            questions.AddRange(hardQuestions.OrderBy(x => random.Next()).Take(5).ToList());
            if (questions.Count < 25)
            {
                MessageBox.Show("There are not questions for an exam.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
            }
            else
            {
                for (int i = 0; i < 25; i++)
                {
                    userAnswers.Add("");
                    userRadioGroupIndices.Add(-1);
                }
                radioGroup.SelectedIndex = -1;
                questionLbl.Text = questions[0].QuestionName;
                for (int i = 0; i < 5; i++)
                {
                    radioGroup.Properties.Items[i].Description = questions[0].Answers[i].AnswerName;
                }
                questionNumber = 0;
            }
        }
        private void radioGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton currentButton = Controls.Find($"question{questionNumber + 1}", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton;
            if (radioGroup.SelectedIndex != -1)
            {
                questions[questionNumber].IsAnswered = true;
                userAnswers[questionNumber] = radioGroup.Properties.Items[radioGroup.SelectedIndex].Description;
                userRadioGroupIndices[questionNumber] = radioGroup.SelectedIndex;
                currentButton.Appearance.BackColor = System.Drawing.Color.Yellow;
            }
        }
        private void question_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton currentButton = sender as DevExpress.XtraEditors.SimpleButton;
            DevExpress.XtraEditors.SimpleButton previousButton = Controls.Find($"question{questionNumber + 1}", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton;
            if (radioGroup.SelectedIndex != -1)
            {
                questions[questionNumber].IsAnswered = true;
                userAnswers[questionNumber] = radioGroup.Properties.Items[radioGroup.SelectedIndex].Description;
                userRadioGroupIndices[questionNumber] = radioGroup.SelectedIndex;
                previousButton.Appearance.BackColor = System.Drawing.Color.Yellow;
            }
            questionNumber = Int32.Parse(Regex.Match(currentButton.Name, @"\d+").Value) - 1;
            if (questions[questionNumber].IsAnswered)
                radioGroup.SelectedIndex = userRadioGroupIndices[questionNumber];
            else
                radioGroup.SelectedIndex = -1;
            questionLbl.Text = questions[questionNumber].QuestionName;
            for (int i = 0; i < 5; i++)
            {
                radioGroup.Properties.Items[i].Description = questions[questionNumber].Answers[i].AnswerName;
            }
        }
        private void clearAnswerBtn_Click(object sender, EventArgs e)
        {
            DevExpress.XtraEditors.SimpleButton previousButton = Controls.Find($"question{questionNumber + 1}", true).FirstOrDefault() as DevExpress.XtraEditors.SimpleButton;
            radioGroup.SelectedIndex = -1;
            questions[questionNumber].IsAnswered = false;
            userAnswers[questionNumber] = "";
            previousButton.Appearance.BackColor = System.Drawing.Color.Transparent;
        }
        private void finishExamBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure about finishing the exam?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int correctAnswerCounter = 0;
                int incorrectAnswerCounter = 0;
                int notAnsweredCounter = 0;
                for (int i = 0; i < 25; i++)
                {
                    if (userAnswers[i] == questions[i].CorrectAnswer)
                        correctAnswerCounter++;
                    else if (userAnswers[i] == "")
                        notAnsweredCounter++;
                    else
                        incorrectAnswerCounter++;
                }
                MessageBox.Show($"Correct Answers: {correctAnswerCounter}\nIncorrect Answers: {incorrectAnswerCounter}\nNot Answered: {notAnsweredCounter}");
                radioGroup.Enabled = false;
                clearAnswerBtn.Enabled = false;
                finishExamBtn.Enabled = false;
            }
            else
                return;
        }
    }
}