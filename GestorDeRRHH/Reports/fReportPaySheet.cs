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
    public partial class fReportPaySheet : Form
    {
        public string Month;
        public fReportPaySheet()
        {
            InitializeComponent();
        }

        private void fReportPaySheet_Load(object sender, EventArgs e)
        {
            ReportPaySheet reportPaySheet = new ReportPaySheet();
            reportPaySheet.SetParameterValue("@Month", Month);
            crystalReportViewer1.ReportSource = reportPaySheet;
        }
    }
}
