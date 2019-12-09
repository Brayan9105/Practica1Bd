using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundoParcialBrayan
{
    public static class Validacion
    {
        public static void soloTexto(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }

        }

        public static void soloNumeros(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }

            }
        }

        public static bool emailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);

                return true;
            }
            catch (FormatException)
            {
                return false;
            }
        }

        

        public static bool validarSiExisteRegistro(string queryCount) {
            bool existe = false;
            try
            {
                string consulta = queryCount;

                DataSet ds = Conexion.getQuery(consulta);
                int registros = Convert.ToInt32(ds.Tables[0].Rows[0][0]);

                if (registros > 0)
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un erro: \n" + error.Message);
            }

            return existe;
        }


        public static bool validarPassword(string password) {
            bool valido = false;
            int contMayus = 0, contNumeros=0, contPunto=0;

            if (password.Length >= 6)
            {
                char[] letras = password.ToCharArray();

                for (int i = 0; i < password.Length; i++)
                {
                    if (letras[i].Equals('.'))
                    {
                        contPunto++;
                    }

                    if (letras[i].ToString().Equals(letras[i].ToString().ToUpper()) && char.IsLetter(letras[i]))
                    {
                        contMayus++;
                    }

                    if (char.IsDigit(letras[i]))
                    {
                        contNumeros++;
                    }

                }

                if (contNumeros >= 2 && contPunto >= 1 && contMayus >= 1)
                {
                    valido = true;
                }
                else
                {
                    MessageBox.Show("El password debe contener minimo:\n2 Numeros\n1 Punto\n1 Mayuscula");
                }
            }
            else {
                MessageBox.Show("El password debe contener minimo 6 caracteres");
            }

            
            return valido;
        }

    }
}
