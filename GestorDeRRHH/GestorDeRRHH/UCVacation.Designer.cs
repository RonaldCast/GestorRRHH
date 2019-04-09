namespace GestorDeRRHH
{
    partial class UCVacation
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
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchYear = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbCodEmployeeVac = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpUntilVac = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpSinceVac = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReportVac = new System.Windows.Forms.Button();
            this.btnClearVac = new System.Windows.Forms.Button();
            this.btnSaveVac = new System.Windows.Forms.Button();
            this.lstVacation = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerDateSince = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerDateUntil = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPerCom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstExist = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnClearExist = new System.Windows.Forms.Button();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbCodEmployeeExist = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReason = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpDateExist = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnReportExist = new System.Windows.Forms.Button();
            this.btnSaveExist = new System.Windows.Forms.Button();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label3.Location = new System.Drawing.Point(778, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 29);
            this.label3.TabIndex = 32;
            this.label3.Text = "Lista de Salidas ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label1.Location = new System.Drawing.Point(50, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 29);
            this.label1.TabIndex = 30;
            this.label1.Text = "Lista de Vacaciones";
            // 
            // txtSearchYear
            // 
            this.txtSearchYear.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchYear.Location = new System.Drawing.Point(306, 427);
            this.txtSearchYear.Multiline = true;
            this.txtSearchYear.Name = "txtSearchYear";
            this.txtSearchYear.Size = new System.Drawing.Size(160, 34);
            this.txtSearchYear.TabIndex = 24;
            this.txtSearchYear.TextChanged += new System.EventHandler(this.txtSearchYear_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label12.Location = new System.Drawing.Point(51, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(258, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "Buscar vacaciones por año: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label9.Location = new System.Drawing.Point(779, 429);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(159, 24);
            this.label9.TabIndex = 27;
            this.label9.Text = "Buscar por mes: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbCodEmployeeVac);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtComment);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.dtpUntilVac);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpSinceVac);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnReportVac);
            this.groupBox1.Controls.Add(this.btnClearVac);
            this.groupBox1.Controls.Add(this.btnSaveVac);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.groupBox1.Location = new System.Drawing.Point(55, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 338);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar/Filtrar";
            // 
            // cbCodEmployeeVac
            // 
            this.cbCodEmployeeVac.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodEmployeeVac.FormattingEnabled = true;
            this.cbCodEmployeeVac.Location = new System.Drawing.Point(164, 56);
            this.cbCodEmployeeVac.Name = "cbCodEmployeeVac";
            this.cbCodEmployeeVac.Size = new System.Drawing.Size(212, 35);
            this.cbCodEmployeeVac.TabIndex = 31;
            this.cbCodEmployeeVac.Click += new System.EventHandler(this.cbCodEmployeeVac_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label15.Location = new System.Drawing.Point(22, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(133, 24);
            this.label15.TabIndex = 29;
            this.label15.Text = "Código Empl.: ";
            // 
            // txtComment
            // 
            this.txtComment.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComment.Location = new System.Drawing.Point(162, 202);
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(212, 87);
            this.txtComment.TabIndex = 28;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label14.Location = new System.Drawing.Point(22, 202);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "Comentario: ";
            // 
            // dtpUntilVac
            // 
            this.dtpUntilVac.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpUntilVac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpUntilVac.Location = new System.Drawing.Point(162, 151);
            this.dtpUntilVac.Name = "dtpUntilVac";
            this.dtpUntilVac.Size = new System.Drawing.Size(212, 25);
            this.dtpUntilVac.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label13.Location = new System.Drawing.Point(22, 151);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 24);
            this.label13.TabIndex = 25;
            this.label13.Text = "Fecha hasta:";
            // 
            // dtpSinceVac
            // 
            this.dtpSinceVac.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpSinceVac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSinceVac.Location = new System.Drawing.Point(164, 102);
            this.dtpSinceVac.Name = "dtpSinceVac";
            this.dtpSinceVac.Size = new System.Drawing.Size(212, 25);
            this.dtpSinceVac.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label11.Location = new System.Drawing.Point(20, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 24);
            this.label11.TabIndex = 23;
            this.label11.Text = "Fecha desde:";
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
            // btnReportVac
            // 
            this.btnReportVac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnReportVac.FlatAppearance.BorderSize = 0;
            this.btnReportVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportVac.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnReportVac.ForeColor = System.Drawing.Color.White;
            this.btnReportVac.Location = new System.Drawing.Point(407, 192);
            this.btnReportVac.Name = "btnReportVac";
            this.btnReportVac.Size = new System.Drawing.Size(222, 45);
            this.btnReportVac.TabIndex = 20;
            this.btnReportVac.Text = "Generar informe";
            this.btnReportVac.UseVisualStyleBackColor = false;
            this.btnReportVac.Click += new System.EventHandler(this.btnReportVac_Click);
            // 
            // btnClearVac
            // 
            this.btnClearVac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClearVac.FlatAppearance.BorderSize = 0;
            this.btnClearVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearVac.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnClearVac.ForeColor = System.Drawing.Color.White;
            this.btnClearVac.Location = new System.Drawing.Point(407, 131);
            this.btnClearVac.Name = "btnClearVac";
            this.btnClearVac.Size = new System.Drawing.Size(222, 45);
            this.btnClearVac.TabIndex = 13;
            this.btnClearVac.Text = "Limpiar compos";
            this.btnClearVac.UseVisualStyleBackColor = false;
            this.btnClearVac.Click += new System.EventHandler(this.btnClearVac_Click);
            // 
            // btnSaveVac
            // 
            this.btnSaveVac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSaveVac.FlatAppearance.BorderSize = 0;
            this.btnSaveVac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveVac.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnSaveVac.ForeColor = System.Drawing.Color.White;
            this.btnSaveVac.Location = new System.Drawing.Point(410, 67);
            this.btnSaveVac.Name = "btnSaveVac";
            this.btnSaveVac.Size = new System.Drawing.Size(219, 45);
            this.btnSaveVac.TabIndex = 6;
            this.btnSaveVac.Text = "Guardar";
            this.btnSaveVac.UseVisualStyleBackColor = false;
            this.btnSaveVac.Click += new System.EventHandler(this.btnSaveVac_Click);
            // 
            // lstVacation
            // 
            this.lstVacation.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colPerCode,
            this.colPerDateSince,
            this.colPerDateUntil,
            this.colPerCom,
            this.colYear});
            this.lstVacation.FullRowSelect = true;
            this.lstVacation.Location = new System.Drawing.Point(55, 487);
            this.lstVacation.Name = "lstVacation";
            this.lstVacation.Size = new System.Drawing.Size(671, 266);
            this.lstVacation.TabIndex = 35;
            this.lstVacation.UseCompatibleStateImageBehavior = false;
            this.lstVacation.View = System.Windows.Forms.View.Details;
            this.lstVacation.Click += new System.EventHandler(this.lstVacation_Click);
            // 
            // colId
            // 
            this.colId.Text = "Id";
            this.colId.Width = 61;
            // 
            // colPerCode
            // 
            this.colPerCode.Text = "Código Empleado";
            this.colPerCode.Width = 138;
            // 
            // colPerDateSince
            // 
            this.colPerDateSince.Text = "Fecha desde";
            this.colPerDateSince.Width = 135;
            // 
            // colPerDateUntil
            // 
            this.colPerDateUntil.Text = "Fecha hasta";
            this.colPerDateUntil.Width = 114;
            // 
            // colPerCom
            // 
            this.colPerCom.Text = "Comentario";
            this.colPerCom.Width = 125;
            // 
            // colYear
            // 
            this.colYear.Text = "Año";
            this.colYear.Width = 87;
            // 
            // lstExist
            // 
            this.lstExist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.colType,
            this.columnHeader4,
            this.columnHeader5});
            this.lstExist.Location = new System.Drawing.Point(783, 487);
            this.lstExist.Name = "lstExist";
            this.lstExist.Size = new System.Drawing.Size(671, 266);
            this.lstExist.TabIndex = 36;
            this.lstExist.UseCompatibleStateImageBehavior = false;
            this.lstExist.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Id";
            this.columnHeader1.Width = 61;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Código Empleado";
            this.columnHeader2.Width = 150;
            // 
            // colType
            // 
            this.colType.Text = "Tipo";
            this.colType.Width = 152;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fecha";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Motivo";
            this.columnHeader5.Width = 125;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnClearExist);
            this.groupBox2.Controls.Add(this.cbType);
            this.groupBox2.Controls.Add(this.cbCodEmployeeExist);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtReason);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dtpDateExist);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnReportExist);
            this.groupBox2.Controls.Add(this.btnSaveExist);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.groupBox2.Location = new System.Drawing.Point(783, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(671, 338);
            this.groupBox2.TabIndex = 35;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registrar/Filtrar";
            // 
            // btnClearExist
            // 
            this.btnClearExist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnClearExist.FlatAppearance.BorderSize = 0;
            this.btnClearExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearExist.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnClearExist.ForeColor = System.Drawing.Color.White;
            this.btnClearExist.Location = new System.Drawing.Point(407, 131);
            this.btnClearExist.Name = "btnClearExist";
            this.btnClearExist.Size = new System.Drawing.Size(222, 45);
            this.btnClearExist.TabIndex = 34;
            this.btnClearExist.Text = "Limpiar compos";
            this.btnClearExist.UseVisualStyleBackColor = false;
            this.btnClearExist.Click += new System.EventHandler(this.btnClearExist_Click);
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(161, 105);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(212, 35);
            this.cbType.TabIndex = 33;
            // 
            // cbCodEmployeeExist
            // 
            this.cbCodEmployeeExist.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCodEmployeeExist.FormattingEnabled = true;
            this.cbCodEmployeeExist.Location = new System.Drawing.Point(161, 54);
            this.cbCodEmployeeExist.Name = "cbCodEmployeeExist";
            this.cbCodEmployeeExist.Size = new System.Drawing.Size(212, 35);
            this.cbCodEmployeeExist.TabIndex = 32;
            this.cbCodEmployeeExist.Click += new System.EventHandler(this.cbCodEmployeeExist_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label4.Location = new System.Drawing.Point(96, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 24);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tipo: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label6.Location = new System.Drawing.Point(22, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 24);
            this.label6.TabIndex = 29;
            this.label6.Text = "Código Empl.: ";
            // 
            // txtReason
            // 
            this.txtReason.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReason.Location = new System.Drawing.Point(161, 222);
            this.txtReason.Multiline = true;
            this.txtReason.Name = "txtReason";
            this.txtReason.Size = new System.Drawing.Size(212, 67);
            this.txtReason.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label8.Location = new System.Drawing.Point(73, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 24);
            this.label8.TabIndex = 27;
            this.label8.Text = "Motivo: ";
            // 
            // dtpDateExist
            // 
            this.dtpDateExist.Font = new System.Drawing.Font("Open Sans", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateExist.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDateExist.Location = new System.Drawing.Point(164, 167);
            this.dtpDateExist.Name = "dtpDateExist";
            this.dtpDateExist.Size = new System.Drawing.Size(212, 25);
            this.dtpDateExist.TabIndex = 26;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Open Sans", 10.5F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label10.Location = new System.Drawing.Point(79, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 25;
            this.label10.Text = "Fecha:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label17.Location = new System.Drawing.Point(-3, -193);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(260, 29);
            this.label17.TabIndex = 22;
            this.label17.Text = "Lista de empleados";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Questrial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.label18.Location = new System.Drawing.Point(-3, -193);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(260, 29);
            this.label18.TabIndex = 21;
            this.label18.Text = "Lista de empleados";
            // 
            // btnReportExist
            // 
            this.btnReportExist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnReportExist.FlatAppearance.BorderSize = 0;
            this.btnReportExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportExist.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnReportExist.ForeColor = System.Drawing.Color.White;
            this.btnReportExist.Location = new System.Drawing.Point(407, 201);
            this.btnReportExist.Name = "btnReportExist";
            this.btnReportExist.Size = new System.Drawing.Size(222, 45);
            this.btnReportExist.TabIndex = 20;
            this.btnReportExist.Text = "Generar informe";
            this.btnReportExist.UseVisualStyleBackColor = false;
            this.btnReportExist.Click += new System.EventHandler(this.btnReportExist_Click);
            // 
            // btnSaveExist
            // 
            this.btnSaveExist.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(125)))), ((int)(((byte)(139)))));
            this.btnSaveExist.FlatAppearance.BorderSize = 0;
            this.btnSaveExist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveExist.Font = new System.Drawing.Font("Open Sans", 9.8F);
            this.btnSaveExist.ForeColor = System.Drawing.Color.White;
            this.btnSaveExist.Location = new System.Drawing.Point(410, 67);
            this.btnSaveExist.Name = "btnSaveExist";
            this.btnSaveExist.Size = new System.Drawing.Size(219, 45);
            this.btnSaveExist.TabIndex = 6;
            this.btnSaveExist.Text = "Guardar";
            this.btnSaveExist.UseVisualStyleBackColor = false;
            this.btnSaveExist.Click += new System.EventHandler(this.btnSaveExist_Click);
            // 
            // cbMonth
            // 
            this.cbMonth.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.Location = new System.Drawing.Point(947, 418);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(212, 35);
            this.cbMonth.TabIndex = 34;
            this.cbMonth.SelectionChangeCommitted += new System.EventHandler(this.cbMonth_SelectionChangeCommitted);
            // 
            // UCVacation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.cbMonth);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstExist);
            this.Controls.Add(this.lstVacation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchYear);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Name = "UCVacation";
            this.Size = new System.Drawing.Size(1526, 810);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchYear;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpUntilVac;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpSinceVac;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReportVac;
        private System.Windows.Forms.Button btnClearVac;
        private System.Windows.Forms.Button btnSaveVac;
        private System.Windows.Forms.ListView lstVacation;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colPerCode;
        private System.Windows.Forms.ColumnHeader colPerDateSince;
        private System.Windows.Forms.ColumnHeader colPerDateUntil;
        private System.Windows.Forms.ColumnHeader colPerCom;
        private System.Windows.Forms.ColumnHeader colYear;
        private System.Windows.Forms.ListView lstExist;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReason;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpDateExist;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnReportExist;
        private System.Windows.Forms.Button btnSaveExist;
        private System.Windows.Forms.ComboBox cbCodEmployeeVac;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbCodEmployeeExist;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.Button btnClearExist;
    }
}
