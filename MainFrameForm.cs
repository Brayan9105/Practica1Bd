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
    public partial class MainFrameForm : Form
    {
        public MainFrameForm(string roll)
        {
            InitializeComponent();
            if (roll != "Admin") {
                btnUsuarios.Hide();
            }
        }


        Form currentForm = null;
        private void openChildForm(Form childForm)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new DashboardForm());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosForm());
        }

        private void BtnProductos_Click(object sender, EventArgs e)
        {
            openChildForm(new UsuariosForm());
        }

        private void BtnVentas_Click(object sender, EventArgs e)
        {
            openChildForm(new BarcosForm());
        }

        

        private void BtnRutas_Click(object sender, EventArgs e)
        {
            openChildForm(new RutasForm());
        }

        private void BtnSalirMain_Click(object sender, EventArgs e)
        {
            this.Close();
            //LoginForm login = new LoginForm();
            //login.Show();
            
        }

        private void Navegacion_Click(object sender, EventArgs e)
        {
            openChildForm(new NavegacionForm());
        }
    }
}
