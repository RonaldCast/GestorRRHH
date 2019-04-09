using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBusiness;
using CapaEntity;

namespace GestorDeRRHH
{
    public partial class UCUser : UserControl
    {

        private int _Id = 0;
        private BusinessUser BUser;
        private BusinessEmployee BEmployee;
        public UCUser()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BUser = new BusinessUser();
            BEmployee = new BusinessEmployee();
            ShowAllUserTitle(BUser.SelectUser());
            FillCodeEmployee();
        }

        public void FillCodeEmployee()
        {
            cbCodeEmployee.DataSource = BEmployee.SearchEmployee("","Activos","","");
            cbCodeEmployee.ValueMember = "id";
            cbCodeEmployee.DisplayMember = "Code";
        }

        public void InsertUpdateJobTitle()
        {
            User user = new User()
            {
                Id = _Id,
                NameUser = txtUsername.Text,
                Password = txtPass.Text,
                PasswordConfirm = txtPassConfirme.Text,
                IdEmployee = int.Parse(cbCodeEmployee.SelectedValue.ToString())
                
            };

            if (BUser.InsertUpdateUser(user))
            {
                ShowAllUserTitle(BUser.SelectUser());
                EmptyFieldUser();
            }

        }

        private void EmptyFieldUser()
        {
            txtPass.Text = "";
            txtPassConfirme.Text = "";
            txtUsername.Text = "";
            _Id = 0;

        }

       

        private void ShowAllUserTitle(List<User> users)
        {
            lstUsers.Items.Clear();

            foreach (User user in users)
            {
                ListViewItem subItems = lstUsers.Items.Add(user.Id.ToString());
                subItems.SubItems.Add(user.NameUser.ToString());
                subItems.SubItems.Add(user.CodeEmployee.ToString());
            }
        }

        private void FillFielsUser()
        {
            ListViewItem sub = lstUsers.Items[lstUsers.SelectedIndices[0]];
            _Id = int.Parse(sub.SubItems[0].Text);
            txtUsername.Text = sub.SubItems[2].Text;
        }

        private void DeleteUser()
        {
            if (BUser.DeleteUser(_Id))
            {
                EmptyFieldUser();
                ShowAllUserTitle(BUser.SelectUser());
            }
        }

        private void txtSearchUser_TextChanged(object sender, EventArgs e)
        {
            ShowAllUserTitle(BUser.SearchUser(txtSearchUser.Text));
        }

        private void cbCodeEmployee_Click(object sender, EventArgs e)
        {
            FillCodeEmployee();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertUpdateJobTitle();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteUser();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EmptyFieldUser();
        }

        private void lstUsers_Click(object sender, EventArgs e)
        {
            FillFielsUser();
        }
    }
}
