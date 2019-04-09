using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorDeRRHH
{
    public partial class fPrincipal : Form
    {
        public fPrincipal()
        {
            InitializeComponent();
            pnlClick.Height = btnEmployee.Height;
            this.Size = new Size(1356, 753);
            pnlContianer.Size = new Size(1042, 705);
            ucEmployee2.Size = new Size(1142, 705);
            ucJobTitle2.Size = new Size(1142, 705);
            ucPermission1.Size = new Size(1142, 705);
            ucVacation1.Size = new Size(1142, 705);
            ucPaySheet1.Size = new Size(1142, 705);
            ucUser1.Size = new Size(1142, 705);
            ucEmployee2.BringToFront();

        }


        private void btnEmployee_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnEmployee.Height;
            ucEmployee2.BringToFront();
            pnlClick.Top = btnEmployee.Top;
        }

        private void btnDepartment_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnDepartJob.Height;
            ucJobTitle2.BringToFront();
            pnlClick.Top = btnDepartJob.Top;
        }

     

        private void btnPermit_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnPermit.Height;
            pnlClick.Top = btnPermit.Top;
            ucPermission1.BringToFront();
        }



        private void btnVacation_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnEmployee.Height;
            pnlClick.Top = btnVacation.Top;
            ucVacation1.BringToFront();
        }

        private void btnPaySheet_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnPaySheet.Height;
            pnlClick.Top = btnPaySheet.Top;
            ucPaySheet1.BringToFront();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            pnlClick.Height = btnUser.Height;
            pnlClick.Top = btnUser.Top;
            ucUser1.BringToFront();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Exist_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }
    }
}
