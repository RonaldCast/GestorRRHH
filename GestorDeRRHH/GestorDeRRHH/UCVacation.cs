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
    public partial class UCVacation : UserControl
    {

        private int _IdVacation = 0;
        private int _IdExist= 0;
        private BusinessVacation BVacation;
        private BusinessEmployee BEmployee;
        private BusinessEmployeeExist BEmployeeExist;
        public UCVacation()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BVacation = new BusinessVacation();
            BEmployee = new BusinessEmployee();
            BEmployeeExist = new BusinessEmployeeExist();
            ShowAllVacation(BVacation.SelectVacation());
            FillCodeEmployeeVac();
            FillCodeEmployeeExist();
            FillTypeExist();
            FillMonth();
           ShowAllEmployeeExist(BEmployeeExist.SelectEmployeeExist());
        }
        #region
        public void InsertUpdateVacation()
        {
            Vacation vacation = new Vacation()
            {
                Id = _IdVacation,
                Comment = txtComment.Text,
                DateSince = dtpSinceVac.Value,
                DateUntil = dtpUntilVac.Value,
                IdEmployee = Convert.ToInt32(cbCodEmployeeVac.SelectedValue),
                Year = dtpSinceVac.Value.Year.ToString()


            };

            if (BVacation.InsertUpdateVacation(vacation))
            {
                ShowAllVacation(BVacation.SelectVacation());
                EmptyFieldVacation();
            }

        }

        private void FillFielsVacation()
        {
            ListViewItem sub = lstVacation.Items[lstVacation.SelectedIndices[0]];
            _IdVacation = int.Parse(sub.SubItems[0].Text);
            txtComment.Text = sub.SubItems[4].Text;
        }

        private void EmptyFieldVacation()
        {
            txtComment.Text = "";
            _IdVacation = 0;
        }

        private void FillCodeEmployeeVac()
        {
            cbCodEmployeeVac.DataSource = BEmployee.SearchEmployee("", "Activos", "", "");
            cbCodEmployeeVac.ValueMember = "id";
            cbCodEmployeeVac.DisplayMember = "code";
        }

        private void ShowAllVacation(List<Vacation> vacations)
        {
            lstVacation.Items.Clear();

            foreach (Vacation vacation in vacations)
            {
                ListViewItem subItems = lstVacation.Items.Add(vacation.Id.ToString());
                subItems.SubItems.Add(vacation.CodeEmployee.ToString());
                subItems.SubItems.Add(vacation.DateSince.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(vacation.DateUntil.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(vacation.Comment.ToString());
                subItems.SubItems.Add(vacation.Year.ToString());
            }
        }


        private void txtSearchYear_TextChanged(object sender, EventArgs e)
        {
            ShowAllVacation(BVacation.SeachVacationForYear(txtSearchYear.Text));
        }

        private void btnClearVac_Click(object sender, EventArgs e)
        {
            EmptyFieldVacation();
        }

        private void btnSaveVac_Click(object sender, EventArgs e)
        {
            InsertUpdateVacation();
        }
        private void lstVacation_Click(object sender, EventArgs e)
        {
            FillFielsVacation();
        }

        private void cbCodEmployeeVac_Click(object sender, EventArgs e)
        {
            FillCodeEmployeeVac();
        }

        #endregion

        //Salidas Employe

        #region
        public void InsertUpdateEmployeeExist()
        {
            EmployeeExist EmployeeExist = new EmployeeExist()
            {
                Id = _IdVacation,
                Reason = txtReason.Text,
                DateExist = dtpDateExist.Value,
                IdEmployee = Convert.ToInt32(cbCodEmployeeExist.SelectedValue),
                TypeExist = cbType.SelectedValue.ToString()

            };

            if (BEmployeeExist.InsertUpdateEmployeeExist(EmployeeExist))
            {
                ShowAllEmployeeExist(BEmployeeExist.SelectEmployeeExist());
                EmptyFieldEmployeeExist();
            }

        }

        private void FillTypeExist()
        {
            string[] type = new string[]
            {
                "Renuncia", "Despido", "Desahucio"
            };
            cbType.DataSource = type;
        }

        private void FillFielsEmployeeExist()
        {
            ListViewItem sub = lstVacation.Items[lstVacation.SelectedIndices[0]];
            _IdVacation = int.Parse(sub.SubItems[0].Text);
            txtComment.Text = sub.SubItems[4].Text;
        }

        private void EmptyFieldEmployeeExist()
        {
            txtComment.Text = "";
            _IdVacation = 0;
        }

        private void FillCodeEmployeeExist()
        {
            cbCodEmployeeExist.DataSource = BEmployee.SearchEmployee("", "Activos", "", "");
            cbCodEmployeeExist.ValueMember = "id";
            cbCodEmployeeExist.DisplayMember = "code";
        }

        private void ShowAllEmployeeExist(List<EmployeeExist> EmployeeExists)
        {
            lstExist.Items.Clear();

            foreach (EmployeeExist EmployeeExist in EmployeeExists)
            {
                ListViewItem subItems = lstExist.Items.Add(EmployeeExist.Id.ToString());
                subItems.SubItems.Add(EmployeeExist.CodeEmployee.ToString());
                subItems.SubItems.Add(EmployeeExist.TypeExist.ToString());
                subItems.SubItems.Add(EmployeeExist.DateExist.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(EmployeeExist.Reason.ToString());
            }

        }

        private void FillMonth()
        {
            cbMonth.DataSource = Month.GetListMonth();
            cbMonth.ValueMember = "MonthEnglish";
            cbMonth.DisplayMember = "MonthSpanish";
        }

        private void btnSaveExist_Click(object sender, EventArgs e)
        {
            InsertUpdateEmployeeExist();

        }

        private void btnClearExist_Click(object sender, EventArgs e)
        {
            EmptyFieldEmployeeExist();
        }

        private void cbCodEmployeeExist_Click(object sender, EventArgs e)
        {
            FillCodeEmployeeExist();
        }



        #endregion

        private void cbMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowAllEmployeeExist(BEmployeeExist.SeachEmployeeExistForMonth(cbMonth.SelectedValue.ToString()));
        }

        private void btnReportVac_Click(object sender, EventArgs e)
        {
            fReportVacation reportVacation = new fReportVacation();
            reportVacation.Year = txtSearchYear.Text;
            reportVacation.ShowDialog();
        }

        private void btnReportExist_Click(object sender, EventArgs e)
        {
            fReportExist fReportExist = new fReportExist();
            fReportExist.Month = cbMonth.SelectedValue.ToString();
            fReportExist.ShowDialog();
        }
    }

}
