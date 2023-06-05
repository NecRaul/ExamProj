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
    public partial class ExamUserGridForm : DevExpress.XtraEditors.XtraForm
    {
        public User user = new User();
        private IUserServices _userServices { get; set; }
        public ExamUserGridForm()
        {
            InitializeComponent();
            _userServices = new UserServices(new Repository<User>(new ExamDbContext()));
            RefreshUsers();
        }
        public void RefreshUsers()
        {
            gridControl.DataSource = _userServices.GetAllUsers().ToList();
        }
        private void gridControl_DoubleClick(object sender, EventArgs e)
        {
            if (gridView.FocusedRowHandle > -1)
            {
                var selectedUser = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                user = _userServices.GetUserByID(selectedUser);
                ExamUserCRUDForm form = new ExamUserCRUDForm(user);
                form.ShowDialog();
                RefreshUsers();
                user = new User();
            }
            else
                MessageBox.Show("Select a user.", "Incorrect Line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void newBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ExamUserCRUDForm form = new ExamUserCRUDForm(user);
            form.ShowDialog();
            RefreshUsers();
            user = new User();
        }
        private void deleteBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult result;
            if (gridView.FocusedRowHandle > -1)
            {
                result = MessageBox.Show("Are you sure about deleting this user?", "Delete User?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var selectedUser = Convert.ToInt32(gridView.GetFocusedRowCellValue("ID"));
                    _userServices.DeleteUser(selectedUser);
                    RefreshUsers();
                    MessageBox.Show($"User {selectedUser} was deleted.", "User Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Select a user.", "Incorrect Line", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}