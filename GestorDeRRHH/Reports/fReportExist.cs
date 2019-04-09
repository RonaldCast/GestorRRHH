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
    public partial class fReportExist : Form
    {
        public string Month;
        public fReportExist()
        {
            InitializeComponent();
        }

        private void fReportExist_Load(object sender, EventArgs e)
        {
            ReportExist reportExist = new ReportExist();
            reportExist.SetParameterValue("@Month", Month);
            crystalReportViewer1.ReportSource = reportExist;
        }
    }
}
