namespace ProyectoBanco
{
    partial class principal
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
            btnNvaCuenta = new Button();
            btnChequera = new Button();
            SuspendLayout();
            // 
            // btnNvaCuenta
            // 
            btnNvaCuenta.Location = new Point(112, 73);
            btnNvaCuenta.Name = "btnNvaCuenta";
            btnNvaCuenta.Size = new Size(104, 30);
            btnNvaCuenta.TabIndex = 0;
            btnNvaCuenta.Text = "Crear Cuenta";
            btnNvaCuenta.UseVisualStyleBackColor = true;
            btnNvaCuenta.Click += btnNvaCuenta_Click;
            // 
            // btnChequera
            // 
            btnChequera.Location = new Point(112, 121);
            btnChequera.Name = "btnChequera";
            btnChequera.Size = new Size(104, 30);
            btnChequera.TabIndex = 1;
            btnChequera.Text = "Mi chequera";
            btnChequera.UseVisualStyleBackColor = true;
            btnChequera.Click += btnChequera_Click;
            // 
            // principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(328, 240);
            Controls.Add(btnChequera);
            Controls.Add(btnNvaCuenta);
            Name = "principal";
            Text = "Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnNvaCuenta;
        private Button btnChequera;
    }
}