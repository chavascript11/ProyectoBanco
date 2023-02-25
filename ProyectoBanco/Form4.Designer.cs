namespace ProyectoBanco
{
    partial class miChequera
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
            menuStrip1 = new MenuStrip();
            chequesToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            reportesToolStripMenuItem = new ToolStripMenuItem();
            fechasToolStripMenuItem = new ToolStripMenuItem();
            beneficiToolStripMenuItem = new ToolStripMenuItem();
            folioToolStripMenuItem = new ToolStripMenuItem();
            folioToolStripMenuItem1 = new ToolStripMenuItem();
            ayudaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            manualToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { chequesToolStripMenuItem, reportesToolStripMenuItem, ayudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // chequesToolStripMenuItem
            // 
            chequesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, consultarToolStripMenuItem });
            chequesToolStripMenuItem.Name = "chequesToolStripMenuItem";
            chequesToolStripMenuItem.Size = new Size(65, 20);
            chequesToolStripMenuItem.Text = "Cheques";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.ShortcutKeyDisplayString = "";
            nuevoToolStripMenuItem.Size = new Size(180, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(180, 22);
            consultarToolStripMenuItem.Text = "Consultar";
            // 
            // reportesToolStripMenuItem
            // 
            reportesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fechasToolStripMenuItem, beneficiToolStripMenuItem, folioToolStripMenuItem, folioToolStripMenuItem1 });
            reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            reportesToolStripMenuItem.Size = new Size(65, 20);
            reportesToolStripMenuItem.Text = "Reportes";
            // 
            // fechasToolStripMenuItem
            // 
            fechasToolStripMenuItem.Name = "fechasToolStripMenuItem";
            fechasToolStripMenuItem.Size = new Size(141, 22);
            fechasToolStripMenuItem.Text = "Beneficiarios";
            // 
            // beneficiToolStripMenuItem
            // 
            beneficiToolStripMenuItem.Name = "beneficiToolStripMenuItem";
            beneficiToolStripMenuItem.Size = new Size(141, 22);
            beneficiToolStripMenuItem.Text = "Fechas";
            // 
            // folioToolStripMenuItem
            // 
            folioToolStripMenuItem.Name = "folioToolStripMenuItem";
            folioToolStripMenuItem.Size = new Size(141, 22);
            folioToolStripMenuItem.Text = "Folio";
            // 
            // folioToolStripMenuItem1
            // 
            folioToolStripMenuItem1.Name = "folioToolStripMenuItem1";
            folioToolStripMenuItem1.Size = new Size(141, 22);
            folioToolStripMenuItem1.Text = "Monto";
            // 
            // ayudaToolStripMenuItem
            // 
            ayudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, manualToolStripMenuItem });
            ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            ayudaToolStripMenuItem.Size = new Size(53, 20);
            ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(126, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // manualToolStripMenuItem
            // 
            manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            manualToolStripMenuItem.Size = new Size(126, 22);
            manualToolStripMenuItem.Text = "Manual";
            // 
            // miChequera
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "miChequera";
            Text = "Mi Chequera";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem chequesToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem reportesToolStripMenuItem;
        private ToolStripMenuItem fechasToolStripMenuItem;
        private ToolStripMenuItem beneficiToolStripMenuItem;
        private ToolStripMenuItem folioToolStripMenuItem;
        private ToolStripMenuItem folioToolStripMenuItem1;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripMenuItem manualToolStripMenuItem;
    }
}