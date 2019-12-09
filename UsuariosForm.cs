using System;
using System.Collections;
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
    public partial class UsuariosForm : Form
    {
        public UsuariosForm()
        {
            InitializeComponent();
            
        }

        private void cargarSociosDataGrid()
        {
            string consulta = string.Format($"SELECT personas.identificacion, nombre, apellido, telefono, direccion, correo, atributoid, usuarios.user AS usuario, usuarios.passw AS password, usuarios.roll AS roll  FROM personas INNER JOIN usuarios ON usuarios.identificacion = personas.identificacion");
            DataSet ds = Conexion.getQuery(consulta);
            
            if (ds != null) {
                dtgUsuarios.DataSource = ds.Tables[0];
            }   
        }

        private void llenarComboBoxAtributos()
        {
            string consulta = string.Format($"SELECT atributoid FROM atributos");
            combAtributos.DataSource = Conexion.getQuery(consulta).Tables[0];
            combAtributos.DisplayMember = "atributoid";
            combAtributos.ValueMember = "atributoid";
        }



        private void agregarRegistro() {

            string queryCount = string.Format($"SELECT COUNT(*) FROM personas WHERE identificacion = '{txtIdentificacion.Text}'");
            if (!Validacion.validarSiExisteRegistro(queryCount))
            {
                queryCount = string.Format($"SELECT COUNT(*) FROM usuarios WHERE user = '{txtUsuario.Text}'");
                if (Validacion.validarSiExisteRegistro(queryCount))
                {
                    MessageBox.Show("El usuario ya existe en la base de datos");
                }else{
                    string consulta = string.Format($"INSERT INTO personas (identificacion, nombre, apellido, telefono, direccion, correo, atributoid) VALUES ('{txtIdentificacion.Text}','{txtNombre.Text}','{txtApellido.Text}','{txtTelefono.Text}','{txtDireccion.Text}','{txtCorreo.Text}', '{combAtributos.Text}')");
                    Conexion.getQuery(consulta);

                    consulta = string.Format($"INSERT INTO usuarios (identificacion, user, passw, roll) VALUES ('{txtIdentificacion.Text}', '{txtUsuario.Text}', '{txtPassword.Text}','{combRoll.Text}')");
                    Conexion.getQuery(consulta);

                    MessageBox.Show("Se ha agreado un nuevo socio");
                    cargarSociosDataGrid();
                    limpiarFormulario();
                }
                
            }else{
                MessageBox.Show("El registro ya existe en la base de datos");
            }
        }

        private void actualizarRegistro() {

            string consulta = string.Format($"UPDATE personas SET nombre = '{txtNombre.Text}', apellido =  '{txtApellido.Text}', telefono = '{txtTelefono.Text}', direccion = '{txtDireccion.Text}', correo = '{txtCorreo.Text}', atributoid = '{combAtributos.Text}' WHERE identificacion = '{txtIdentificacion.Text}'");
            Conexion.getQuery(consulta);

            consulta = string.Format($"UPDATE usuarios SET passw = '{txtPassword.Text}', roll =  '{combRoll.Text}' WHERE user = '{txtUsuario.Text}'");
            Conexion.getQuery(consulta);

            MessageBox.Show("Se ha actualizando el registro");
            cargarSociosDataGrid();
            limpiarFormulario();
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtIdentificacion.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtTelefono.Text != "" && txtCorreo.Text != "" && txtDireccion.Text != "" && txtUsuario.Text != "" && txtPassword.Text != "")
            {
                if (!Validacion.emailValid(txtCorreo.Text)){
                    MessageBox.Show("Problemas con el correo electronico");
                }else {
                    if (Validacion.validarPassword(txtPassword.Text)) {
                        if (btnRegistrar.Text == "Registrar"){
                            agregarRegistro();
                        }
                        else{
                            actualizarRegistro();
                        }
                    }
                } 
            }else {
                MessageBox.Show("Ha olvidado llenar todos los campos del registro");
            }
        }



        private void DtgUsuarios_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIdentificacion.Text = this.dtgUsuarios.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = this.dtgUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtApellido.Text = this.dtgUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtTelefono.Text = this.dtgUsuarios.CurrentRow.Cells[3].Value.ToString();
            txtDireccion.Text = this.dtgUsuarios.CurrentRow.Cells[4].Value.ToString();
            txtCorreo.Text = this.dtgUsuarios.CurrentRow.Cells[5].Value.ToString();
            combAtributos.Text = dtgUsuarios.CurrentRow.Cells[6].Value.ToString();
            txtUsuario.Text = this.dtgUsuarios.CurrentRow.Cells[7].Value.ToString();
            txtPassword.Text = this.dtgUsuarios.CurrentRow.Cells[8].Value.ToString();
            combRoll.Text = dtgUsuarios.CurrentRow.Cells[9].Value.ToString();

        }

        private void limpiarFormulario() {
            txtIdentificacion.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtCorreo.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            combRoll.Text = "";
            combAtributos.Text = "";
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Registrar";
            txtIdentificacion.Enabled = true;
            txtUsuario.Enabled = true;
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            btnRegistrar.Text = "Actualizar";
            txtIdentificacion.Enabled = false;
            txtUsuario.Enabled = false;
            limpiarFormulario();
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto(sender, e);
        }

        private void TxtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void TxtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloTexto(sender, e);
        }

        private void TxtIdentificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validacion.soloNumeros(sender, e);
        }

        private void SociosForm_Load(object sender, EventArgs e)
        {
            cargarSociosDataGrid();
            llenarComboBoxAtributos();
        }
    }
}
