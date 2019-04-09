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
    public partial class fReportDepartament : Form
    {
        public fReportDepartament()
        {
            InitializeComponent();
        }

        private void fReportDepartament_Load(object sender, EventArgs e)
        {
            ReportDepartament departament = new ReportDepartament();
            crystalReportViewer1.ReportSource = departament;
        }
    }
}
