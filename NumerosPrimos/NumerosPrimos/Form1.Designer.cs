namespace NumerosPrimos
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
            textBoxInicio = new TextBox();
            textBoxFin = new TextBox();
            buttonBuscar = new Button();
            listBoxPrimos = new ListBox();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxInicio
            // 
            textBoxInicio.Location = new Point(12, 124);
            textBoxInicio.Name = "textBoxInicio";
            textBoxInicio.Size = new Size(204, 23);
            textBoxInicio.TabIndex = 0;
            // 
            // textBoxFin
            // 
            textBoxFin.Location = new Point(12, 189);
            textBoxFin.Name = "textBoxFin";
            textBoxFin.Size = new Size(204, 23);
            textBoxFin.TabIndex = 1;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.White;
            buttonBuscar.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonBuscar.Location = new Point(12, 237);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(378, 84);
            buttonBuscar.TabIndex = 2;
            buttonBuscar.Text = "ENTER";
            buttonBuscar.UseVisualStyleBackColor = false;
            buttonBuscar.Click += buttonBuscar_Click;
            // 
            // listBoxPrimos
            // 
            listBoxPrimos.BackColor = SystemColors.ButtonFace;
            listBoxPrimos.BorderStyle = BorderStyle.FixedSingle;
            listBoxPrimos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxPrimos.FormattingEnabled = true;
            listBoxPrimos.Location = new Point(222, 77);
            listBoxPrimos.Name = "listBoxPrimos";
            listBoxPrimos.Size = new Size(168, 152);
            listBoxPrimos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(91, 96);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 4;
            label1.Text = "Del";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 9);
            label3.Name = "label3";
            label3.Size = new Size(195, 32);
            label3.TabIndex = 6;
            label3.Text = "Numero Primos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(91, 161);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 7;
            label2.Text = "Asta";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(411, 338);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(listBoxPrimos);
            Controls.Add(buttonBuscar);
            Controls.Add(textBoxFin);
            Controls.Add(textBoxInicio);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInicio;
        private TextBox textBoxFin;
        private Button buttonBuscar;
        private ListBox listBoxPrimos;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}
