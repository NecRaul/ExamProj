using ExamProj.Class;
using System;

namespace ExamProj
{
    public partial class ExamHomeForm : DevExpress.XtraEditors.XtraForm
    {
        public User user = new User();
        public ExamHomeForm(User user)
        {
            InitializeComponent();
            this.user = user;
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
            ExamMainForm form = new ExamMainForm(user);
            try
            {
                form.ShowDialog();
            }
            catch (Exception)
            {
                return;
            }
        }
        private void logOutBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}