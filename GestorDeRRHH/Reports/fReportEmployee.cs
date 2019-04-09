using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reports
{
    public partial class fReportEmployee : Form
    {
        public string name;
        public string status;
        public string Month;
        public string departament;

        public fReportEmployee()
        {
            InitializeComponent();
        }

        private void ReportEmployee()
        {
            ReportEmployee reportEmployee = new ReportEmployee();
            reportEmployee.SetParameterValue("@Name", name);
            reportEmployee.SetParameterValue("@Status", status);
            reportEmployee.SetParameterValue("@Month", Month);
            reportEmployee.SetParameterValue("@Departament", departament);
            crystalReportViewer1.ReportSource = reportEmployee;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            ReportEmployee();
        }
    }
}
