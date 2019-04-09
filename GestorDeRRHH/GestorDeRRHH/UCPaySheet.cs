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
    public partial class UCPaySheet : UserControl
    {
        private BusinessPaySheet BPaySheet;
        public UCPaySheet()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BPaySheet = new BusinessPaySheet();
            FillMonth();
            ShowAllPermission(BPaySheet.SeachPaySheetForMonth(cbSearchForMonth.SelectedValue.ToString()));
        }

        private void InsertPaySheet()
        {
            PaySheet paySheet = new PaySheet()
            {
                Month = cbMonth.SelectedValue.ToString(),
                Year = txtYear.Text
            };

            if ( BPaySheet.InsertUpdatePaySheet(paySheet))
            {
                ShowAllPermission(BPaySheet.SeachPaySheetForMonth(cbSearchForMonth.SelectedValue.ToString()));
                EmptyPaySheet();
            }
        }

        private void ShowAllPermission(List<PaySheet> PaySheets)
        {
           lstPaySheet.Items.Clear();

            foreach (PaySheet PaySheet in PaySheets)
            {
                ListViewItem subItems = lstPaySheet.Items.Add(PaySheet.Id.ToString());
                subItems.SubItems.Add(PaySheet.Year.ToString());
                subItems.SubItems.Add(PaySheet.Month.ToString());
                subItems.SubItems.Add(PaySheet.Amount.ToString());
            }
        }

        private void EmptyPaySheet()
        {
            txtYear.Text = "";
        }

        private void FillMonth()
        {
            cbMonth.DataSource = Month.GetListMonth();
            cbMonth.ValueMember = "MonthEnglish"; 
            cbMonth.DisplayMember = "MonthSpanish";

            cbSearchForMonth.DataSource = Month.GetListMonth(); ;
            cbSearchForMonth.ValueMember = "MonthEnglish";
            cbSearchForMonth.DisplayMember = "MonthSpanish";
        }

        private void btnGeneralNomina_Click(object sender, EventArgs e)
        {
            InsertPaySheet();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            EmptyPaySheet();
        }

        private void cbSearchForMonth_SelectionChangeCommitted(object sender, EventArgs e)
        {
            ShowAllPermission(BPaySheet.SeachPaySheetForMonth(cbSearchForMonth.SelectedValue.ToString()));

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            fReportPaySheet reportPaySheet = new fReportPaySheet();
            reportPaySheet.Month = cbSearchForMonth.SelectedValue.ToString();
            reportPaySheet.ShowDialog();
        }
    }
}
