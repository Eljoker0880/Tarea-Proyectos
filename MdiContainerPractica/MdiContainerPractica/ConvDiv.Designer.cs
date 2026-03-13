namespace MdiContainerPractica
{
    partial class ConvDiv
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtResultado = new TextBox();
            txtCantidad = new TextBox();
            cmbDe = new ComboBox();
            cmbA = new ComboBox();
            button1 = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label1.Location = new Point(14, 81);
            label1.Name = "label1";
            label1.Size = new Size(29, 17);
            label1.TabIndex = 0;
            label1.Text = "De:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label2.Location = new Point(14, 267);
            label2.Name = "label2";
            label2.Size = new Size(79, 17);
            label2.TabIndex = 1;
            label2.Text = "Resultados:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(14, 133);
            label3.Name = "label3";
            label3.Size = new Size(67, 17);
            label3.TabIndex = 2;
            label3.Text = "Cantidad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            label4.Location = new Point(163, 81);
            label4.Name = "label4";
            label4.Size = new Size(21, 17);
            label4.TabIndex = 3;
            label4.Text = "A:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(14, 285);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(278, 23);
            txtResultado.TabIndex = 4;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(14, 151);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(132, 23);
            txtCantidad.TabIndex = 5;
            txtCantidad.TextChanged += textBox2_TextChanged;
            // 
            // cmbDe
            // 
            cmbDe.FormattingEnabled = true;
            cmbDe.Items.AddRange(new object[] { "Peso", "", "Dólar", "", "Euro" });
            cmbDe.Location = new Point(49, 80);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(108, 23);
            cmbDe.TabIndex = 6;
            // 
            // cmbA
            // 
            cmbA.FormattingEnabled = true;
            cmbA.Items.AddRange(new object[] { "Peso", "", "Dólar", "", "Euro" });
            cmbA.Location = new Point(187, 80);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(108, 23);
            cmbA.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(14, 191);
            button1.Name = "button1";
            button1.Size = new Size(270, 57);
            button1.TabIndex = 8;
            button1.Text = "COMBERTIR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(49, 9);
            label5.Name = "label5";
            label5.Size = new Size(213, 30);
            label5.TabIndex = 9;
            label5.Text = "Conversor de divisas";
            // 
            // ConvDiv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 325);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(cmbA);
            Controls.Add(cmbDe);
            Controls.Add(txtCantidad);
            Controls.Add(txtResultado);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ConvDiv";
            Text = "ConvDiv";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtResultado;
        private TextBox txtCantidad;
        private ComboBox cmbDe;
        private ComboBox cmbA;
        private Button button1;
        private Label label5;
    }
}