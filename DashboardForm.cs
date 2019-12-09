using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialBrayan
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            /*
             1) El nombre del socio de un barco en particular.

                  SELECT socios.nombre AS Socio FROM barco
                  INNER JOIN socios ON socios.identificacion = barco.identificacionSocio
                  WHERE matricula = '1233'

              2) La navegación de un barco en particular.

                  SELECT idOperacion, matriculaBarco, identificacionCapitan, fecha, destino FROM salidas WHERE matriculaBarco = '123'

              
              3) Dada la fecha muestre los barcos que saldrán en esa fecha.
                
                  SELECT matriculaBarco, fecha FROM salidas WHERE fecha = '2019-01-01' 

              4) Dado el barco me muestre el nombre del patrón del socio y la navegación de este.
                
                
                SELECT capitan.nombre AS Patron, socios.nombre AS Socio FROM salidas
                INNER JOIN socios ON socios.identificacion = barco.identificacionSocio
                INNER JOIN capitan ON capitan.identificacion = salidas.identificacionCapitan
                WHERE matriculaBarco = '1233'



                
            */
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            llenarComboboxBarco();
        }

        private void llenarComboboxBarco() {
            string consulta = string.Format($"SELECT matricula FROM barco");
            combBarco1.DataSource = Conexion.getQuery(consulta).Tables[0];
            combBarco1.DisplayMember = "matricula";
            combBarco1.ValueMember = "matricula";

            combBarco2.DataSource = Conexion.getQuery(consulta).Tables[0];
            combBarco2.DisplayMember = "matricula";
            combBarco2.ValueMember = "matricula";

            combBarco3.DataSource = Conexion.getQuery(consulta).Tables[0];
            combBarco3.DisplayMember = "matricula";
            combBarco3.ValueMember = "matricula";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string consulta = string.Format($"SELECT matricula FROM barco WHERE matricula = 'B01'");
            lbSocio.Text = Conexion.getQuery(consulta).Tables[0].ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string consulta = string.Format($"SELECT idoperacion, personas.nombre AS Capitan, fecha, ruta.nombre FROM salidas INNER JOIN barco ON barco.matricula = salidas.matriculabarco INNER JOIN personas ON personas.identificacion = salidas.identificacion INNER JOIN ruta ON ruta.idruta = salidas.destino WHERE matriculabarco = '{combBarco1.Text}'");
            dtgNavegacion.DataSource = Conexion.getQuery(consulta).Tables[0];
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dtFecha.Value.ToString());
            string consulta = string.Format($"SELECT idoperacion, barco.matricula, personas.nombre AS Capitan, fecha, ruta.nombre FROM salidas INNER JOIN barco ON barco.matricula = salidas.matriculabarco INNER JOIN personas ON personas.identificacion = salidas.identificacion INNER JOIN ruta ON ruta.idruta = salidas.destino WHERE fecha = '{dtFecha.Value}'");
            dtgSalidasFecha.DataSource = Conexion.getQuery(consulta).Tables[0];

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            string consulta = string.Format($"SELECT personas.nombre AS Capitan, barco.identificacion AS Socio, fecha, ruta.nombre FROM salidas INNER JOIN barco ON barco.matricula = salidas.matriculabarco INNER JOIN personas ON personas.identificacion = salidas.identificacion INNER JOIN ruta ON ruta.idruta = salidas.destino WHERE matriculaBarco = '{combBarco3.Text}'");
            dtgInfoBarco.DataSource = Conexion.getQuery(consulta).Tables[0];
        }
    }
}
