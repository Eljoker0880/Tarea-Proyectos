namespace MdiContainerPractica
{
    partial class SerFib
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
            txtResultado = new TextBox();
            btnGenerar = new Button();
            txtLimite = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 90);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Limite:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 253);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Resultado:";
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(12, 271);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.ScrollBars = ScrollBars.Vertical;
            txtResultado.Size = new Size(198, 23);
            txtResultado.TabIndex = 2;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerar.Location = new Point(12, 156);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(198, 60);
            btnGenerar.TabIndex = 3;
            btnGenerar.Text = "GENERAR";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += button1_Click;
            // 
            // txtLimite
            // 
            txtLimite.Location = new Point(12, 108);
            txtLimite.Name = "txtLimite";
            txtLimite.Size = new Size(100, 23);
            txtLimite.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 9);
            label3.Name = "label3";
            label3.Size = new Size(190, 30);
            label3.TabIndex = 5;
            label3.Text = "Serie de Fibonacci";
            // 
            // SerFib
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(232, 318);
            Controls.Add(label3);
            Controls.Add(txtLimite);
            Controls.Add(btnGenerar);
            Controls.Add(txtResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "SerFib";
            Text = "SerFib";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtResultado;
        private Button btnGenerar;
        private TextBox txtLimite;
        private Label label3;
    }
}