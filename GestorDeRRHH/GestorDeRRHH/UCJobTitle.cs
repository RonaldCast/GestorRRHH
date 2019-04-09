using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntity;
using CapaBusiness;
using Reports;

namespace GestorDeRRHH
{
    public partial class UCJobTitle : UserControl
    {
        private int _IdJob = 0;
        private int _IdDepartament = 0;
        private BusinessJobTitle BJobTitle;
        private BusinessDepartament BDepartament;
        private BusinessEmployee BEmployee;
        private CodeObject _Code;
        public UCJobTitle()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BJobTitle = new BusinessJobTitle();
            BDepartament = new BusinessDepartament();
            BEmployee = new BusinessEmployee();
            _Code = new CodeObject();
            ShowAllJobTitle(BJobTitle.SelectJobTitle());
            ShowAllDepartament(BDepartament.SelectDepartament());
            FillCodeEmployee();
        }

        //region Job title
        #region 
        public void InsertUpdateJobTitle()
        {
            JobTitle Job = new JobTitle()
            {
                Id = _IdJob,
                Job = txtJob.Text
            };

            Job.CodeJob = _Code.CreateCode(Job.Job);

            if (BJobTitle.InsertUpdateJobTitle(Job))
            {
                ShowAllJobTitle(BJobTitle.SelectJobTitle());
                EmptyFieldJob();
            }
            
        }

        private void EmptyFieldJob()
        {
            txtJob.Text = "";
            _IdJob = 0;
        }

        private void btnSaveUpdate_Click(object sender, EventArgs e)
        {
            InsertUpdateJobTitle();
        }

        private void ShowAllJobTitle(List<JobTitle> jobs)
        {
            lstJobTitle.Items.Clear();

            foreach (JobTitle job in jobs)
            {
                ListViewItem subItems = lstJobTitle.Items.Add(job.Id.ToString());
                subItems.SubItems.Add(job.CodeJob.ToString());
                subItems.SubItems.Add(job.Job.ToString());
            }
        }
        private void FillFielsJobTitle()
        {
            ListViewItem sub = lstJobTitle.Items[lstJobTitle.SelectedIndices[0]];
            _IdJob = int.Parse(sub.SubItems[0].Text);
            txtJob.Text = sub.SubItems[2].Text;

        }

        private void DeleteJobTitle()
        {
            if (BJobTitle.DeleteJobTitle(_IdJob))
            {
                EmptyFieldJob();
                ShowAllJobTitle(BJobTitle.SelectJobTitle());
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteJobTitle();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            ShowAllJobTitle(BJobTitle.SearchJobTitle(txtSearchJob.Text));
        }

        private void lstJobTitle_Click(object sender, EventArgs e)
        {
            FillFielsJobTitle();
        }
        #endregion

     

        #region 
        public void InsertUpdateDepartament()
        {
            Departament Departament = new Departament()
            {
                Id = _IdDepartament,
                Name = txtName.Text,
                Mandated =Convert.ToInt32(cbCodeEmployee.SelectedValue.ToString())
                
            };

            Departament.Code = _Code.CreateCode(Departament.Name);

            if (BDepartament.InsertUpdateDepartament(Departament))
            {
                ShowAllDepartament(BDepartament.SelectDepartament());
                EmptyFieldDepartament();
            }

        }

       public void FillCodeEmployee()
        {
            cbCodeEmployee.DataSource = BEmployee.SearchEmployee("", "Activos", "", "");
            cbCodeEmployee.ValueMember = "Id";
            cbCodeEmployee.DisplayMember = "Code";
        }

        private void EmptyFieldDepartament()
        {
            txtName.Text = "";
            _IdDepartament = 0;
        }



        private void ShowAllDepartament(List<Departament> Departaments)
        {
            lstDepart.Items.Clear();

            foreach (Departament Departament in Departaments)
            {
                ListViewItem subItems = lstDepart.Items.Add(Departament.Id.ToString());
                subItems.SubItems.Add(Departament.Code.ToString());
                subItems.SubItems.Add(Departament.Name.ToString());
                subItems.SubItems.Add(Departament.CodeEmployee.ToString());
            }
        }
        private void FillFielsDepartament()
        {
            ListViewItem sub = lstDepart.Items[lstDepart.SelectedIndices[0]];
            _IdDepartament = int.Parse(sub.SubItems[0].Text);
            txtName.Text = sub.SubItems[2].Text;

        }

 

        private void DeleteDepartament()
        {
            if (BDepartament.DeleteDepartament(_IdDepartament))
            {
                EmptyFieldDepartament();
                ShowAllDepartament(BDepartament.SelectDepartament());
            }
        }

        private void btnSaveDepart_Click(object sender, EventArgs e)
        {
            InsertUpdateDepartament();
        }

        private void btnDeleteDepart_Click(object sender, EventArgs e)
        {
            DeleteDepartament();
        }

        private void txtSearchDepart_TextChanged(object sender, EventArgs e)
        {
            ShowAllDepartament(BDepartament.SearchDepartament(txtSearchDepart.Text));
        }

        private void lstDepart_Click(object sender, EventArgs e)
        {
            FillFielsDepartament();
        }

       

        private void btnReportJobTitle_Click(object sender, EventArgs e)
        {
            fReportJobTitle fReportJobTitle = new fReportJobTitle();
            fReportJobTitle.ShowDialog();
        }

        private void cbCodeEmployee_Click(object sender, EventArgs e)
        {
            FillCodeEmployee();
        }

        private void btnReportDep_Click(object sender, EventArgs e)
        {
            fReportDepartament reportDepartament = new fReportDepartament();
            reportDepartament.ShowDialog();
        }

        #endregion
    }
}
