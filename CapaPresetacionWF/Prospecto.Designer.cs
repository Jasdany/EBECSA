namespace CapaPresetacionWF
{
    partial class FormProspecto
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabconProspecto = new System.Windows.Forms.TabControl();
            this.tabPageProspecto = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblpellido2 = new System.Windows.Forms.Label();
            this.lblApellido1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblid = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblCedula = new System.Windows.Forms.Label();
            this.tabPageDetalleProspecto = new System.Windows.Forms.TabPage();
            this.dataGridViewProspecto = new System.Windows.Forms.DataGridView();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tabconProspecto.SuspendLayout();
            this.tabPageProspecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPageDetalleProspecto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProspecto)).BeginInit();
            this.SuspendLayout();
            // 
            // tabconProspecto
            // 
            this.tabconProspecto.Controls.Add(this.tabPageProspecto);
            this.tabconProspecto.Controls.Add(this.tabPageDetalleProspecto);
            this.tabconProspecto.Location = new System.Drawing.Point(-1, 1);
            this.tabconProspecto.Name = "tabconProspecto";
            this.tabconProspecto.SelectedIndex = 0;
            this.tabconProspecto.Size = new System.Drawing.Size(724, 487);
            this.tabconProspecto.TabIndex = 11;
            // 
            // tabPageProspecto
            // 
            this.tabPageProspecto.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tabPageProspecto.Controls.Add(this.pictureBox1);
            this.tabPageProspecto.Controls.Add(this.label5);
            this.tabPageProspecto.Controls.Add(this.txtCorreo);
            this.tabPageProspecto.Controls.Add(this.txtTelefono);
            this.tabPageProspecto.Controls.Add(this.txtApellido2);
            this.tabPageProspecto.Controls.Add(this.txtApellido1);
            this.tabPageProspecto.Controls.Add(this.lblTelefono);
            this.tabPageProspecto.Controls.Add(this.lblCorreo);
            this.tabPageProspecto.Controls.Add(this.lblpellido2);
            this.tabPageProspecto.Controls.Add(this.lblApellido1);
            this.tabPageProspecto.Controls.Add(this.btnGuardar);
            this.tabPageProspecto.Controls.Add(this.lblid);
            this.tabPageProspecto.Controls.Add(this.txtID);
            this.tabPageProspecto.Controls.Add(this.lblNombre);
            this.tabPageProspecto.Controls.Add(this.txtCedula);
            this.tabPageProspecto.Controls.Add(this.txtNombre);
            this.tabPageProspecto.Controls.Add(this.lblCedula);
            this.tabPageProspecto.Location = new System.Drawing.Point(4, 22);
            this.tabPageProspecto.Name = "tabPageProspecto";
            this.tabPageProspecto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProspecto.Size = new System.Drawing.Size(716, 461);
            this.tabPageProspecto.TabIndex = 0;
            this.tabPageProspecto.Text = "Nuevo";
            this.tabPageProspecto.Click += new System.EventHandler(this.tabPageProspecto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresetacionWF.Properties.Resources.users__1_;
            this.pictureBox1.Location = new System.Drawing.Point(467, 91);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(271, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Registro Prospecto";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(213, 328);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(125, 20);
            this.txtCorreo.TabIndex = 17;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(465, 328);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(120, 20);
            this.txtTelefono.TabIndex = 16;
            // 
            // txtApellido2
            // 
            this.txtApellido2.Location = new System.Drawing.Point(465, 264);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(125, 20);
            this.txtApellido2.TabIndex = 15;
            // 
            // txtApellido1
            // 
            this.txtApellido1.Location = new System.Drawing.Point(213, 264);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(125, 20);
            this.txtApellido1.TabIndex = 14;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(382, 329);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(67, 19);
            this.lblTelefono.TabIndex = 13;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(64, 329);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(135, 19);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "Correo Electronico";
            // 
            // lblpellido2
            // 
            this.lblpellido2.AutoSize = true;
            this.lblpellido2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpellido2.Location = new System.Drawing.Point(353, 264);
            this.lblpellido2.Name = "lblpellido2";
            this.lblpellido2.Size = new System.Drawing.Size(96, 19);
            this.lblpellido2.TabIndex = 11;
            this.lblpellido2.Text = "2 do.Apellido";
            // 
            // lblApellido1
            // 
            this.lblApellido1.AutoSize = true;
            this.lblApellido1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido1.Location = new System.Drawing.Point(87, 263);
            this.lblApellido1.Name = "lblApellido1";
            this.lblApellido1.Size = new System.Drawing.Size(104, 19);
            this.lblApellido1.TabIndex = 10;
            this.lblApellido1.Text = "1 er. Apellido  ";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SlateBlue;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.PeachPuff;
            this.btnGuardar.FlatAppearance.BorderSize = 3;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.Black;
            this.btnGuardar.Location = new System.Drawing.Point(309, 407);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(99, 46);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Eras Demi ITC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblid.Location = new System.Drawing.Point(151, 89);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(26, 19);
            this.lblid.TabIndex = 1;
            this.lblid.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(208, 90);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(79, 20);
            this.txtID.TabIndex = 4;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(114, 209);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 19);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(208, 160);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(130, 20);
            this.txtCedula.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(213, 210);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(125, 20);
            this.txtNombre.TabIndex = 5;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.Location = new System.Drawing.Point(121, 150);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(56, 19);
            this.lblCedula.TabIndex = 3;
            this.lblCedula.Text = "Cedula";
            // 
            // tabPageDetalleProspecto
            // 
            this.tabPageDetalleProspecto.Controls.Add(this.dataGridViewProspecto);
            this.tabPageDetalleProspecto.Controls.Add(this.btnEliminar);
            this.tabPageDetalleProspecto.Controls.Add(this.btnEditar);
            this.tabPageDetalleProspecto.Controls.Add(this.txtBuscar);
            this.tabPageDetalleProspecto.Controls.Add(this.lblBuscar);
            this.tabPageDetalleProspecto.Location = new System.Drawing.Point(4, 22);
            this.tabPageDetalleProspecto.Name = "tabPageDetalleProspecto";
            this.tabPageDetalleProspecto.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDetalleProspecto.Size = new System.Drawing.Size(716, 461);
            this.tabPageDetalleProspecto.TabIndex = 1;
            this.tabPageDetalleProspecto.Text = "Detalles";
            this.tabPageDetalleProspecto.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProspecto
            // 
            this.dataGridViewProspecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProspecto.Location = new System.Drawing.Point(7, 110);
            this.dataGridViewProspecto.Name = "dataGridViewProspecto";
            this.dataGridViewProspecto.Size = new System.Drawing.Size(703, 343);
            this.dataGridViewProspecto.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.DarkRed;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(373, 29);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(89, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnEditar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEditar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(271, 30);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(84, 34);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(80, 39);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(185, 20);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(18, 39);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 19);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // FormProspecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(718, 488);
            this.Controls.Add(this.tabconProspecto);
            this.Name = "FormProspecto";
            this.Text = "Prospecto";
            this.Load += new System.EventHandler(this.FormProspecto_Load);
            this.tabconProspecto.ResumeLayout(false);
            this.tabPageProspecto.ResumeLayout(false);
            this.tabPageProspecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPageDetalleProspecto.ResumeLayout(false);
            this.tabPageDetalleProspecto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProspecto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabconProspecto;
        private System.Windows.Forms.TabPage tabPageProspecto;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TabPage tabPageDetalleProspecto;
        private System.Windows.Forms.DataGridView dataGridViewProspecto;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblpellido2;
        private System.Windows.Forms.Label lblApellido1;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

