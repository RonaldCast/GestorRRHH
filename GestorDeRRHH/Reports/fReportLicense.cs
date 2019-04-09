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
    public partial class fReportLicense : Form
    {
        public fReportLicense()
        {
            InitializeComponent();
        }

        private void fReportLicense_Load(object sender, EventArgs e)
        {
            ReportLicense reportLicense = new ReportLicense();
            crystalReportViewer1.ReportSource = reportLicense;
        }
    }
}
