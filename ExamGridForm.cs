using ExamProj.Class;
using ExamProj.Context;
using ExamProj.Repositories;
using ExamProj.Services;
using ExamProj.Services.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ExamProj
{
    public partial class ExamGridForm : DevExpress.XtraEditors.XtraForm
    {
        public Question question = new Question();
        private IQuestionServices _questionServices { get; set; }
        public ExamGridForm()
        {
            InitializeComponent();
            _questionServices = new QuestionServices(new Repository<Question>(new ExamDbContext()));
            RefreshQuestions();
        }
        public void RefreshQuestions()
        {
            gridControl.DataSource = _questionServices.GetAllQuestions().ToList();
        }
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                var selectedQuestion = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                question = _questionServices.GetQuestionByID(selectedQuestion);
                //CRUD Form Preview
                RefreshQuestions();
                question = new Question();
            }
            else
                MessageBox.Show("Select a question.", "Incorrect line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //CRUD Form New
            RefreshQuestions();
            question = new Question();
        }
        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Multiple deletions at the same time
            if (gridView.FocusedRowHandle > -1)
            {
                var result = MessageBox.Show("Are you sure about deleting this question?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var selectedQuestion = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                    _questionServices.DeleteQuestion(selectedQuestion);
                    RefreshQuestions();
                    MessageBox.Show($"Question {selectedQuestion} was deleted.", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Select a question.", "Incorrect line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}