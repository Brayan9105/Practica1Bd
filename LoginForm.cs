using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace SegundoParcialBrayan
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login()
        {

            try
            {

                string queryCount = string.Format($"select COUNT(*) FROM usuarios WHERE user = '{txtIdentificacion.Text.Trim()}'");
                if (Validacion.validarSiExisteRegistro(queryCount)) {
                    
                    string consulta = string.Format($"select user, passw, roll FROM usuarios WHERE user = '{txtIdentificacion.Text.Trim()}' AND passw = '{txtPassword.Text.Trim()}'");
                    DataSet ds = Conexion.getQuery(consulta);
                    
                    string identificacion = ds.Tables[0].Rows[0]["user"].ToString().Trim();
                    string password = ds.Tables[0].Rows[0]["passw"].ToString().Trim();
                    string roll = ds.Tables[0].Rows[0]["roll"].ToString().Trim();


                    if (identificacion == txtIdentificacion.Text.Trim() && password == txtPassword.Text.Trim())
                    {
                        MessageBox.Show("Acceso autorizado");
                        MainFrameForm main = new MainFrameForm(roll);
                        main.Show();
                        this.Hide();
                    }
                }

                
            }
            catch (Exception error)
            {
                MessageBox.Show("Password o contraseña incorrecta");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}
