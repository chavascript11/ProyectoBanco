namespace ProyectoBanco
{
    partial class creaCuenta
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
            lblNumCuenta = new Label();
            lblSaldo = new Label();
            lblUser = new Label();
            lblPass = new Label();
            txtSaldo = new TextBox();
            txtUser = new TextBox();
            txtPass = new TextBox();
            btnCtaCrear = new Button();
            btnCtaCancelar = new Button();
            SuspendLayout();
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(45, 35);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(70, 15);
            lblNumCuenta.TabIndex = 0;
            lblNumCuenta.Text = "No. Cuenta:";
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(45, 66);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(39, 15);
            lblSaldo.TabIndex = 1;
            lblSaldo.Text = "Saldo:";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(39, 124);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 15);
            lblUser.TabIndex = 2;
            lblUser.Text = "Usuario:";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Location = new Point(39, 168);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(57, 15);
            lblPass.TabIndex = 3;
            lblPass.Text = "Password";
            // 
            // txtSaldo
            // 
            txtSaldo.Location = new Point(115, 63);
            txtSaldo.Name = "txtSaldo";
            txtSaldo.Size = new Size(100, 23);
            txtSaldo.TabIndex = 4;
            // 
            // txtUser
            // 
            txtUser.Location = new Point(114, 121);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(100, 23);
            txtUser.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(114, 165);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(100, 23);
            txtPass.TabIndex = 6;
            // 
            // btnCtaCrear
            // 
            btnCtaCrear.Location = new Point(55, 241);
            btnCtaCrear.Name = "btnCtaCrear";
            btnCtaCrear.Size = new Size(75, 23);
            btnCtaCrear.TabIndex = 7;
            btnCtaCrear.Text = "Aceptar";
            btnCtaCrear.UseVisualStyleBackColor = true;
            // 
            // btnCtaCancelar
            // 
            btnCtaCancelar.Location = new Point(168, 241);
            btnCtaCancelar.Name = "btnCtaCancelar";
            btnCtaCancelar.Size = new Size(75, 23);
            btnCtaCancelar.TabIndex = 8;
            btnCtaCancelar.Text = "Cancelar";
            btnCtaCancelar.UseVisualStyleBackColor = true;
            btnCtaCancelar.Click += btnCtaCancelar_Click;
            // 
            // creaCuenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCtaCancelar);
            Controls.Add(btnCtaCrear);
            Controls.Add(txtPass);
            Controls.Add(txtUser);
            Controls.Add(txtSaldo);
            Controls.Add(lblPass);
            Controls.Add(lblUser);
            Controls.Add(lblSaldo);
            Controls.Add(lblNumCuenta);
            Name = "creaCuenta";
            Text = "Crear Cuenta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumCuenta;
        private Label lblSaldo;
        private Label lblUser;
        private Label lblPass;
        private TextBox txtSaldo;
        private TextBox txtUser;
        private TextBox txtPass;
        private Button btnCtaCrear;
        private Button btnCtaCancelar;
    }
}