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
    public partial class BarcosForm : Form
    {
        public BarcosForm()
        {
            InitializeComponent();
            
        }

        private void cargarBarcosDataGrid()
        {

            string consulta = string.Format($"SELECT matricula, nombre, numeroAmarre ,identificacion FROM barco");
            DataSet ds = Conexion.getQuery(consulta);
            dtgBarcos.DataSource = ds.Tables[0];

        }

        private void llenarComboboxSocios() {
           
            string consulta = string.Format($"SELECT identificacion FROM personas WHERE atributoid = 'SOC' OR atributoid = 'SOCPAT' ");
            combSocio.DataSource = Conexion.getQuery(consulta).Tables[0];
            combSocio.DisplayMember = "identificacion";
            combSocio.ValueMember = "identificacion";
        
        }

        private void llenarComboboxAmarre() {
            string consulta = string.Format($"SELECT amarreid FROM amarre");
            combAmarre.DataSource = Conexion.getQuery(consulta).Tables[0];
            combAmarre.DisplayMember = "amarreid";
            combAmarre.ValueMember = "amarreid";
        }

        private void agregarRegistro() {
            string queryCount = string.Format($"SELECT COUNT(*) FROM barco WHERE matricula = '{txtMatricula.Text}'");
            if (!Validacion.validarSiExisteRegistro(queryCount))
            {
                string consulta = string.Format($"INSERT INTO barco (matricula, nombre, numeroAmarre, identificacion) VALUES ('{txtMatricula.Text}', '{txtNombre.Text}', '{combAmarre.Text}', '{combSocio.Text}')");
                Conexion.getQuery(consulta);
                MessageBox.Show("Se ha agreado un nuevo registro de ruta");
                cargarBarcosDataGrid();
                limpiarFormulario();
            }
            else
            {
                MessageBox.Show("El registro ya existe en la base de datos");
            }
        }

        private void actualizarRegistro() {
            string consulta = string.Format($"UPDATE barco SET nombre = '{txtNombre.Text}', numeroamarre = '{combAmarre.Text}',  identificacion = '{combSocio.Text}' WHERE matricula = '{txtMatricula.Text}'");
            Conexion.getQuery(consulta);

            MessageBox.Show("Se ha actualizando el registro de ruta");
            cargarBarcosDataGrid();
            limpiarFormulario();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Registrar";
            txtMatricula.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Actualizar";
            txtMatricula.Enabled = false;
            limpiarFormulario();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtMatricula.Text != "" && txtNombre.Text != "" && combAmarre.Text != "" && combSocio.Text != "")
            {
                if (btnRegistrar.Text == "Registrar")
                {
                    agregarRegistro();
                }
                else {
                    if (txtMatricula.Text != "")
                    {
                        actualizarRegistro();
                    }
                    else {
                        MessageBox.Show("No se ha seleccionado un registro aun para actualizar");
                    }
                }
            }
            else {
                MessageBox.Show("Aun hay campos que no han sido llenados");
            }
        }

        private void limpiarFormulario() {
            txtMatricula.Text = "";
            txtNombre.Text = "";
            combAmarre.Text = "";
            combSocio.Text = "";
        }

        private void DtgUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatricula.Text = this.dtgBarcos.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dtgBarcos.CurrentRow.Cells[1].Value.ToString();
            combAmarre.Text = this.dtgBarcos.CurrentRow.Cells[2].Value.ToString();
            combSocio.Text = this.dtgBarcos.CurrentRow.Cells[3].Value.ToString();
        }

        private void BarcosForm_Load(object sender, EventArgs e)
        {
            cargarBarcosDataGrid();
            llenarComboboxAmarre();
            llenarComboboxSocios();
        }
    }
}
