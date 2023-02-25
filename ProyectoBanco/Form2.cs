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
    public partial class creaCuenta : Form
    {
        public creaCuenta()
        {
            InitializeComponent();
        }

        private void btnCtaCancelar_Click(object sender, EventArgs e)
        {
            principal principal = new principal();
            this.Close();
        }
    }
}
