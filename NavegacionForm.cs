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
    public partial class NavegacionForm : Form
    {
        public NavegacionForm()
        {
            InitializeComponent();
        }

        private void cargarNavegacionDataGrid()
        {
            string consulta = string.Format($"SELECT idOperacion, matriculaBarco, identificacion,fecha, destino FROM salidas");
            DataSet ds = Conexion.getQuery(consulta);

            if (ds != null)
            {
                dtgNavegacion.DataSource = ds.Tables[0];
            }
        }

        private void llenarComboBoxRutas()
        {
            string consulta = string.Format($"SELECT idRuta FROM ruta");
            combDestino.DataSource = Conexion.getQuery(consulta).Tables[0];
            combDestino.DisplayMember = "idRuta";
            combDestino.ValueMember = "idRuta";
        }

        private void llenarComboBoxPatrones()
        {
            string consulta = string.Format($"SELECT identificacion FROM personas WHERE atributoid = 'SOC' OR atributoid = 'SOCPAT'");
            combPatron.DataSource = Conexion.getQuery(consulta).Tables[0];
            combPatron.DisplayMember = "identificacion";
            combPatron.ValueMember = "identificacion";
        }

        private void llenarComboBoxBarcos()
        {
            string consulta = string.Format($"SELECT matricula FROM barco");
            combMatricula.DataSource = Conexion.getQuery(consulta).Tables[0];
            combMatricula.DisplayMember = "matricula";
            combMatricula.ValueMember = "matricula";
        }

        private void agregarRegistro() {
            string consulta = string.Format($"INSERT INTO salidas (matriculaBarco, identificacion, destino) VALUES ('{combMatricula.Text}','{combPatron.Text}','{combDestino.Text}')");
            Conexion.getQuery(consulta);
            MessageBox.Show("Se ha agregado un nuevo registro de navegacion");
            cargarNavegacionDataGrid();
            limpiarFormulario();
        }

        private void actualizarRegistro() {
            string consulta = string.Format($"UPDATE salidas SET matriculaBarco = '{combMatricula.Text}', identificacion = '{combPatron.Text}', destino = '{combDestino.Text}' WHERE idoperacion = '{txtIdOperacion.Text}'");
            Conexion.getQuery(consulta);
            MessageBox.Show("Se ha actualizado el registro de navegacion");
            cargarNavegacionDataGrid();
            limpiarFormulario();
        }


        private void RadioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Registrar";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Actualizar";
            limpiarFormulario();
        }

        private void limpiarFormulario()
        {
            txtIdOperacion.Text = "";
            combMatricula.Text = "";
            combPatron.Text = "";
            combDestino.Text = "";
        }

        private void NavegacionForm_Load(object sender, EventArgs e)
        {
            cargarNavegacionDataGrid();
            llenarComboBoxRutas();
            llenarComboBoxBarcos();
            llenarComboBoxPatrones();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (combMatricula.Text != "" && combPatron.Text != "" && combDestino.Text != "")
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    agregarRegistro();
                }
                else
                {
                    if (txtIdOperacion.Text != "")
                    {
                        actualizarRegistro();
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado un registro aun para actualizar");
                    }

                }
            }
            else {
                MessageBox.Show("Aun hay campos que no han sido llenados");
            }
        }

        private void DtgNavegacion_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdOperacion.Text = this.dtgNavegacion.CurrentRow.Cells[0].Value.ToString();
            combMatricula.Text = this.dtgNavegacion.CurrentRow.Cells[1].Value.ToString();
            combPatron.Text = this.dtgNavegacion.CurrentRow.Cells[2].Value.ToString();
            combDestino.Text = this.dtgNavegacion.CurrentRow.Cells[4].Value.ToString();

        }
    }
}
