namespace Regist_Alumn
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCodigo = new Label();
            lblNombre = new Label();
            lblPromedio = new Label();
            txtCodigo = new TextBox();
            txtNombre = new TextBox();
            txtPromedio = new TextBox();
            btnAgregar = new Button();
            btnEliminar = new Button();
            btnOrdenar = new Button();
            btnBuscar = new Button();
            btnMostrar = new Button();
            dgvAlumnos = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCodigo.Location = new Point(7, 16);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(48, 15);
            lblCodigo.TabIndex = 0;
            lblCodigo.Text = "Codigo:";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(7, 61);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(56, 15);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblPromedio
            // 
            lblPromedio.AutoSize = true;
            lblPromedio.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPromedio.Location = new Point(7, 108);
            lblPromedio.Name = "lblPromedio";
            lblPromedio.Size = new Size(64, 15);
            lblPromedio.TabIndex = 2;
            lblPromedio.Text = "Promedio:";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(7, 34);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(235, 23);
            txtCodigo.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(7, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(235, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtPromedio
            // 
            txtPromedio.Location = new Point(7, 126);
            txtPromedio.Name = "txtPromedio";
            txtPromedio.Size = new Size(235, 23);
            txtPromedio.TabIndex = 5;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnAgregar.Location = new Point(7, 170);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(235, 50);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(7, 344);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(235, 50);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnOrdenar
            // 
            btnOrdenar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOrdenar.Location = new Point(201, 352);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(171, 42);
            btnOrdenar.TabIndex = 8;
            btnOrdenar.Text = "Ordenar";
            btnOrdenar.UseVisualStyleBackColor = true;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnBuscar.Location = new Point(6, 261);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(235, 50);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnMostrar.Location = new Point(28, 352);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(167, 42);
            btnMostrar.TabIndex = 10;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            dgvAlumnos.Location = new Point(28, 40);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(344, 306);
            dgvAlumnos.TabIndex = 11;
            // 
            // Column1
            // 
            Column1.HeaderText = "Código";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nombre";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Promedio";
            Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dgvAlumnos);
            groupBox1.Controls.Add(btnMostrar);
            groupBox1.Controls.Add(btnOrdenar);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(263, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 421);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista De Alumnos";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnBuscar);
            groupBox2.Controls.Add(btnEliminar);
            groupBox2.Controls.Add(btnAgregar);
            groupBox2.Controls.Add(txtPromedio);
            groupBox2.Controls.Add(txtNombre);
            groupBox2.Controls.Add(txtCodigo);
            groupBox2.Controls.Add(lblPromedio);
            groupBox2.Controls.Add(lblNombre);
            groupBox2.Controls.Add(lblCodigo);
            groupBox2.Location = new Point(12, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(248, 421);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(99, 9);
            label1.Name = "label1";
            label1.Size = new Size(470, 77);
            label1.TabIndex = 14;
            label1.Text = "ListaAlumnos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 516);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCodigo;
        private Label lblNombre;
        private Label lblPromedio;
        private TextBox txtCodigo;
        private TextBox txtNombre;
        private TextBox txtPromedio;
        private Button btnAgregar;
        private Button btnEliminar;
        private Button btnOrdenar;
        private Button btnBuscar;
        private Button btnMostrar;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label1;
    }
}
