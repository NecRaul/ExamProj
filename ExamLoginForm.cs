using ExamProj.Class;
using ExamProj.Context;
using ExamProj.Repositories;
using ExamProj.Services;
using ExamProj.Services.Interfaces;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExamProj
{
    public partial class ExamLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public User user = new User();
        private IUserServices _userServices { get; set; }
        Regex regex = new Regex(@"^[A-Za-z0-9_-]*$");
        public ExamLoginForm()
        {
            InitializeComponent();
            _userServices = new UserServices(new Repository<User>(new ExamDbContext()));
            passwordTxt.Properties.PasswordChar = '*';
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTxt.Text == "")
            {
                MessageBox.Show("Please enter a username.", "No Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (passwordTxt.Text == "")
            {
                MessageBox.Show("Please enter a password.", "No Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Regex.Match(usernameTxt.Text, "^[A-Za-z0-9_-]*$").Success)
            {
                MessageBox.Show("Please enter a valid username.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (!Regex.Match(passwordTxt.Text, "^[A-Za-z0-9_-]*$").Success)
            {
                MessageBox.Show("Please enter a valid password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            user = _userServices.GetAllUsers().FirstOrDefault(x => x.Username == usernameTxt.Text && x.Password == passwordTxt.Text);
            if (user == null)
            {
                MessageBox.Show("Username or password is incorrect.", "User not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
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