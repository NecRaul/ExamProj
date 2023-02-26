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
    public partial class ExamHomeForm : DevExpress.XtraEditors.XtraForm
    {
        public ExamHomeForm(User user)
        {
            InitializeComponent();
            welcomeLbl.Text = $"Welcome {user.Username}!";
            if (!user.IsTeacher)
            {
                userBtn.Enabled = false;
                questionBtn.Enabled = false;
            }
        }
        private void userBtn_Click(object sender, EventArgs e)
        {
            ExamUserGridForm form = new ExamUserGridForm();
            form.ShowDialog();
        }
        private void questionBtn_Click(object sender, EventArgs e)
        {
            ExamQuestionGridForm form = new ExamQuestionGridForm();
            form.ShowDialog();
        }
        private void examBtn_Click(object sender, EventArgs e)
        {
            ExamMainForm form = new ExamMainForm();
            try
            {
                form.ShowDialog();
            }
            catch (Exception exception)
            {
                string exceptionDesc = exception.ToString();
                return;
            }
        }

        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}