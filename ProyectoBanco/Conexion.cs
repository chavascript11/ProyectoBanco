using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBanco
{
    internal class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection conectar = new SqlConnection("SERVER=MAU-PC;DATABASE=Banco;Integrated security = true");
            conectar.Open();
            return conectar;

        }
    }
}
