namespace David19
{
    partial class FrmPal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BarraNombre = new System.Windows.Forms.TextBox();
            this.BarraApelldo = new System.Windows.Forms.TextBox();
            this.BarraTelefono = new System.Windows.Forms.TextBox();
            this.BarraCorreo = new System.Windows.Forms.TextBox();
            this.BoxPersonal = new System.Windows.Forms.GroupBox();
            this.TextID = new System.Windows.Forms.Label();
            this.BarraID = new System.Windows.Forms.TextBox();
            this.TextApellido = new System.Windows.Forms.Label();
            this.TextNombre = new System.Windows.Forms.Label();
            this.BoxContacto = new System.Windows.Forms.GroupBox();
            this.TextTelefono = new System.Windows.Forms.Label();
            this.TextCorreo = new System.Windows.Forms.Label();
            this.ButOk = new System.Windows.Forms.Button();
            this.Butcancel = new System.Windows.Forms.Button();
            this.BoxPersonal.SuspendLayout();
            this.BoxContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraNombre
            // 
            this.BarraNombre.Location = new System.Drawing.Point(93, 58);
            this.BarraNombre.Margin = new System.Windows.Forms.Padding(2);
            this.BarraNombre.Name = "BarraNombre";
            this.BarraNombre.Size = new System.Drawing.Size(279, 20);
            this.BarraNombre.TabIndex = 2;
            this.BarraNombre.TextChanged += new System.EventHandler(this.BarraNombre_TextChanged);
            this.BarraNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarraNombre_KeyPress);
            // 
            // BarraApelldo
            // 
            this.BarraApelldo.Location = new System.Drawing.Point(93, 89);
            this.BarraApelldo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraApelldo.Name = "BarraApelldo";
            this.BarraApelldo.Size = new System.Drawing.Size(279, 20);
            this.BarraApelldo.TabIndex = 3;
            this.BarraApelldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarraApelldo_KeyPress);
            // 
            // BarraTelefono
            // 
            this.BarraTelefono.Location = new System.Drawing.Point(93, 38);
            this.BarraTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.BarraTelefono.Name = "BarraTelefono";
            this.BarraTelefono.Size = new System.Drawing.Size(279, 20);
            this.BarraTelefono.TabIndex = 4;
            this.BarraTelefono.TextChanged += new System.EventHandler(this.BarraTelefono_TextChanged);
            this.BarraTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarraTelefono_KeyPress);
            // 
            // BarraCorreo
            // 
            this.BarraCorreo.Location = new System.Drawing.Point(93, 88);
            this.BarraCorreo.Margin = new System.Windows.Forms.Padding(2);
            this.BarraCorreo.Name = "BarraCorreo";
            this.BarraCorreo.Size = new System.Drawing.Size(279, 20);
            this.BarraCorreo.TabIndex = 5;
            this.BarraCorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarraCorreo_KeyPress);
            // 
            // BoxPersonal
            // 
            this.BoxPersonal.BackColor = System.Drawing.Color.Transparent;
            this.BoxPersonal.Controls.Add(this.TextID);
            this.BoxPersonal.Controls.Add(this.BarraID);
            this.BoxPersonal.Controls.Add(this.TextApellido);
            this.BoxPersonal.Controls.Add(this.TextNombre);
            this.BoxPersonal.Controls.Add(this.BarraApelldo);
            this.BoxPersonal.Controls.Add(this.BarraNombre);
            this.BoxPersonal.ForeColor = System.Drawing.SystemColors.Control;
            this.BoxPersonal.Location = new System.Drawing.Point(62, 13);
            this.BoxPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.BoxPersonal.Name = "BoxPersonal";
            this.BoxPersonal.Padding = new System.Windows.Forms.Padding(2);
            this.BoxPersonal.Size = new System.Drawing.Size(460, 136);
            this.BoxPersonal.TabIndex = 6;
            this.BoxPersonal.TabStop = false;
            this.BoxPersonal.Text = "Información Personal";
            // 
            // TextID
            // 
            this.TextID.AutoSize = true;
            this.TextID.ForeColor = System.Drawing.SystemColors.Control;
            this.TextID.Location = new System.Drawing.Point(38, 28);
            this.TextID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextID.Name = "TextID";
            this.TextID.Size = new System.Drawing.Size(18, 13);
            this.TextID.TabIndex = 11;
            this.TextID.Text = "ID";
            // 
            // BarraID
            // 
            this.BarraID.Location = new System.Drawing.Point(93, 25);
            this.BarraID.Margin = new System.Windows.Forms.Padding(2);
            this.BarraID.Name = "BarraID";
            this.BarraID.Size = new System.Drawing.Size(279, 20);
            this.BarraID.TabIndex = 10;
            this.BarraID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BarraID_KeyPress);
            // 
            // TextApellido
            // 
            this.TextApellido.AutoSize = true;
            this.TextApellido.ForeColor = System.Drawing.SystemColors.Control;
            this.TextApellido.Location = new System.Drawing.Point(26, 93);
            this.TextApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextApellido.Name = "TextApellido";
            this.TextApellido.Size = new System.Drawing.Size(44, 13);
            this.TextApellido.TabIndex = 9;
            this.TextApellido.Text = "Apellido";
            // 
            // TextNombre
            // 
            this.TextNombre.AutoSize = true;
            this.TextNombre.ForeColor = System.Drawing.SystemColors.Control;
            this.TextNombre.Location = new System.Drawing.Point(26, 58);
            this.TextNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextNombre.Name = "TextNombre";
            this.TextNombre.Size = new System.Drawing.Size(44, 13);
            this.TextNombre.TabIndex = 8;
            this.TextNombre.Text = "Nombre";
            // 
            // BoxContacto
            // 
            this.BoxContacto.BackColor = System.Drawing.Color.Transparent;
            this.BoxContacto.Controls.Add(this.TextTelefono);
            this.BoxContacto.Controls.Add(this.TextCorreo);
            this.BoxContacto.Controls.Add(this.BarraCorreo);
            this.BoxContacto.Controls.Add(this.BarraTelefono);
            this.BoxContacto.ForeColor = System.Drawing.SystemColors.Control;
            this.BoxContacto.Location = new System.Drawing.Point(62, 171);
            this.BoxContacto.Margin = new System.Windows.Forms.Padding(2);
            this.BoxContacto.Name = "BoxContacto";
            this.BoxContacto.Padding = new System.Windows.Forms.Padding(2);
            this.BoxContacto.Size = new System.Drawing.Size(460, 134);
            this.BoxContacto.TabIndex = 7;
            this.BoxContacto.TabStop = false;
            this.BoxContacto.Text = "Contacto";
            // 
            // TextTelefono
            // 
            this.TextTelefono.AutoSize = true;
            this.TextTelefono.ForeColor = System.Drawing.SystemColors.Control;
            this.TextTelefono.Location = new System.Drawing.Point(26, 43);
            this.TextTelefono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextTelefono.Name = "TextTelefono";
            this.TextTelefono.Size = new System.Drawing.Size(49, 13);
            this.TextTelefono.TabIndex = 10;
            this.TextTelefono.Text = "Teléfono";
            // 
            // TextCorreo
            // 
            this.TextCorreo.AutoSize = true;
            this.TextCorreo.ForeColor = System.Drawing.SystemColors.Control;
            this.TextCorreo.Location = new System.Drawing.Point(26, 93);
            this.TextCorreo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TextCorreo.Name = "TextCorreo";
            this.TextCorreo.Size = new System.Drawing.Size(38, 13);
            this.TextCorreo.TabIndex = 11;
            this.TextCorreo.Text = "Correo";
            // 
            // ButOk
            // 
            this.ButOk.Location = new System.Drawing.Point(320, 324);
            this.ButOk.Margin = new System.Windows.Forms.Padding(2);
            this.ButOk.Name = "ButOk";
            this.ButOk.Size = new System.Drawing.Size(83, 32);
            this.ButOk.TabIndex = 8;
            this.ButOk.Text = "OK";
            this.ButOk.UseVisualStyleBackColor = true;
            this.ButOk.Click += new System.EventHandler(this.ButOk_Click);
            this.ButOk.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ButOk_KeyDown);
            this.ButOk.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ButOk_KeyPress);
            // 
            // Butcancel
            // 
            this.Butcancel.Location = new System.Drawing.Point(439, 324);
            this.Butcancel.Margin = new System.Windows.Forms.Padding(2);
            this.Butcancel.Name = "Butcancel";
            this.Butcancel.Size = new System.Drawing.Size(83, 32);
            this.Butcancel.TabIndex = 9;
            this.Butcancel.Text = "Cancel";
            this.Butcancel.UseVisualStyleBackColor = true;
            this.Butcancel.Click += new System.EventHandler(this.Butcancel_Click);
            this.Butcancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Butcancel_KeyDown);
            this.Butcancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Butcancel_KeyPress);
            // 
            // FrmPal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::David19.Properties.Resources._150630113156_concurso_perros_feos_624x351_getty_jpg;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.Butcancel);
            this.Controls.Add(this.ButOk);
            this.Controls.Add(this.BoxContacto);
            this.Controls.Add(this.BoxPersonal);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmPal";
            this.Text = "Form1";
            this.BoxPersonal.ResumeLayout(false);
            this.BoxPersonal.PerformLayout();
            this.BoxContacto.ResumeLayout(false);
            this.BoxContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox BarraNombre;
        private System.Windows.Forms.TextBox BarraApelldo;
        private System.Windows.Forms.TextBox BarraTelefono;
        private System.Windows.Forms.TextBox BarraCorreo;
        private System.Windows.Forms.GroupBox BoxPersonal;
        private System.Windows.Forms.GroupBox BoxContacto;
        private System.Windows.Forms.Label TextApellido;
        private System.Windows.Forms.Label TextNombre;
        private System.Windows.Forms.Label TextTelefono;
        private System.Windows.Forms.Label TextCorreo;
        private System.Windows.Forms.Label TextID;
        private System.Windows.Forms.TextBox BarraID;
        private System.Windows.Forms.Button ButOk;
        private System.Windows.Forms.Button Butcancel;
    }
}

