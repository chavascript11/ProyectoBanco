namespace ProyectoBanco
{
    partial class login
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
            lblLgnUser = new Label();
            lblLgnPass = new Label();
            txtLgnUser = new TextBox();
            txtLgnPass = new TextBox();
            btnLgnAceptar = new Button();
            btnLgnCancelar = new Button();
            SuspendLayout();
            // 
            // lblLgnUser
            // 
            lblLgnUser.AutoSize = true;
            lblLgnUser.Location = new Point(55, 37);
            lblLgnUser.Name = "lblLgnUser";
            lblLgnUser.Size = new Size(50, 15);
            lblLgnUser.TabIndex = 0;
            lblLgnUser.Text = "Usuario:";
            // 
            // lblLgnPass
            // 
            lblLgnPass.AutoSize = true;
            lblLgnPass.Location = new Point(45, 74);
            lblLgnPass.Name = "lblLgnPass";
            lblLgnPass.Size = new Size(60, 15);
            lblLgnPass.TabIndex = 1;
            lblLgnPass.Text = "Password:";
            // 
            // txtLgnUser
            // 
            txtLgnUser.Location = new Point(122, 34);
            txtLgnUser.Name = "txtLgnUser";
            txtLgnUser.Size = new Size(100, 23);
            txtLgnUser.TabIndex = 2;
            // 
            // txtLgnPass
            // 
            txtLgnPass.Location = new Point(122, 71);
            txtLgnPass.Name = "txtLgnPass";
            txtLgnPass.PasswordChar = '*';
            txtLgnPass.Size = new Size(100, 23);
            txtLgnPass.TabIndex = 3;
            // 
            // btnLgnAceptar
            // 
            btnLgnAceptar.Location = new Point(54, 131);
            btnLgnAceptar.Name = "btnLgnAceptar";
            btnLgnAceptar.Size = new Size(75, 23);
            btnLgnAceptar.TabIndex = 4;
            btnLgnAceptar.Text = "Aceptar";
            btnLgnAceptar.UseVisualStyleBackColor = true;
            // 
            // btnLgnCancelar
            // 
            btnLgnCancelar.Location = new Point(162, 131);
            btnLgnCancelar.Name = "btnLgnCancelar";
            btnLgnCancelar.Size = new Size(75, 23);
            btnLgnCancelar.TabIndex = 5;
            btnLgnCancelar.Text = "Cancelar";
            btnLgnCancelar.UseVisualStyleBackColor = true;
            btnLgnCancelar.Click += btnLgnCancelar_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(286, 220);
            Controls.Add(btnLgnCancelar);
            Controls.Add(btnLgnAceptar);
            Controls.Add(txtLgnPass);
            Controls.Add(txtLgnUser);
            Controls.Add(lblLgnPass);
            Controls.Add(lblLgnUser);
            Name = "login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLgnUser;
        private Label lblLgnPass;
        private TextBox txtLgnUser;
        private TextBox txtLgnPass;
        private Button btnLgnAceptar;
        private Button btnLgnCancelar;
    }
}