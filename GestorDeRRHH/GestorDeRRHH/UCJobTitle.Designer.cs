namespace GestorDeRRHH
{
    partial class UCJobTitle
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label12 = new System.Windows.Forms.Label();
            this.txtSearchJob = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReportJobTitle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSaveUpdate = new System.Windows.Forms.Button();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colJob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstJobTitle = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCodeEmployee = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReportDep = new System.Windows.Forms.Button();
            this.btnDeleteDepart = new System.Windows.Forms.Button();
            this.btnSaveDepart = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSearchDepart = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lstDepart = new System.Windows.Forms.ListView();
            this.colIdDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCodeDepart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colEmployee = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(52, 316);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 24);
            this.label12.TabIndex = 16;
            this.label12.Text = "Buscar: ";
            // 
            // txtSearchJob
            // 
            this.txtSearchJob.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchJob.Location = new System.Drawing.Point(139, 315);
            this.txtSearchJob.Multiline = true;
            this.txtSearchJob.Name = "txtSearchJob";
            this.txtSearchJob.Size = new System.Drawing.Size(588, 34);
            this.txtSearchJob.TabIndex = 16;
            this.txtSearchJob.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnReportJobTitle);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSaveUpdate);
            this.groupBox1.Controls.Add(this.txtJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.groupBox1.Location = new System.Drawing.Point(56, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 224);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar/Filtrar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label7.Location = new System.Drawing.Point(-3, -193);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(260, 29);
            this.label7.TabIndex = 22;
            this.label7.Text = "Lista de empleados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label5.Location = new System.Drawing.Point(-3, -193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(260, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Lista de empleados";
            // 
            // btnReportJobTitle
            // 
            this.btnReportJobTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnReportJobTitle.FlatAppearance.BorderSize = 0;
            this.btnReportJobTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportJobTitle.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnReportJobTitle.ForeColor = System.Drawing.Color.White;
            this.btnReportJobTitle.Location = new System.Drawing.Point(380, 125);
            this.btnReportJobTitle.Name = "btnReportJobTitle";
            this.btnReportJobTitle.Size = new System.Drawing.Size(222, 45);
            this.btnReportJobTitle.TabIndex = 20;
            this.btnReportJobTitle.Text = "Generar informe";
            this.btnReportJobTitle.UseVisualStyleBackColor = false;
            this.btnReportJobTitle.Click += new System.EventHandler(this.btnReportJobTitle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(218, 125);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveUpdate
            // 
            this.btnSaveUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSaveUpdate.FlatAppearance.BorderSize = 0;
            this.btnSaveUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveUpdate.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnSaveUpdate.ForeColor = System.Drawing.Color.White;
            this.btnSaveUpdate.Location = new System.Drawing.Point(61, 125);
            this.btnSaveUpdate.Name = "btnSaveUpdate";
            this.btnSaveUpdate.Size = new System.Drawing.Size(138, 45);
            this.btnSaveUpdate.TabIndex = 6;
            this.btnSaveUpdate.Text = "Guardar";
            this.btnSaveUpdate.UseVisualStyleBackColor = false;
            this.btnSaveUpdate.Click += new System.EventHandler(this.btnSaveUpdate_Click);
            // 
            // txtJob
            // 
            this.txtJob.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(133, 55);
            this.txtJob.Multiline = true;
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(212, 34);
            this.txtJob.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label2.Location = new System.Drawing.Point(57, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cargo: ";
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 111;
            // 
            // colCode
            // 
            this.colCode.Text = "Código";
            this.colCode.Width = 196;
            // 
            // colJob
            // 
            this.colJob.Text = "Cargo";
            this.colJob.Width = 240;
            // 
            // lstJobTitle
            // 
            this.lstJobTitle.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colCode,
            this.colJob});
            this.lstJobTitle.FullRowSelect = true;
            this.lstJobTitle.Location = new System.Drawing.Point(56, 372);
            this.lstJobTitle.Name = "lstJobTitle";
            this.lstJobTitle.Size = new System.Drawing.Size(671, 279);
            this.lstJobTitle.TabIndex = 19;
            this.lstJobTitle.UseCompatibleStateImageBehavior = false;
            this.lstJobTitle.View = System.Windows.Forms.View.Details;
            this.lstJobTitle.Click += new System.EventHandler(this.lstJobTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(51, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 20;
            this.label1.Text = "Lista de Cargos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(779, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 22;
            this.label3.Text = "Lista de Departementos";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCodeEmployee);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnReportDep);
            this.groupBox2.Controls.Add(this.btnDeleteDepart);
            this.groupBox2.Controls.Add(this.btnSaveDepart);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.groupBox2.Location = new System.Drawing.Point(784, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 224);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar/Filtrar";
            // 
            // cbCodeEmployee
            // 
            this.cbCodeEmployee.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodeEmployee.FormattingEnabled = true;
            this.cbCodeEmployee.Location = new System.Drawing.Point(140, 102);
            this.cbCodeEmployee.Name = "cbCodeEmployee";
            this.cbCodeEmployee.Size = new System.Drawing.Size(273, 35);
            this.cbCodeEmployee.TabIndex = 24;
            this.cbCodeEmployee.Click += new System.EventHandler(this.cbCodeEmployee_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(23, 113);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "Encargado: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(-3, -193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(260, 29);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lista de empleados";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(-3, -193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(260, 29);
            this.label6.TabIndex = 21;
            this.label6.Text = "Lista de empleados";
            // 
            // btnReportDep
            // 
            this.btnReportDep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnReportDep.FlatAppearance.BorderSize = 0;
            this.btnReportDep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportDep.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnReportDep.ForeColor = System.Drawing.Color.White;
            this.btnReportDep.Location = new System.Drawing.Point(42, 159);
            this.btnReportDep.Name = "btnReportDep";
            this.btnReportDep.Size = new System.Drawing.Size(222, 45);
            this.btnReportDep.TabIndex = 20;
            this.btnReportDep.Text = "Generar informe";
            this.btnReportDep.UseVisualStyleBackColor = false;
            this.btnReportDep.Click += new System.EventHandler(this.btnReportDep_Click);
            // 
            // btnDeleteDepart
            // 
            this.btnDeleteDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnDeleteDepart.FlatAppearance.BorderSize = 0;
            this.btnDeleteDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteDepart.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnDeleteDepart.ForeColor = System.Drawing.Color.White;
            this.btnDeleteDepart.Location = new System.Drawing.Point(500, 159);
            this.btnDeleteDepart.Name = "btnDeleteDepart";
            this.btnDeleteDepart.Size = new System.Drawing.Size(141, 45);
            this.btnDeleteDepart.TabIndex = 13;
            this.btnDeleteDepart.Text = "Eliminar";
            this.btnDeleteDepart.UseVisualStyleBackColor = false;
            this.btnDeleteDepart.Click += new System.EventHandler(this.btnDeleteDepart_Click);
            // 
            // btnSaveDepart
            // 
            this.btnSaveDepart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSaveDepart.FlatAppearance.BorderSize = 0;
            this.btnSaveDepart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveDepart.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnSaveDepart.ForeColor = System.Drawing.Color.White;
            this.btnSaveDepart.Location = new System.Drawing.Point(310, 159);
            this.btnSaveDepart.Name = "btnSaveDepart";
            this.btnSaveDepart.Size = new System.Drawing.Size(138, 45);
            this.btnSaveDepart.TabIndex = 6;
            this.btnSaveDepart.Text = "Guardar";
            this.btnSaveDepart.UseVisualStyleBackColor = false;
            this.btnSaveDepart.Click += new System.EventHandler(this.btnSaveDepart_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(140, 47);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(273, 34);
            this.txtName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(38, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre: ";
            // 
            // txtSearchDepart
            // 
            this.txtSearchDepart.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchDepart.Location = new System.Drawing.Point(867, 315);
            this.txtSearchDepart.Multiline = true;
            this.txtSearchDepart.Name = "txtSearchDepart";
            this.txtSearchDepart.Size = new System.Drawing.Size(588, 34);
            this.txtSearchDepart.TabIndex = 16;
            this.txtSearchDepart.TextChanged += new System.EventHandler(this.txtSearchDepart_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(780, 317);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 24);
            this.label9.TabIndex = 16;
            this.label9.Text = "Buscar: ";
            // 
            // lstDepart
            // 
            this.lstDepart.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colIdDepart,
            this.colCodeDepart,
            this.colName,
            this.colEmployee});
            this.lstDepart.FullRowSelect = true;
            this.lstDepart.Location = new System.Drawing.Point(784, 372);
            this.lstDepart.Name = "lstDepart";
            this.lstDepart.Size = new System.Drawing.Size(671, 279);
            this.lstDepart.TabIndex = 23;
            this.lstDepart.UseCompatibleStateImageBehavior = false;
            this.lstDepart.View = System.Windows.Forms.View.Details;
            this.lstDepart.Click += new System.EventHandler(this.lstDepart_Click);
            // 
            // colIdDepart
            // 
            this.colIdDepart.Text = "Id";
            this.colIdDepart.Width = 74;
            // 
            // colCodeDepart
            // 
            this.colCodeDepart.Text = "Código";
            this.colCodeDepart.Width = 135;
            // 
            // colName
            // 
            this.colName.Text = "Nombre";
            this.colName.Width = 161;
            // 
            // colEmployee
            // 
            this.colEmployee.Text = "Encargado";
            this.colEmployee.Width = 165;
            // 
            // UCJobTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lstDepart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstJobTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtSearchJob);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtSearchDepart);
            this.Controls.Add(this.label9);
            this.Name = "UCJobTitle";
            this.Size = new System.Drawing.Size(1526, 810);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtSearchJob;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReportJobTitle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSaveUpdate;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCode;
        private System.Windows.Forms.ColumnHeader colJob;
        private System.Windows.Forms.ListView lstJobTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReportDep;
        private System.Windows.Forms.Button btnDeleteDepart;
        private System.Windows.Forms.Button btnSaveDepart;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSearchDepart;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView lstDepart;
        private System.Windows.Forms.ColumnHeader colIdDepart;
        private System.Windows.Forms.ColumnHeader colCodeDepart;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colEmployee;
        private System.Windows.Forms.ComboBox cbCodeEmployee;
    }
}
