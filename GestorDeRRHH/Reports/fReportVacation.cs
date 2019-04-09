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
    public partial class fReportVacation : Form
    {
        public string Year;

        public fReportVacation()
        {
            InitializeComponent();
        }

        private void fReportVacation_Load(object sender, EventArgs e)
        {
            ReportVacation reportVacation = new ReportVacation();
            reportVacation.SetParameterValue("@name", Year);
            crystalReportViewer1.ReportSource = reportVacation;
        }
    }
}
