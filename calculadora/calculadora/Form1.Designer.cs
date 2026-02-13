namespace calculadora
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
            but1 = new Button();
            but2 = new Button();
            suma = new Button();
            but9 = new Button();
            but8 = new Button();
            but7 = new Button();
            but6 = new Button();
            but4 = new Button();
            but3 = new Button();
            but5 = new Button();
            igual = new Button();
            but0 = new Button();
            resta = new Button();
            pantalla = new TextBox();
            Multiplicar = new Button();
            button2 = new Button();
            Clear = new Button();
            SuspendLayout();
            // 
            // but1
            // 
            but1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but1.Location = new Point(15, 87);
            but1.Name = "but1";
            but1.Size = new Size(78, 66);
            but1.TabIndex = 0;
            but1.Text = "1";
            but1.UseVisualStyleBackColor = true;
            but1.Click += Numeros_Click;
            // 
            // but2
            // 
            but2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            but2.Location = new Point(99, 87);
            but2.Name = "but2";
            but2.Size = new Size(78, 66);
            but2.TabIndex = 1;
            but2.Text = "2";
            but2.UseVisualStyleBackColor = true;
            but2.Click += Numeros_Click;
            // 
            // suma
            // 
            suma.BackColor = Color.DeepSkyBlue;
            suma.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            suma.Location = new Point(267, 159);
            suma.Name = "suma";
            suma.Size = new Size(78, 95);
            suma.TabIndex = 2;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = false;
            suma.Click += suma_Click;
            // 
            // but9
            // 
            but9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but9.Location = new Point(183, 231);
            but9.Name = "but9";
            but9.Size = new Size(78, 66);
            but9.TabIndex = 3;
            but9.Text = "9";
            but9.UseVisualStyleBackColor = true;
            but9.Click += Numeros_Click;
            // 
            // but8
            // 
            but8.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but8.Location = new Point(99, 231);
            but8.Name = "but8";
            but8.Size = new Size(78, 66);
            but8.TabIndex = 4;
            but8.Text = "8";
            but8.UseVisualStyleBackColor = true;
            but8.Click += Numeros_Click;
            // 
            // but7
            // 
            but7.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but7.Location = new Point(15, 231);
            but7.Name = "but7";
            but7.Size = new Size(78, 66);
            but7.TabIndex = 5;
            but7.Text = "7";
            but7.UseVisualStyleBackColor = true;
            but7.Click += Numeros_Click;
            // 
            // but6
            // 
            but6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but6.Location = new Point(183, 159);
            but6.Name = "but6";
            but6.Size = new Size(78, 66);
            but6.TabIndex = 6;
            but6.Text = "6";
            but6.UseVisualStyleBackColor = true;
            but6.Click += Numeros_Click;
            // 
            // but4
            // 
            but4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but4.Location = new Point(15, 159);
            but4.Name = "but4";
            but4.Size = new Size(78, 66);
            but4.TabIndex = 7;
            but4.Text = "4";
            but4.UseVisualStyleBackColor = true;
            but4.Click += Numeros_Click;
            // 
            // but3
            // 
            but3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but3.Location = new Point(183, 87);
            but3.Name = "but3";
            but3.Size = new Size(78, 66);
            but3.TabIndex = 8;
            but3.Text = "3";
            but3.UseVisualStyleBackColor = true;
            but3.Click += Numeros_Click;
            // 
            // but5
            // 
            but5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but5.Location = new Point(99, 159);
            but5.Name = "but5";
            but5.Size = new Size(78, 66);
            but5.TabIndex = 9;
            but5.Text = "5";
            but5.UseVisualStyleBackColor = true;
            but5.Click += Numeros_Click;
            // 
            // igual
            // 
            igual.BackColor = Color.FromArgb(128, 255, 128);
            igual.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            igual.Location = new Point(99, 375);
            igual.Name = "igual";
            igual.Size = new Size(246, 66);
            igual.TabIndex = 10;
            igual.Text = "=";
            igual.UseVisualStyleBackColor = false;
            igual.Click += igual_Click;
            // 
            // but0
            // 
            but0.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            but0.Location = new Point(15, 303);
            but0.Name = "but0";
            but0.Size = new Size(78, 66);
            but0.TabIndex = 11;
            but0.Text = "0";
            but0.UseVisualStyleBackColor = true;
            but0.Click += Numeros_Click;
            // 
            // resta
            // 
            resta.BackColor = Color.FromArgb(255, 128, 128);
            resta.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            resta.Location = new Point(267, 260);
            resta.Name = "resta";
            resta.Size = new Size(78, 109);
            resta.TabIndex = 12;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = false;
            resta.Click += resta_Click;
            // 
            // pantalla
            // 
            pantalla.BorderStyle = BorderStyle.FixedSingle;
            pantalla.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pantalla.Location = new Point(12, 12);
            pantalla.Name = "pantalla";
            pantalla.ReadOnly = true;
            pantalla.Size = new Size(333, 57);
            pantalla.TabIndex = 13;
            pantalla.Text = "0";
            pantalla.TextAlign = HorizontalAlignment.Right;
            pantalla.Click += Numeros_Click;
            pantalla.TextChanged += pantalla_TextChanged;
            // 
            // Multiplicar
            // 
            Multiplicar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Multiplicar.Location = new Point(99, 303);
            Multiplicar.Name = "Multiplicar";
            Multiplicar.Size = new Size(162, 66);
            Multiplicar.TabIndex = 14;
            Multiplicar.Text = "X";
            Multiplicar.UseVisualStyleBackColor = true;
            Multiplicar.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            button2.Location = new Point(15, 375);
            button2.Name = "button2";
            button2.Size = new Size(78, 66);
            button2.TabIndex = 15;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Clear
            // 
            Clear.BackColor = Color.White;
            Clear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Clear.Location = new Point(267, 87);
            Clear.Name = "Clear";
            Clear.Size = new Size(78, 66);
            Clear.TabIndex = 16;
            Clear.Text = "C";
            Clear.UseVisualStyleBackColor = false;
            Clear.Click += Clear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(359, 447);
            Controls.Add(Clear);
            Controls.Add(button2);
            Controls.Add(Multiplicar);
            Controls.Add(pantalla);
            Controls.Add(resta);
            Controls.Add(but0);
            Controls.Add(igual);
            Controls.Add(but5);
            Controls.Add(but3);
            Controls.Add(but4);
            Controls.Add(but6);
            Controls.Add(but7);
            Controls.Add(but8);
            Controls.Add(but9);
            Controls.Add(suma);
            Controls.Add(but2);
            Controls.Add(but1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button but1;
        private Button but2;
        private Button suma;
        private Button but9;
        private Button but8;
        private Button but7;
        private Button but6;
        private Button but4;
        private Button but3;
        private Button but5;
        private Button igual;
        private Button but0;
        private Button resta;
        private TextBox pantalla;
        private Button Multiplicar;
        private Button button2;
        private Button Clear;
    }
}
