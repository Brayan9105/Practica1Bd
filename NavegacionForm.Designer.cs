namespace SegundoParcialBrayan
{
    partial class NavegacionForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgNavegacion = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.combMatricula = new System.Windows.Forms.ComboBox();
            this.combPatron = new System.Windows.Forms.ComboBox();
            this.combDestino = new System.Windows.Forms.ComboBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labcap = new System.Windows.Forms.Label();
            this.labelmat = new System.Windows.Forms.Label();
            this.txtIdOperacion = new System.Windows.Forms.TextBox();
            this.laboper = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNavegacion)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.dtgNavegacion);
            this.panel2.Location = new System.Drawing.Point(323, 66);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 610);
            this.panel2.TabIndex = 9;
            // 
            // dtgNavegacion
            // 
            this.dtgNavegacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgNavegacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgNavegacion.Location = new System.Drawing.Point(29, 36);
            this.dtgNavegacion.Name = "dtgNavegacion";
            this.dtgNavegacion.ReadOnly = true;
            this.dtgNavegacion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgNavegacion.Size = new System.Drawing.Size(813, 557);
            this.dtgNavegacion.TabIndex = 0;
            this.dtgNavegacion.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DtgNavegacion_CellMouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(70)))), ((int)(((byte)(89)))));
            this.panel1.Controls.Add(this.combMatricula);
            this.panel1.Controls.Add(this.combPatron);
            this.panel1.Controls.Add(this.combDestino);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.labcap);
            this.panel1.Controls.Add(this.labelmat);
            this.panel1.Controls.Add(this.txtIdOperacion);
            this.panel1.Controls.Add(this.laboper);
            this.panel1.Location = new System.Drawing.Point(27, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 323);
            this.panel1.TabIndex = 8;
            // 
            // combMatricula
            // 
            this.combMatricula.FormattingEnabled = true;
            this.combMatricula.Location = new System.Drawing.Point(84, 130);
            this.combMatricula.Name = "combMatricula";
            this.combMatricula.Size = new System.Drawing.Size(191, 21);
            this.combMatricula.TabIndex = 22;
            // 
            // combPatron
            // 
            this.combPatron.FormattingEnabled = true;
            this.combPatron.Location = new System.Drawing.Point(84, 168);
            this.combPatron.Name = "combPatron";
            this.combPatron.Size = new System.Drawing.Size(191, 21);
            this.combPatron.TabIndex = 21;
            // 
            // combDestino
            // 
            this.combDestino.FormattingEnabled = true;
            this.combDestino.Location = new System.Drawing.Point(84, 204);
            this.combDestino.Name = "combDestino";
            this.combDestino.Size = new System.Drawing.Size(191, 21);
            this.combDestino.TabIndex = 20;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton2.Location = new System.Drawing.Point(89, 266);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(71, 17);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Text = "Actualizar";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radioButton1.Location = new System.Drawing.Point(13, 266);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Registrar";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton1_CheckedChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Destino:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Registro y Actualizacion de navegacion";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(188, 263);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // labcap
            // 
            this.labcap.AutoSize = true;
            this.labcap.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labcap.Location = new System.Drawing.Point(14, 171);
            this.labcap.Name = "labcap";
            this.labcap.Size = new System.Drawing.Size(46, 13);
            this.labcap.TabIndex = 4;
            this.labcap.Text = "Capitan:";
            // 
            // labelmat
            // 
            this.labelmat.AutoSize = true;
            this.labelmat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelmat.Location = new System.Drawing.Point(14, 133);
            this.labelmat.Name = "labelmat";
            this.labelmat.Size = new System.Drawing.Size(53, 13);
            this.labelmat.TabIndex = 2;
            this.labelmat.Text = "Matricula:";
            // 
            // txtIdOperacion
            // 
            this.txtIdOperacion.Enabled = false;
            this.txtIdOperacion.Location = new System.Drawing.Point(84, 92);
            this.txtIdOperacion.Name = "txtIdOperacion";
            this.txtIdOperacion.Size = new System.Drawing.Size(191, 20);
            this.txtIdOperacion.TabIndex = 1;
            // 
            // laboper
            // 
            this.laboper.AutoSize = true;
            this.laboper.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.laboper.Location = new System.Drawing.Point(14, 95);
            this.laboper.Name = "laboper";
            this.laboper.Size = new System.Drawing.Size(71, 13);
            this.laboper.TabIndex = 0;
            this.laboper.Text = "Id Operacion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Navegacion";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(26, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(206, 15);
            this.label12.TabIndex = 19;
            this.label12.Text = "Doble click para modificar el registro";
            // 
            // NavegacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 750);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "NavegacionForm";
            this.Text = "NavegacionForm";
            this.Load += new System.EventHandler(this.NavegacionForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgNavegacion)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgNavegacion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labcap;
        private System.Windows.Forms.Label labelmat;
        private System.Windows.Forms.TextBox txtIdOperacion;
        private System.Windows.Forms.Label laboper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox combDestino;
        private System.Windows.Forms.ComboBox combPatron;
        private System.Windows.Forms.ComboBox combMatricula;
        private System.Windows.Forms.Label label12;
    }
}