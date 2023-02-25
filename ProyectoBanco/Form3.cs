using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBanco
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLgnCancelar_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            this.Close();
        }
    }
}
