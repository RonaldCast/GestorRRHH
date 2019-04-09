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
using Reports;

namespace GestorDeRRHH
{
    public partial class UCEmployee : UserControl
    {

        private int _Id = 0;
        private string _Status = "";
        private BusinessEmployee BEmployee;
        private BusinessJobTitle BJobTitle;
        private BusinessDepartament BDepartament;
        public UCEmployee()
        {
            InitializeComponent();
            Init();

        }

        public void Init()
        {
            BEmployee = new BusinessEmployee();
            BJobTitle = new BusinessJobTitle();
            BDepartament = new BusinessDepartament();
            FillDepartament();
            FillJobTitle();
            FillDepartamentFilter();
            FillMonth();
            FilterEmployees();

        }

        public void FillDepartament()
        {
         
            cbDepart.DataSource = BDepartament.SelectDepartament();
            cbDepart.ValueMember = "id";
            cbDepart.DisplayMember = "name";
        }

        public void FillJobTitle()
        {
            cbJobTitle.DataSource = BJobTitle.SelectJobTitle();
            cbJobTitle.ValueMember = "id";
            cbJobTitle.DisplayMember = "Job";
        }

        public void InsertUpdateEmployee()
        {
            Employee Employee = new Employee()
            {
                Id = _Id,
                Name = txtName.Text,
                LastName = txtLastName.Text,
                DateEntry = dtpDateEntry.Value,
                Phone = txtPhone.Text,
               
            };

            try
            {
                 Employee.Salary = Convert.ToInt32(txtSalary.Text);
                 Employee.IdDepartamento = Convert.ToInt32(cbDepart.SelectedValue.ToString());
                 Employee.IdJobTitle = Convert.ToInt32(cbJobTitle.SelectedValue.ToString());
                 Employee.Status = "Activo";

                 if (BEmployee.InsertUpdateEmployee(Employee))
                 {
                    FilterEmployees();

                     EmptyFieldEmployee();
                 }

            }
            catch (Exception)
            {
                
                MessageBox.Show("El valor ingresado es incorrecto","Error");
              
            }
        }

        private void EmptyFieldEmployee()
        {
            _Id = 0;
            txtName.Text = "";
            txtLastName.Text = "";
            txtPhone.Text = "";
            txtSalary.Text = "";

        }

        private void ShowAllEmployee(List<Employee> Employees)
        {
            lstEmployees.Items.Clear();

            foreach (Employee Employee in Employees)
            {
                ListViewItem subItems = lstEmployees.Items.Add(Employee.Id.ToString());
                subItems.SubItems.Add(Employee.Code.ToString());
                subItems.SubItems.Add(Employee.Name.ToString());
                subItems.SubItems.Add(Employee.LastName.ToString());
                subItems.SubItems.Add(Employee.Phone.ToString());
                subItems.SubItems.Add(Employee.Salary.ToString());
                subItems.SubItems.Add(Employee.Departamento.ToString());
                subItems.SubItems.Add(Employee.JobTitle.ToString());
                subItems.SubItems.Add(Employee.Status.ToString());
                subItems.SubItems.Add(Employee.DateEntry.ToString("dd/MM/yyyy"));

            }
        }
        private void FillMonth()
        {

            cbMoth.DataSource = Month.GetListMonth();
            cbMoth.ValueMember = "MonthEnglish";
            cbMoth.DisplayMember = "MonthSpanish";
        }
        private  void FillDepartamentFilter()
        {
            List<Departament> departaments = BDepartament.SelectDepartament();

            departaments.Insert(0 ,new Departament()
            {
                Name = "Todos",
                Id = 0
            });

            cbFilterDepart.DataSource = departaments;
            cbFilterDepart.ValueMember = "id";
            cbFilterDepart.DisplayMember = "name";
        }

        private void FilterEmployees()
        {
            ShowAllEmployee(
                       BEmployee.SearchEmployee(
                           txtSearch.Text, _Status,
                           cbMoth.SelectedValue.ToString(),
                       BDepartament.SelectDepartamentForID(Convert.ToInt32(cbFilterDepart.SelectedValue)).Name
                       ));
        }


        private void FillFielsEmployee()
        {
            ListViewItem sub = lstEmployees.Items[lstEmployees.SelectedIndices[0]];
            _Id = int.Parse(sub.SubItems[0].Text);
            txtName.Text = sub.SubItems[2].Text;
            txtLastName.Text = sub.SubItems[3].Text;
            txtPhone.Text = sub.SubItems[4].Text;
            txtSalary.Text = sub.SubItems[5].Text;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertUpdateEmployee();
        }

        private void lstEmployees_Click(object sender, EventArgs e)
        {
            FillFielsEmployee();
        }

        private void cbJobTitle_Click(object sender, EventArgs e)
        {
            FillJobTitle();
        }

        private void cbDepart_Click(object sender, EventArgs e)
        {
            FillDepartament();
        }

        private void gBRadioStatus_CursorChanged(object sender, EventArgs e)
        {
            MessageBox.Show(gBRadioStatus.Text, "");
          
        }

        private void cbMoth_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void cbFilterDepart_Click(object sender, EventArgs e)
        {
            FillDepartamentFilter();
            FilterEmployees();
        }

        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {
            _Status = "Activos";
            FilterEmployees();
        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            _Status = "Inactivo";
            FilterEmployees();
        }

        private void rbAllActIna_CheckedChanged(object sender, EventArgs e)
        {
            _Status = "";
            FilterEmployees();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            FilterEmployees();
        }

       
        private void cbFilterDepart_SelectionChangeCommitted(object sender, EventArgs e)
        {
            FilterEmployees();
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            EmptyFieldEmployee();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReportEmployee reportEmployee = new fReportEmployee()
            {
                name = txtSearch.Text,
                Month = cbMoth.SelectedValue.ToString(),
                status = _Status,
                departament = BDepartament.SelectDepartamentForID(Convert.ToInt32(cbFilterDepart.SelectedValue)).Name
            };

            reportEmployee.ShowDialog();
         
        }
    }
}
