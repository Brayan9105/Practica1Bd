using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SegundoParcialBrayan
{
    
    static class Conexion
    {
     

        public static DataSet getQuery(string cmd) {
            DataSet ds = null;
            try {
                MySqlConnection conexion = new MySqlConnection("server=127.0.0.1;database=segundoparcial;Uid=root;pwd=;");
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd, conexion);

                DataSet dsAux = new DataSet();
                adapter.Fill(dsAux);
                ds = dsAux;
            } catch (Exception e) {
                MessageBox.Show("Ha ocurrido un problema para conectarse con la base de datos:\n"+e.Message);
            }
            
            return ds;
        }

    }
}
