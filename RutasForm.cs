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
    public partial class RutasForm : Form
    {
        public RutasForm()
        {
            InitializeComponent();
            cargarRutasDataGrid();
        }

        private void cargarRutasDataGrid()
        {
            string consulta = string.Format($"SELECT idRuta, nombre FROM ruta");
            DataSet ds = Conexion.getQuery(consulta);
            dtgUsuarios.DataSource = ds.Tables[0];

        }

        private void agregarRegistro()
        {
            string queryCount = string.Format($"SELECT COUNT(*) FROM ruta WHERE idruta = '{txtIdRuta.Text}'");
            if (!Validacion.validarSiExisteRegistro(queryCount))
            {
                string consulta = string.Format($"INSERT INTO ruta (idruta, nombre) VALUES ('{txtIdRuta.Text}', '{txtNombreRuta.Text}')");
                Conexion.getQuery(consulta);
                MessageBox.Show("Se ha agreado un nuevo registro de ruta");
                cargarRutasDataGrid();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("El registro ya existe en la base de datos");
            }
        }

        private void actualizarRegistro() {
            string consulta = string.Format($"UPDATE ruta SET nombre = '{txtNombreRuta.Text}' WHERE idruta = '{txtIdRuta.Text}'");
            Conexion.getQuery(consulta);


            MessageBox.Show("Se ha actualizando el registro de ruta");
            cargarRutasDataGrid();
            limpiarFormulario();
        }

        private void limpiarFormulario() {
            txtIdRuta.Text = "";
            txtNombreRuta.Text = "";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Registrar";
            txtIdRuta.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Actualizar";
            txtIdRuta.Enabled = false;
            limpiarFormulario();
        }

        private void DtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtIdRuta.Text = this.dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombreRuta.Text = this.dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdRuta.Text != "" && txtNombreRuta.Text != "")
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    agregarRegistro();
                }
                else
                {
                    if (txtIdRuta.Text != "")
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
    }
}
