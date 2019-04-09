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
    public partial class UCPermission : UserControl
    {

        private int _IdPermission = 0;
        private int _IdLicense = 0;
        private BusinessPermission BPermission;
        private BusinessEmployee BEmployee;
        private BusinessLicense BLicense;

        public UCPermission()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            BPermission = new BusinessPermission();
            BEmployee = new BusinessEmployee();
            BLicense = new BusinessLicense();     
            ShowAllPermission(BPermission.SelectPermission());
            FillCodeEmployeePer();
            FillCodeEmployeeLic();
            ShowAllLicense(BLicense.SelectLicense());
        }
        #region

        public void InsertUpdatePermission()
        {
            Permission Permission  = new Permission()
            {
                Id = _IdPermission,
                Comment  = txtCommentPer.Text,
                DateSince = dtpSincePer.Value,
                DateUntil = dtpUntilPer.Value,
                IdEmployee = Convert.ToInt32(cbCodEmployeePer.SelectedValue)
            };

            if (BPermission.InsertUpdatePermission(Permission))
            {
                ShowAllPermission(BPermission.SelectPermission());
                EmptyFieldPermission ();
            }

        }

        private void FillCodeEmployeePer()
        {
            cbCodEmployeePer.DataSource = BEmployee.SearchEmployee("", "Activos", "", "");
            cbCodEmployeePer.ValueMember = "id";
            cbCodEmployeePer.DisplayMember = "code";
        }

        private void FillFielsPermission()
        {
            ListViewItem sub = lstPermission.Items[lstPermission.SelectedIndices[0]];
            _IdPermission  = int.Parse(sub.SubItems[0].Text);
            txtCommentPer.Text = sub.SubItems[4].Text;

        }

        private void DeletePermission()
        {
            if (BPermission.DeletePermission(_IdPermission))
            {
                EmptyFieldPermission ();
                ShowAllPermission(BPermission.SelectPermission());
            }
        }


        private void EmptyFieldPermission ()
        {
            txtCommentPer.Text = "";
            _IdPermission  = 0;
        }

        private void ShowAllPermission(List<Permission> Permissions)
        {
            lstPermission.Items.Clear();

            foreach (Permission Permission  in Permissions )
            {
                ListViewItem subItems = lstPermission.Items.Add(Permission.Id.ToString());
                subItems.SubItems.Add(Permission.CodeEmployee.ToString());
                subItems.SubItems.Add(Permission.DateSince.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(Permission.DateUntil.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(Permission.Comment.ToString());
            }
        }

        private void btnSavePer_Click(object sender, EventArgs e)
        {
            InsertUpdatePermission();
        }

        private void btnDeletePer_Click(object sender, EventArgs e)
        {
            DeletePermission();
        }

        private void lstPermission_Click(object sender, EventArgs e)
        {
            FillFielsPermission();
        }
        #endregion

        #region
        public void InsertUpdateLicense()
        {
            Licenses license = new Licenses()
            {
                Id = _IdLicense,
                Comment = txtCommentLic.Text,
                DateSince = dtpSinceLic.Value,
                DateUntil = dtpUntilLic.Value,
                IdEmployee = Convert.ToInt32(cbCodEmployeeLic.SelectedValue),
                Reason = txtReason.Text
               
                
            };

            if (BLicense.InsertUpdateLicense(license))
            {
                ShowAllLicense(BLicense.SelectLicense());
                EmptyFieldLicense();
            }

        }

        private void FillCodeEmployeeLic()
        {
            cbCodEmployeeLic.DataSource = BEmployee.SearchEmployee("", "Activos", "", "");
            cbCodEmployeeLic.ValueMember = "id";
            cbCodEmployeeLic.DisplayMember = "code";
        }

        private void FillFielsLicense()
        {
            ListViewItem sub = lstLicense.Items[lstLicense.SelectedIndices[0]];
            _IdLicense = int.Parse(sub.SubItems[0].Text);
            txtCommentLic.Text = sub.SubItems[4].Text;
            txtReason.Text = sub.SubItems[5].Text;

        }

        private void DeleteLicense()
        {
            if (BLicense.DeleteLicense(_IdLicense))
            {
                EmptyFieldLicense();
                ShowAllLicense(BLicense.SelectLicense());
            }
        }


        private void EmptyFieldLicense()
        {
            txtCommentLic.Text = "";
            txtReason.Text = "";
            _IdLicense = 0;
        }

        private void ShowAllLicense(List<Licenses> licenses)
        {
            lstLicense.Items.Clear();

            foreach (Licenses License in licenses)
            {
                ListViewItem subItems = lstLicense.Items.Add(License.Id.ToString());
                subItems.SubItems.Add(License.CodeEmployee.ToString());
                subItems.SubItems.Add(License.DateSince.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(License.DateUntil.ToString("dd/MM/yyyy"));
                subItems.SubItems.Add(License.Comment.ToString());
                subItems.SubItems.Add(License.Reason.ToString());
            }
        }
        #endregion

        private void btnSaveLic_Click(object sender, EventArgs e)
        {
            InsertUpdateLicense();
        }

        private void btnDeleteLic_Click(object sender, EventArgs e)
        {
            DeleteLicense();

        }

        private void lstLicense_Click(object sender, EventArgs e)
        {
            FillFielsLicense();
        }

        private void btnReportPer_Click(object sender, EventArgs e)
        {
            fReportPermission reportPermission = new fReportPermission();
            reportPermission.ShowDialog();
        }

        private void btnReportLic_Click(object sender, EventArgs e)
        {
            fReportLicense fReportLicense = new fReportLicense();
            fReportLicense.ShowDialog();
         
        }

        private void cbCodEmployeePer_Click(object sender, EventArgs e)
        {
            FillCodeEmployeePer();
        }

        private void cbCodEmployeeLic_Click(object sender, EventArgs e)
        {
            FillCodeEmployeeLic();
        }
    }

}
