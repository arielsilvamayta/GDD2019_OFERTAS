

using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaOfertas.Properties;
using System.Configuration;
using System.Windows.Forms;

namespace FrbaOfertas
{
    public class ConexionSQL
    {
        private SqlConnection conexion;
        private static ConexionSQL conexionObj;

        public ConexionSQL()
        {
        }

        public static ConexionSQL getInstance()
        {
            if (conexionObj == null)
            {
                conexionObj = new ConexionSQL();
            }
            return conexionObj;
        }

        public SqlConnection getConexion()
        {
            return conexion;
        }

        public void conectar(string connectionString)
        {
            conexion = new SqlConnection(connectionString);
            conexion.Open();
        }

        public void desconectar()
        {
            conexion.Close();
        }

        public static String getConfigValue(string param)
        {
            string[] config_params = param.Split('=');
            return config_params[1].Trim();
        }
    }
}
