namespace GestorDeRRHH
{
    partial class fPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnPaySheet = new System.Windows.Forms.Button();
            this.btnVacation = new System.Windows.Forms.Button();
            this.btnPermit = new System.Windows.Forms.Button();
            this.btnDepartJob = new System.Windows.Forms.Button();
            this.pnlClick = new System.Windows.Forms.Panel();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Exist = new System.Windows.Forms.Label();
            this.lbExits = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pnlContianer = new System.Windows.Forms.Panel();
            this.ucPaySheet1 = new GestorDeRRHH.UCPaySheet();
            this.ucVacation1 = new GestorDeRRHH.UCVacation();
            this.ucPermission1 = new GestorDeRRHH.UCPermission();
            this.ucJobTitle2 = new GestorDeRRHH.UCJobTitle();
            this.ucEmployee2 = new GestorDeRRHH.UCEmployee();
            this.ucUser1 = new GestorDeRRHH.UCUser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlContianer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Controls.Add(this.btnPaySheet);
            this.panel1.Controls.Add(this.btnVacation);
            this.panel1.Controls.Add(this.btnPermit);
            this.panel1.Controls.Add(this.btnDepartJob);
            this.panel1.Controls.Add(this.pnlClick);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 753);
            this.panel1.TabIndex = 0;
            // 
            // btnUser
            // 
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(12, 535);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(302, 67);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "        Usuarios";
            this.btnUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnPaySheet
            // 
            this.btnPaySheet.FlatAppearance.BorderSize = 0;
            this.btnPaySheet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaySheet.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnPaySheet.ForeColor = System.Drawing.Color.White;
            this.btnPaySheet.Location = new System.Drawing.Point(12, 462);
            this.btnPaySheet.Name = "btnPaySheet";
            this.btnPaySheet.Size = new System.Drawing.Size(302, 67);
            this.btnPaySheet.TabIndex = 16;
            this.btnPaySheet.Text = "        Nóminas";
            this.btnPaySheet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaySheet.UseVisualStyleBackColor = true;
            this.btnPaySheet.Click += new System.EventHandler(this.btnPaySheet_Click);
            // 
            // btnVacation
            // 
            this.btnVacation.FlatAppearance.BorderSize = 0;
            this.btnVacation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVacation.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnVacation.ForeColor = System.Drawing.Color.White;
            this.btnVacation.Location = new System.Drawing.Point(12, 389);
            this.btnVacation.Name = "btnVacation";
            this.btnVacation.Size = new System.Drawing.Size(302, 67);
            this.btnVacation.TabIndex = 14;
            this.btnVacation.Text = "        Vacaciones/salida";
            this.btnVacation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVacation.UseVisualStyleBackColor = true;
            this.btnVacation.Click += new System.EventHandler(this.btnVacation_Click);
            // 
            // btnPermit
            // 
            this.btnPermit.FlatAppearance.BorderSize = 0;
            this.btnPermit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermit.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnPermit.ForeColor = System.Drawing.Color.White;
            this.btnPermit.Location = new System.Drawing.Point(12, 316);
            this.btnPermit.Name = "btnPermit";
            this.btnPermit.Size = new System.Drawing.Size(302, 67);
            this.btnPermit.TabIndex = 12;
            this.btnPermit.Text = "        Permisos/Licencia";
            this.btnPermit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPermit.UseVisualStyleBackColor = true;
            this.btnPermit.Click += new System.EventHandler(this.btnPermit_Click);
            // 
            // btnDepartJob
            // 
            this.btnDepartJob.FlatAppearance.BorderSize = 0;
            this.btnDepartJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartJob.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnDepartJob.ForeColor = System.Drawing.Color.White;
            this.btnDepartJob.Location = new System.Drawing.Point(12, 243);
            this.btnDepartJob.Name = "btnDepartJob";
            this.btnDepartJob.Size = new System.Drawing.Size(302, 67);
            this.btnDepartJob.TabIndex = 10;
            this.btnDepartJob.Text = "        Depart/Cargo";
            this.btnDepartJob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDepartJob.UseVisualStyleBackColor = true;
            this.btnDepartJob.Click += new System.EventHandler(this.btnDepartment_Click);
            // 
            // pnlClick
            // 
            this.pnlClick.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.pnlClick.Location = new System.Drawing.Point(0, 176);
            this.pnlClick.Name = "pnlClick";
            this.pnlClick.Size = new System.Drawing.Size(10, 67);
            this.pnlClick.TabIndex = 2;
            // 
            // btnEmployee
            // 
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Questrial", 13.2F);
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.Location = new System.Drawing.Point(12, 176);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(302, 67);
            this.btnEmployee.TabIndex = 3;
            this.btnEmployee.Text = "        Empleados";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("FontAwesome", 59.8F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(99, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 100);
            this.label6.TabIndex = 9;
            this.label6.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Questrial", 30F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(78, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 52);
            this.label2.TabIndex = 8;
            this.label2.Text = "RRHH";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.Exist);
            this.panel2.Controls.Add(this.lbExits);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(314, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1042, 57);
            this.panel2.TabIndex = 1;
            // 
            // Exist
            // 
            this.Exist.AutoSize = true;
            this.Exist.Font = new System.Drawing.Font("FontAwesome", 20.8F);
            this.Exist.ForeColor = System.Drawing.Color.White;
            this.Exist.Location = new System.Drawing.Point(18, 9);
            this.Exist.Name = "Exist";
            this.Exist.Size = new System.Drawing.Size(48, 35);
            this.Exist.TabIndex = 2;
            this.Exist.Text = "";
            this.Exist.Click += new System.EventHandler(this.Exist_Click);
            // 
            // lbExits
            // 
            this.lbExits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbExits.AutoSize = true;
            this.lbExits.Font = new System.Drawing.Font("FontAwesome", 14F);
            this.lbExits.ForeColor = System.Drawing.Color.White;
            this.lbExits.Location = new System.Drawing.Point(988, 19);
            this.lbExits.Name = "lbExits";
            this.lbExits.Size = new System.Drawing.Size(29, 24);
            this.lbExits.TabIndex = 7;
            this.lbExits.Text = "";
            this.lbExits.Click += new System.EventHandler(this.label5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(955, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pnlContianer
            // 
            this.pnlContianer.BackColor = System.Drawing.Color.White;
            this.pnlContianer.Controls.Add(this.ucPaySheet1);
            this.pnlContianer.Controls.Add(this.ucVacation1);
            this.pnlContianer.Controls.Add(this.ucPermission1);
            this.pnlContianer.Controls.Add(this.ucJobTitle2);
            this.pnlContianer.Controls.Add(this.ucEmployee2);
            this.pnlContianer.Controls.Add(this.ucUser1);
            this.pnlContianer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlContianer.Location = new System.Drawing.Point(314, 48);
            this.pnlContianer.Name = "pnlContianer";
            this.pnlContianer.Size = new System.Drawing.Size(1042, 705);
            this.pnlContianer.TabIndex = 2;
            // 
            // ucPaySheet1
            // 
            this.ucPaySheet1.BackColor = System.Drawing.Color.White;
            this.ucPaySheet1.Location = new System.Drawing.Point(0, 31);
            this.ucPaySheet1.Name = "ucPaySheet1";
            this.ucPaySheet1.Size = new System.Drawing.Size(1526, 810);
            this.ucPaySheet1.TabIndex = 4;
            // 
            // ucVacation1
            // 
            this.ucVacation1.BackColor = System.Drawing.Color.White;
            this.ucVacation1.Location = new System.Drawing.Point(0, 31);
            this.ucVacation1.Name = "ucVacation1";
            this.ucVacation1.Size = new System.Drawing.Size(1526, 810);
            this.ucVacation1.TabIndex = 3;
            // 
            // ucPermission1
            // 
            this.ucPermission1.BackColor = System.Drawing.Color.White;
            this.ucPermission1.Location = new System.Drawing.Point(0, 31);
            this.ucPermission1.Name = "ucPermission1";
            this.ucPermission1.Size = new System.Drawing.Size(1526, 810);
            this.ucPermission1.TabIndex = 2;
            // 
            // ucJobTitle2
            // 
            this.ucJobTitle2.BackColor = System.Drawing.Color.White;
            this.ucJobTitle2.Location = new System.Drawing.Point(0, 31);
            this.ucJobTitle2.Name = "ucJobTitle2";
            this.ucJobTitle2.Size = new System.Drawing.Size(1526, 810);
            this.ucJobTitle2.TabIndex = 1;
            // 
            // ucEmployee2
            // 
            this.ucEmployee2.BackColor = System.Drawing.Color.White;
            this.ucEmployee2.Location = new System.Drawing.Point(0, 31);
            this.ucEmployee2.Name = "ucEmployee2";
            this.ucEmployee2.Size = new System.Drawing.Size(1042, 705);
            this.ucEmployee2.TabIndex = 0;
            // 
            // ucUser1
            // 
            this.ucUser1.BackColor = System.Drawing.Color.White;
            this.ucUser1.Location = new System.Drawing.Point(0, 31);
            this.ucUser1.Name = "ucUser1";
            this.ucUser1.Size = new System.Drawing.Size(1526, 810);
            this.ucUser1.TabIndex = 5;
            // 
            // fPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1356, 753);
            this.Controls.Add(this.pnlContianer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fPrincipal";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlContianer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbExits;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlClick;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Button btnPaySheet;
        private System.Windows.Forms.Button btnVacation;
        private System.Windows.Forms.Button btnPermit;
        private System.Windows.Forms.Button btnDepartJob;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label Exist;
        private System.Windows.Forms.Panel pnlContianer;
        private UCEmployee ucEmployee1;
        private UCJobTitle ucJobTitle1;
        private UCEmployee ucEmployee2;
        private UCJobTitle ucJobTitle2;
        private UCPermission ucPermission1;
        private UCUser ucUser1;
        private UCPaySheet ucPaySheet1;
        private UCVacation ucVacation1;
    }
}