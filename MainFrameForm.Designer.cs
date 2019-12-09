namespace SegundoParcialBrayan
{
    partial class MainFrameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Navegacion = new System.Windows.Forms.Button();
            this.btnRutas = new System.Windows.Forms.Button();
            this.btnBarcos = new System.Windows.Forms.Button();
            this.btnSalirMain = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.Navegacion);
            this.panel1.Controls.Add(this.btnRutas);
            this.panel1.Controls.Add(this.btnBarcos);
            this.panel1.Controls.Add(this.btnSalirMain);
            this.panel1.Controls.Add(this.btnUsuarios);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 506);
            this.panel1.TabIndex = 2;
            // 
            // Navegacion
            // 
            this.Navegacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.Navegacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.Navegacion.FlatAppearance.BorderSize = 0;
            this.Navegacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Navegacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Navegacion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Navegacion.Location = new System.Drawing.Point(0, 295);
            this.Navegacion.Name = "Navegacion";
            this.Navegacion.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.Navegacion.Size = new System.Drawing.Size(156, 33);
            this.Navegacion.TabIndex = 12;
            this.Navegacion.Text = "Navegacion";
            this.Navegacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Navegacion.UseVisualStyleBackColor = false;
            this.Navegacion.Click += new System.EventHandler(this.Navegacion_Click);
            // 
            // btnRutas
            // 
            this.btnRutas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnRutas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRutas.FlatAppearance.BorderSize = 0;
            this.btnRutas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutas.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRutas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRutas.Location = new System.Drawing.Point(0, 262);
            this.btnRutas.Name = "btnRutas";
            this.btnRutas.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnRutas.Size = new System.Drawing.Size(156, 33);
            this.btnRutas.TabIndex = 11;
            this.btnRutas.Text = "Rutas";
            this.btnRutas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRutas.UseVisualStyleBackColor = false;
            this.btnRutas.Click += new System.EventHandler(this.BtnRutas_Click);
            // 
            // btnBarcos
            // 
            this.btnBarcos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnBarcos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBarcos.FlatAppearance.BorderSize = 0;
            this.btnBarcos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBarcos.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarcos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBarcos.Location = new System.Drawing.Point(0, 229);
            this.btnBarcos.Name = "btnBarcos";
            this.btnBarcos.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnBarcos.Size = new System.Drawing.Size(156, 33);
            this.btnBarcos.TabIndex = 9;
            this.btnBarcos.Text = "Barcos";
            this.btnBarcos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarcos.UseVisualStyleBackColor = false;
            this.btnBarcos.Click += new System.EventHandler(this.BtnVentas_Click);
            // 
            // btnSalirMain
            // 
            this.btnSalirMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnSalirMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSalirMain.FlatAppearance.BorderSize = 0;
            this.btnSalirMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalirMain.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirMain.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalirMain.Location = new System.Drawing.Point(0, 473);
            this.btnSalirMain.Name = "btnSalirMain";
            this.btnSalirMain.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnSalirMain.Size = new System.Drawing.Size(156, 33);
            this.btnSalirMain.TabIndex = 8;
            this.btnSalirMain.Text = "Salir";
            this.btnSalirMain.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirMain.UseVisualStyleBackColor = false;
            this.btnSalirMain.Click += new System.EventHandler(this.BtnSalirMain_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUsuarios.Location = new System.Drawing.Point(0, 196);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsuarios.Size = new System.Drawing.Size(156, 33);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.BtnProductos_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDashboard.Location = new System.Drawing.Point(0, 163);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnDashboard.Size = new System.Drawing.Size(156, 33);
            this.btnDashboard.TabIndex = 4;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(156, 163);
            this.panel3.TabIndex = 3;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(156, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(835, 506);
            this.panelChildForm.TabIndex = 4;
            // 
            // MainFrameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 506);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panel1);
            this.Name = "MainFrameForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBarcos;
        private System.Windows.Forms.Button btnSalirMain;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnRutas;
        private System.Windows.Forms.Button Navegacion;
    }
}