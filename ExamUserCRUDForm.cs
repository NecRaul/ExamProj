using ExamProj.Class;
using ExamProj.Context;
using ExamProj.Repositories;
using ExamProj.Services;
using ExamProj.Services.Interfaces;
using System;
using System.Windows.Forms;

namespace ExamProj
{
    public partial class ExamUserCRUDForm : DevExpress.XtraEditors.XtraForm
    {
        public User user = new User();
        private IUserServices _userServices { get; set; }
        public ExamUserCRUDForm(User user)
        {
            InitializeComponent();
            this.user = user;
            _userServices = new UserServices(new Repository<User>(new ExamDbContext()));
            usernameTxt.Text = user.Username;
            passwordTxt.Text = user.Password;
            teacherChk.Checked = user.IsTeacher;
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            user.Username = usernameTxt.Text;
            user.Password = passwordTxt.Text;
            user.IsTeacher = teacherChk.Checked;
            if (user.Username == "")
            {
                MessageBox.Show("Username can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (user.Password == "")
            {
                MessageBox.Show("Password can't be empty!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (user.ID != 0)
            {
                try
                {
                    _userServices.UpdateUser(user);
                    MessageBox.Show("User was updated.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    _userServices.InsertUser(user);
                    MessageBox.Show("User was saved.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    MessageBox.Show("Unexpected error.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}