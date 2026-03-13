namespace MdiContainerPractica
{
    partial class RegistPers
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
            dgvPersonas = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            Column12 = new DataGridViewTextBoxColumn();
            btnRegistrar = new Button();
            txtApellido = new TextBox();
            txtEdad = new TextBox();
            txtSexo = new TextBox();
            txtTelefono = new TextBox();
            txtDireccion = new TextBox();
            txtCiudad = new TextBox();
            txtPais = new TextBox();
            txtCorreo = new TextBox();
            txtFechaNacimiento = new TextBox();
            txtEstadoCivil = new TextBox();
            txtOcupacion = new TextBox();
            txtNombre = new TextBox();
            lblOcupacion = new Label();
            lblCiudad = new Label();
            lblPais = new Label();
            lblDireccion = new Label();
            lblCorreo = new Label();
            lblFechaNacimiento = new Label();
            lblEstadoCivil = new Label();
            lblApellido = new Label();
            lblTelefono = new Label();
            lblNombre = new Label();
            panel1 = new Panel();
            lblSexo = new Label();
            lblEdad = new Label();
            buttonClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9, Column10, Column11, Column12 });
            dgvPersonas.Location = new Point(346, 12);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.Size = new Size(289, 396);
            dgvPersonas.TabIndex = 25;
            dgvPersonas.CellContentClick += dgvPersonas_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nombre";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Apellido";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Edad";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Sexo";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Telefono";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Direccion";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Ciudad";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.HeaderText = "Pais";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.HeaderText = "Correo";
            Column9.Name = "Column9";
            // 
            // Column10
            // 
            Column10.HeaderText = "FechaNacimiento";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.HeaderText = "EstadoCivil";
            Column11.Name = "Column11";
            // 
            // Column12
            // 
            Column12.HeaderText = "Ocupacion";
            Column12.Name = "Column12";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegistrar.Location = new Point(22, 401);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(289, 65);
            btnRegistrar.TabIndex = 48;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(22, 94);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(119, 23);
            txtApellido.TabIndex = 47;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(22, 159);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(119, 23);
            txtEdad.TabIndex = 46;
            // 
            // txtSexo
            // 
            txtSexo.Location = new Point(22, 220);
            txtSexo.Name = "txtSexo";
            txtSexo.Size = new Size(119, 23);
            txtSexo.TabIndex = 45;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(22, 286);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(119, 23);
            txtTelefono.TabIndex = 44;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(22, 359);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(119, 23);
            txtDireccion.TabIndex = 43;
            // 
            // txtCiudad
            // 
            txtCiudad.Location = new Point(161, 39);
            txtCiudad.Name = "txtCiudad";
            txtCiudad.Size = new Size(143, 23);
            txtCiudad.TabIndex = 42;
            // 
            // txtPais
            // 
            txtPais.Location = new Point(161, 94);
            txtPais.Name = "txtPais";
            txtPais.Size = new Size(143, 23);
            txtPais.TabIndex = 41;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(161, 159);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(143, 23);
            txtCorreo.TabIndex = 40;
            // 
            // txtFechaNacimiento
            // 
            txtFechaNacimiento.Location = new Point(161, 220);
            txtFechaNacimiento.Name = "txtFechaNacimiento";
            txtFechaNacimiento.Size = new Size(143, 23);
            txtFechaNacimiento.TabIndex = 39;
            // 
            // txtEstadoCivil
            // 
            txtEstadoCivil.Location = new Point(161, 286);
            txtEstadoCivil.Name = "txtEstadoCivil";
            txtEstadoCivil.Size = new Size(143, 23);
            txtEstadoCivil.TabIndex = 38;
            // 
            // txtOcupacion
            // 
            txtOcupacion.Location = new Point(161, 359);
            txtOcupacion.Name = "txtOcupacion";
            txtOcupacion.Size = new Size(143, 23);
            txtOcupacion.TabIndex = 37;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(22, 39);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(119, 23);
            txtNombre.TabIndex = 36;
            // 
            // lblOcupacion
            // 
            lblOcupacion.AutoSize = true;
            lblOcupacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblOcupacion.Location = new Point(161, 341);
            lblOcupacion.Name = "lblOcupacion";
            lblOcupacion.Size = new Size(68, 15);
            lblOcupacion.TabIndex = 35;
            lblOcupacion.Text = "Ocupacion:";
            // 
            // lblCiudad
            // 
            lblCiudad.AutoSize = true;
            lblCiudad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCiudad.Location = new Point(161, 21);
            lblCiudad.Name = "lblCiudad";
            lblCiudad.Size = new Size(47, 15);
            lblCiudad.TabIndex = 34;
            lblCiudad.Text = "Ciudad:";
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPais.Location = new Point(161, 76);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(31, 15);
            lblPais.TabIndex = 33;
            lblPais.Text = "Pais:";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDireccion.Location = new Point(22, 341);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(63, 15);
            lblDireccion.TabIndex = 32;
            lblDireccion.Text = "Direccion:";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCorreo.Location = new Point(161, 141);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(48, 15);
            lblCorreo.TabIndex = 31;
            lblCorreo.Text = "Correo:";
            // 
            // lblFechaNacimiento
            // 
            lblFechaNacimiento.AutoSize = true;
            lblFechaNacimiento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaNacimiento.Location = new Point(161, 202);
            lblFechaNacimiento.Name = "lblFechaNacimiento";
            lblFechaNacimiento.Size = new Size(128, 15);
            lblFechaNacimiento.TabIndex = 30;
            lblFechaNacimiento.Text = "Fecha De Nacimiento:";
            // 
            // lblEstadoCivil
            // 
            lblEstadoCivil.AutoSize = true;
            lblEstadoCivil.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEstadoCivil.Location = new Point(161, 268);
            lblEstadoCivil.Name = "lblEstadoCivil";
            lblEstadoCivil.Size = new Size(72, 15);
            lblEstadoCivil.TabIndex = 29;
            lblEstadoCivil.Text = "Estado Civil:";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblApellido.Location = new Point(22, 76);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(55, 15);
            lblApellido.TabIndex = 28;
            lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.Location = new Point(22, 268);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(59, 15);
            lblTelefono.TabIndex = 27;
            lblTelefono.Text = "Telefono:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.Location = new Point(22, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lblSexo);
            panel1.Controls.Add(lblEdad);
            panel1.Controls.Add(btnRegistrar);
            panel1.Controls.Add(txtApellido);
            panel1.Controls.Add(txtEdad);
            panel1.Controls.Add(txtSexo);
            panel1.Controls.Add(txtTelefono);
            panel1.Controls.Add(txtDireccion);
            panel1.Controls.Add(txtCiudad);
            panel1.Controls.Add(txtPais);
            panel1.Controls.Add(txtCorreo);
            panel1.Controls.Add(txtFechaNacimiento);
            panel1.Controls.Add(txtEstadoCivil);
            panel1.Controls.Add(txtOcupacion);
            panel1.Controls.Add(txtNombre);
            panel1.Controls.Add(lblOcupacion);
            panel1.Controls.Add(lblCiudad);
            panel1.Controls.Add(lblPais);
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblCorreo);
            panel1.Controls.Add(lblFechaNacimiento);
            panel1.Controls.Add(lblEstadoCivil);
            panel1.Controls.Add(lblApellido);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblNombre);
            panel1.Location = new Point(11, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(329, 487);
            panel1.TabIndex = 49;
            // 
            // lblSexo
            // 
            lblSexo.AutoSize = true;
            lblSexo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSexo.Location = new Point(22, 202);
            lblSexo.Name = "lblSexo";
            lblSexo.Size = new Size(38, 15);
            lblSexo.TabIndex = 50;
            lblSexo.Text = "Sexo:";
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEdad.Location = new Point(22, 141);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(36, 15);
            lblEdad.TabIndex = 49;
            lblEdad.Text = "Edad:";
            lblEdad.Click += lblEdad_Click;
            // 
            // buttonClear
            // 
            buttonClear.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClear.ForeColor = Color.Red;
            buttonClear.Location = new Point(346, 414);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(289, 80);
            buttonClear.TabIndex = 51;
            buttonClear.Text = "LIMPIAR";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += buttonClear_Click;
            // 
            // RegistPers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 506);
            Controls.Add(buttonClear);
            Controls.Add(panel1);
            Controls.Add(dgvPersonas);
            Name = "RegistPers";
            Text = "RegistPers";
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvPersonas;
        private Button btnRegistrar;
        private TextBox txtApellido;
        private TextBox txtEdad;
        private TextBox txtSexo;
        private TextBox txtTelefono;
        private TextBox txtDireccion;
        private TextBox txtCiudad;
        private TextBox txtPais;
        private TextBox txtCorreo;
        private TextBox txtFechaNacimiento;
        private TextBox txtEstadoCivil;
        private TextBox txtOcupacion;
        private TextBox txtNombre;
        private Label lblOcupacion;
        private Label lblCiudad;
        private Label lblPais;
        private Label lblDireccion;
        private Label lblCorreo;
        private Label lblFechaNacimiento;
        private Label lblEstadoCivil;
        private Label lblApellido;
        private Label lblTelefono;
        private Label lblNombre;
        private Panel panel1;
        private Label lblSexo;
        private Label lblEdad;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
        private DataGridViewTextBoxColumn Column12;
        private Button buttonClear;
    }
}