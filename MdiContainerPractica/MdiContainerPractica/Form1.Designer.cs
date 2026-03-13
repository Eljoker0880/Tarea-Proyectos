namespace MdiContainerPractica
{
    partial class FormMDI
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
            menuStrip1 = new MenuStrip();
            registroDeDatosPersonalesToolStripMenuItem = new ToolStripMenuItem();
            conversorDeDivisasToolStripMenuItem = new ToolStripMenuItem();
            serieDeFibonacciToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { registroDeDatosPersonalesToolStripMenuItem, conversorDeDivisasToolStripMenuItem, serieDeFibonacciToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // registroDeDatosPersonalesToolStripMenuItem
            // 
            registroDeDatosPersonalesToolStripMenuItem.Name = "registroDeDatosPersonalesToolStripMenuItem";
            registroDeDatosPersonalesToolStripMenuItem.Size = new Size(170, 20);
            registroDeDatosPersonalesToolStripMenuItem.Text = "Registro de Datos Personales";
            registroDeDatosPersonalesToolStripMenuItem.Click += registroDeDatosPersonalesToolStripMenuItem_Click;
            // 
            // conversorDeDivisasToolStripMenuItem
            // 
            conversorDeDivisasToolStripMenuItem.Name = "conversorDeDivisasToolStripMenuItem";
            conversorDeDivisasToolStripMenuItem.Size = new Size(127, 20);
            conversorDeDivisasToolStripMenuItem.Text = "Conversor de divisas";
            conversorDeDivisasToolStripMenuItem.Click += conversorDeDivisasToolStripMenuItem_Click;
            // 
            // serieDeFibonacciToolStripMenuItem
            // 
            serieDeFibonacciToolStripMenuItem.Name = "serieDeFibonacciToolStripMenuItem";
            serieDeFibonacciToolStripMenuItem.Size = new Size(114, 20);
            serieDeFibonacciToolStripMenuItem.Text = "Serie de Fibonacci";
            serieDeFibonacciToolStripMenuItem.Click += serieDeFibonacciToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Location = new Point(0, 428);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 22);
            statusStrip1.TabIndex = 2;
            statusStrip1.Text = "statusStrip1";
            // 
            // FormMDI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormMDI";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem conversorDeDivisasToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripMenuItem serieDeFibonacciToolStripMenuItem;
        private ToolStripMenuItem registroDeDatosPersonalesToolStripMenuItem;
    }
}
