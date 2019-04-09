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
    public partial class fReportJobTitle : Form
    {
        public fReportJobTitle()
        {
            InitializeComponent();
        }

        private void fReportJobTitle_Load(object sender, EventArgs e)
        {
            ReportJobTitle reportJobTitle = new ReportJobTitle();
            crystalReportViewer1.ReportSource = reportJobTitle;
        }
    }
}
