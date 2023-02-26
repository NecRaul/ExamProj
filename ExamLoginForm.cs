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
    public partial class ExamLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public User user = new User();
        private IUserServices _userServices { get; set; }
        public ExamLoginForm()
        {
            InitializeComponent();
            _userServices = new UserServices(new Repository<User>(new ExamDbContext()));
            passwordTxt.Properties.PasswordChar = '*';
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            user = _userServices.GetAllUsers().FirstOrDefault(x => x.Username == usernameTxt.Text && x.Password == passwordTxt.Text);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect.", "User doesn't exist.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                ExamHomeForm form = new ExamHomeForm(user);
                form.ShowDialog();
            }
        }
    }
}