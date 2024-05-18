namespace CapaPresentacion
{
    partial class MantenimientoAlumnos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabAlumnos = new System.Windows.Forms.TabPage();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabNotas = new System.Windows.Forms.TabPage();
            this.btnAgregarNota = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDatosCodigoAlumno = new System.Windows.Forms.TextBox();
            this.txtDatosAlumno = new System.Windows.Forms.TextBox();
            this.btnNuevaNota = new System.Windows.Forms.Button();
            this.gbCurso = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboCurso = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.btnAgregarNuevaNota = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dgvListadoNotas = new System.Windows.Forms.DataGridView();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.gbNota = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNotaPromedio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCantidadNotas = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabAlumnos.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabNotas.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbCurso.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).BeginInit();
            this.gbNota.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 482);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Alumnos y Notas";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabAlumnos);
            this.tabControl.Controls.Add(this.tabNotas);
            this.tabControl.Location = new System.Drawing.Point(7, 20);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(711, 447);
            this.tabControl.TabIndex = 0;
            // 
            // tabAlumnos
            // 
            this.tabAlumnos.Controls.Add(this.btnAgregarNota);
            this.tabAlumnos.Controls.Add(this.btnCancelar);
            this.tabAlumnos.Controls.Add(this.btnAceptar);
            this.tabAlumnos.Controls.Add(this.btnEditar);
            this.tabAlumnos.Controls.Add(this.btnNuevo);
            this.tabAlumnos.Controls.Add(this.groupBox3);
            this.tabAlumnos.Controls.Add(this.groupBox2);
            this.tabAlumnos.Location = new System.Drawing.Point(4, 22);
            this.tabAlumnos.Name = "tabAlumnos";
            this.tabAlumnos.Padding = new System.Windows.Forms.Padding(3);
            this.tabAlumnos.Size = new System.Drawing.Size(703, 421);
            this.tabAlumnos.TabIndex = 0;
            this.tabAlumnos.Text = "Alumnos";
            this.tabAlumnos.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(131, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(109, 30);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(16, 284);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(109, 30);
            this.btnAceptar.TabIndex = 5;
            this.btnAceptar.Text = "&Guardar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(404, 236);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(86, 37);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(306, 236);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(92, 37);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvAlumnos);
            this.groupBox3.Location = new System.Drawing.Point(303, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 216);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Alumnos";
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AllowUserToDeleteRows = false;
            this.dgvAlumnos.AllowUserToResizeColumns = false;
            this.dgvAlumnos.AllowUserToResizeRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlumnos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlumnos.Location = new System.Drawing.Point(3, 16);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(378, 197);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellClick);
            this.dgvAlumnos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAlumnos_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDireccion);
            this.groupBox2.Controls.Add(this.dtpFechaNacimiento);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.txtNombres);
            this.groupBox2.Controls.Add(this.txtCodigo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(16, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 261);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Alumno";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(19, 236);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(222, 20);
            this.txtDireccion.TabIndex = 11;
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(19, 196);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(222, 20);
            this.dtpFechaNacimiento.TabIndex = 10;
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(19, 156);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(222, 20);
            this.txtDNI.TabIndex = 9;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(19, 116);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(222, 20);
            this.txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(19, 76);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(222, 20);
            this.txtNombres.TabIndex = 7;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(19, 37);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(222, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Dirección*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fecha Nacimiento*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "DNI*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombres*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código*";
            // 
            // tabNotas
            // 
            this.tabNotas.Controls.Add(this.txtCantidadNotas);
            this.tabNotas.Controls.Add(this.label12);
            this.tabNotas.Controls.Add(this.txtNotaPromedio);
            this.tabNotas.Controls.Add(this.label11);
            this.tabNotas.Controls.Add(this.gbNota);
            this.tabNotas.Controls.Add(this.groupBox6);
            this.tabNotas.Controls.Add(this.gbCurso);
            this.tabNotas.Controls.Add(this.btnNuevaNota);
            this.tabNotas.Controls.Add(this.groupBox4);
            this.tabNotas.Location = new System.Drawing.Point(4, 22);
            this.tabNotas.Name = "tabNotas";
            this.tabNotas.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotas.Size = new System.Drawing.Size(703, 421);
            this.tabNotas.TabIndex = 1;
            this.tabNotas.Text = "Registro de Notas";
            this.tabNotas.UseVisualStyleBackColor = true;
            // 
            // btnAgregarNota
            // 
            this.btnAgregarNota.Location = new System.Drawing.Point(496, 236);
            this.btnAgregarNota.Name = "btnAgregarNota";
            this.btnAgregarNota.Size = new System.Drawing.Size(99, 37);
            this.btnAgregarNota.TabIndex = 7;
            this.btnAgregarNota.Text = "&Agregar Nota";
            this.btnAgregarNota.UseVisualStyleBackColor = true;
            this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtDatosAlumno);
            this.groupBox4.Controls.Add(this.txtDatosCodigoAlumno);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Location = new System.Drawing.Point(17, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(666, 78);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Generales del Alumno";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Código:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Apellido y Nombre: ";
            // 
            // txtDatosCodigoAlumno
            // 
            this.txtDatosCodigoAlumno.Enabled = false;
            this.txtDatosCodigoAlumno.Location = new System.Drawing.Point(10, 36);
            this.txtDatosCodigoAlumno.Name = "txtDatosCodigoAlumno";
            this.txtDatosCodigoAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtDatosCodigoAlumno.TabIndex = 2;
            // 
            // txtDatosAlumno
            // 
            this.txtDatosAlumno.Enabled = false;
            this.txtDatosAlumno.Location = new System.Drawing.Point(167, 36);
            this.txtDatosAlumno.Name = "txtDatosAlumno";
            this.txtDatosAlumno.Size = new System.Drawing.Size(397, 20);
            this.txtDatosAlumno.TabIndex = 3;
            // 
            // btnNuevaNota
            // 
            this.btnNuevaNota.Location = new System.Drawing.Point(17, 104);
            this.btnNuevaNota.Name = "btnNuevaNota";
            this.btnNuevaNota.Size = new System.Drawing.Size(110, 25);
            this.btnNuevaNota.TabIndex = 1;
            this.btnNuevaNota.Text = "&Nueva Nota";
            this.btnNuevaNota.UseVisualStyleBackColor = true;
            this.btnNuevaNota.Click += new System.EventHandler(this.btnNuevaNota_Click);
            // 
            // gbCurso
            // 
            this.gbCurso.Controls.Add(this.btnConfirmar);
            this.gbCurso.Controls.Add(this.cboCurso);
            this.gbCurso.Controls.Add(this.label9);
            this.gbCurso.Enabled = false;
            this.gbCurso.Location = new System.Drawing.Point(17, 136);
            this.gbCurso.Name = "gbCurso";
            this.gbCurso.Size = new System.Drawing.Size(461, 68);
            this.gbCurso.TabIndex = 2;
            this.gbCurso.TabStop = false;
            this.gbCurso.Text = "Selección del curso";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Curso:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Nota";
            // 
            // cboCurso
            // 
            this.cboCurso.FormattingEnabled = true;
            this.cboCurso.Location = new System.Drawing.Point(10, 36);
            this.cboCurso.Name = "cboCurso";
            this.cboCurso.Size = new System.Drawing.Size(275, 21);
            this.cboCurso.TabIndex = 2;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(9, 30);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(74, 20);
            this.txtNota.TabIndex = 3;
            // 
            // btnAgregarNuevaNota
            // 
            this.btnAgregarNuevaNota.Location = new System.Drawing.Point(89, 27);
            this.btnAgregarNuevaNota.Name = "btnAgregarNuevaNota";
            this.btnAgregarNuevaNota.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarNuevaNota.TabIndex = 4;
            this.btnAgregarNuevaNota.Text = "&Agregar";
            this.btnAgregarNuevaNota.UseVisualStyleBackColor = true;
            this.btnAgregarNuevaNota.Click += new System.EventHandler(this.btnAgregarNuevaNota_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dgvListadoNotas);
            this.groupBox6.Location = new System.Drawing.Point(17, 210);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(666, 147);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Listado de Notas";
            // 
            // dgvListadoNotas
            // 
            this.dgvListadoNotas.AllowUserToAddRows = false;
            this.dgvListadoNotas.AllowUserToDeleteRows = false;
            this.dgvListadoNotas.AllowUserToResizeColumns = false;
            this.dgvListadoNotas.AllowUserToResizeRows = false;
            this.dgvListadoNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvListadoNotas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoNotas.Location = new System.Drawing.Point(3, 16);
            this.dgvListadoNotas.Name = "dgvListadoNotas";
            this.dgvListadoNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoNotas.Size = new System.Drawing.Size(660, 128);
            this.dgvListadoNotas.TabIndex = 0;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(300, 34);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 23);
            this.btnConfirmar.TabIndex = 3;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // gbNota
            // 
            this.gbNota.Controls.Add(this.label10);
            this.gbNota.Controls.Add(this.btnAgregarNuevaNota);
            this.gbNota.Controls.Add(this.txtNota);
            this.gbNota.Enabled = false;
            this.gbNota.Location = new System.Drawing.Point(484, 140);
            this.gbNota.Name = "gbNota";
            this.gbNota.Size = new System.Drawing.Size(180, 64);
            this.gbNota.TabIndex = 5;
            this.gbNota.TabStop = false;
            this.gbNota.Text = "Nota";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(222, 361);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nota Promedio:";
            // 
            // txtNotaPromedio
            // 
            this.txtNotaPromedio.Enabled = false;
            this.txtNotaPromedio.Location = new System.Drawing.Point(225, 377);
            this.txtNotaPromedio.Name = "txtNotaPromedio";
            this.txtNotaPromedio.Size = new System.Drawing.Size(100, 20);
            this.txtNotaPromedio.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(17, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(139, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Cantidad Notas Registradas";
            // 
            // txtCantidadNotas
            // 
            this.txtCantidadNotas.Enabled = false;
            this.txtCantidadNotas.Location = new System.Drawing.Point(20, 377);
            this.txtCantidadNotas.Name = "txtCantidadNotas";
            this.txtCantidadNotas.Size = new System.Drawing.Size(100, 20);
            this.txtCantidadNotas.TabIndex = 9;
            // 
            // MantenimientoAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 507);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenimientoAlumnos";
            this.Text = "MantenimientoAlumnos";
            this.Load += new System.EventHandler(this.MantenimientoAlumnos_Load);
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabAlumnos.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabNotas.ResumeLayout(false);
            this.tabNotas.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbCurso.ResumeLayout(false);
            this.gbCurso.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoNotas)).EndInit();
            this.gbNota.ResumeLayout(false);
            this.gbNota.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabAlumnos;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabNotas;
        private System.Windows.Forms.Button btnAgregarNota;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtDatosAlumno;
        private System.Windows.Forms.TextBox txtDatosCodigoAlumno;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dgvListadoNotas;
        private System.Windows.Forms.GroupBox gbCurso;
        private System.Windows.Forms.Button btnAgregarNuevaNota;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.ComboBox cboCurso;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnNuevaNota;
        private System.Windows.Forms.GroupBox gbNota;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.TextBox txtNotaPromedio;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCantidadNotas;
        private System.Windows.Forms.Label label12;
    }
}