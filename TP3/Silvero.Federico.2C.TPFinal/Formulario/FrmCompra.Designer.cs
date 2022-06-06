namespace Formulario
{
    partial class FrmCompra
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.gbDatosDeContacto = new System.Windows.Forms.GroupBox();
            this.btnComprar = new System.Windows.Forms.Button();
            this.gbProducto = new System.Windows.Forms.GroupBox();
            this.txtProductoAComprar = new System.Windows.Forms.TextBox();
            this.txtEncabezado = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNumeroDeTarjeta = new System.Windows.Forms.TextBox();
            this.gbDatosDeTarjeta = new System.Windows.Forms.GroupBox();
            this.txtCodigoDeSeguridad = new System.Windows.Forms.TextBox();
            this.lblCodigoDeSeguridad = new System.Windows.Forms.Label();
            this.lblNumeroDeTarjeta = new System.Windows.Forms.Label();
            this.lblTipoDeTarjeta = new System.Windows.Forms.Label();
            this.cmbTipoDeTarjeta = new System.Windows.Forms.ComboBox();
            this.gbDatosDeContacto.SuspendLayout();
            this.gbProducto.SuspendLayout();
            this.gbDatosDeTarjeta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(15, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(51, 15);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(133, 37);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(51, 15);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(15, 110);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(27, 15);
            this.lblDocumento.TabIndex = 2;
            this.lblDocumento.Text = "DNI";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Location = new System.Drawing.Point(15, 183);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(105, 15);
            this.lblCorreoElectronico.TabIndex = 3;
            this.lblCorreoElectronico.Text = "Correo electrónico";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(133, 110);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 15);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono";
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Location = new System.Drawing.Point(15, 55);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 23);
            this.txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.Location = new System.Drawing.Point(133, 55);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 23);
            this.txtApellido.TabIndex = 7;
            // 
            // txtDocumento
            // 
            this.txtDocumento.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDocumento.Location = new System.Drawing.Point(15, 128);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(100, 23);
            this.txtDocumento.TabIndex = 8;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefono.Location = new System.Drawing.Point(133, 128);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 23);
            this.txtTelefono.TabIndex = 9;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCorreoElectronico.Location = new System.Drawing.Point(15, 201);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(218, 23);
            this.txtCorreoElectronico.TabIndex = 10;
            // 
            // gbDatosDeContacto
            // 
            this.gbDatosDeContacto.Controls.Add(this.txtNombre);
            this.gbDatosDeContacto.Controls.Add(this.lblNombre);
            this.gbDatosDeContacto.Controls.Add(this.lblApellido);
            this.gbDatosDeContacto.Controls.Add(this.lblDocumento);
            this.gbDatosDeContacto.Controls.Add(this.lblCorreoElectronico);
            this.gbDatosDeContacto.Controls.Add(this.lblTelefono);
            this.gbDatosDeContacto.Controls.Add(this.txtApellido);
            this.gbDatosDeContacto.Controls.Add(this.txtDocumento);
            this.gbDatosDeContacto.Controls.Add(this.txtTelefono);
            this.gbDatosDeContacto.Controls.Add(this.txtCorreoElectronico);
            this.gbDatosDeContacto.Location = new System.Drawing.Point(12, 110);
            this.gbDatosDeContacto.Name = "gbDatosDeContacto";
            this.gbDatosDeContacto.Size = new System.Drawing.Size(272, 261);
            this.gbDatosDeContacto.TabIndex = 30;
            this.gbDatosDeContacto.TabStop = false;
            this.gbDatosDeContacto.Text = "Datos de contacto";
            // 
            // btnComprar
            // 
            this.btnComprar.Location = new System.Drawing.Point(434, 321);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(128, 50);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "Finalizar compra";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // gbProducto
            // 
            this.gbProducto.Controls.Add(this.txtProductoAComprar);
            this.gbProducto.Controls.Add(this.txtEncabezado);
            this.gbProducto.Location = new System.Drawing.Point(12, 12);
            this.gbProducto.Name = "gbProducto";
            this.gbProducto.Size = new System.Drawing.Size(550, 92);
            this.gbProducto.TabIndex = 32;
            this.gbProducto.TabStop = false;
            this.gbProducto.Text = "Producto a comprar";
            // 
            // txtProductoAComprar
            // 
            this.txtProductoAComprar.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductoAComprar.Location = new System.Drawing.Point(15, 51);
            this.txtProductoAComprar.Name = "txtProductoAComprar";
            this.txtProductoAComprar.ReadOnly = true;
            this.txtProductoAComprar.Size = new System.Drawing.Size(524, 23);
            this.txtProductoAComprar.TabIndex = 38;
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.BackColor = System.Drawing.SystemColors.Window;
            this.txtEncabezado.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtEncabezado.Location = new System.Drawing.Point(15, 29);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.ReadOnly = true;
            this.txtEncabezado.Size = new System.Drawing.Size(524, 23);
            this.txtEncabezado.TabIndex = 37;
            this.txtEncabezado.Text = "ID                         PRODUCTO                       MARCA                  " +
    "       SOFTWARE\r\n";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(290, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 50);
            this.btnCancelar.TabIndex = 33;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNumeroDeTarjeta
            // 
            this.txtNumeroDeTarjeta.Location = new System.Drawing.Point(6, 128);
            this.txtNumeroDeTarjeta.Name = "txtNumeroDeTarjeta";
            this.txtNumeroDeTarjeta.Size = new System.Drawing.Size(255, 23);
            this.txtNumeroDeTarjeta.TabIndex = 34;
            // 
            // gbDatosDeTarjeta
            // 
            this.gbDatosDeTarjeta.Controls.Add(this.txtCodigoDeSeguridad);
            this.gbDatosDeTarjeta.Controls.Add(this.lblCodigoDeSeguridad);
            this.gbDatosDeTarjeta.Controls.Add(this.lblNumeroDeTarjeta);
            this.gbDatosDeTarjeta.Controls.Add(this.lblTipoDeTarjeta);
            this.gbDatosDeTarjeta.Controls.Add(this.txtNumeroDeTarjeta);
            this.gbDatosDeTarjeta.Controls.Add(this.cmbTipoDeTarjeta);
            this.gbDatosDeTarjeta.Location = new System.Drawing.Point(290, 110);
            this.gbDatosDeTarjeta.Name = "gbDatosDeTarjeta";
            this.gbDatosDeTarjeta.Size = new System.Drawing.Size(272, 198);
            this.gbDatosDeTarjeta.TabIndex = 35;
            this.gbDatosDeTarjeta.TabStop = false;
            this.gbDatosDeTarjeta.Text = "Datos de Tarjeta";
            // 
            // txtCodigoDeSeguridad
            // 
            this.txtCodigoDeSeguridad.Location = new System.Drawing.Point(144, 53);
            this.txtCodigoDeSeguridad.Name = "txtCodigoDeSeguridad";
            this.txtCodigoDeSeguridad.Size = new System.Drawing.Size(117, 23);
            this.txtCodigoDeSeguridad.TabIndex = 36;
            // 
            // lblCodigoDeSeguridad
            // 
            this.lblCodigoDeSeguridad.AutoSize = true;
            this.lblCodigoDeSeguridad.Location = new System.Drawing.Point(144, 35);
            this.lblCodigoDeSeguridad.Name = "lblCodigoDeSeguridad";
            this.lblCodigoDeSeguridad.Size = new System.Drawing.Size(117, 15);
            this.lblCodigoDeSeguridad.TabIndex = 36;
            this.lblCodigoDeSeguridad.Text = "Código de seguridad";
            // 
            // lblNumeroDeTarjeta
            // 
            this.lblNumeroDeTarjeta.AutoSize = true;
            this.lblNumeroDeTarjeta.Location = new System.Drawing.Point(6, 110);
            this.lblNumeroDeTarjeta.Name = "lblNumeroDeTarjeta";
            this.lblNumeroDeTarjeta.Size = new System.Drawing.Size(103, 15);
            this.lblNumeroDeTarjeta.TabIndex = 36;
            this.lblNumeroDeTarjeta.Text = "Número de tarjeta";
            // 
            // lblTipoDeTarjeta
            // 
            this.lblTipoDeTarjeta.AutoSize = true;
            this.lblTipoDeTarjeta.Location = new System.Drawing.Point(6, 35);
            this.lblTipoDeTarjeta.Name = "lblTipoDeTarjeta";
            this.lblTipoDeTarjeta.Size = new System.Drawing.Size(82, 15);
            this.lblTipoDeTarjeta.TabIndex = 36;
            this.lblTipoDeTarjeta.Text = "Tipo de tarjeta";
            // 
            // cmbTipoDeTarjeta
            // 
            this.cmbTipoDeTarjeta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeTarjeta.FormattingEnabled = true;
            this.cmbTipoDeTarjeta.Items.AddRange(new object[] {
            "Debito",
            "Credito"});
            this.cmbTipoDeTarjeta.Location = new System.Drawing.Point(6, 53);
            this.cmbTipoDeTarjeta.Name = "cmbTipoDeTarjeta";
            this.cmbTipoDeTarjeta.Size = new System.Drawing.Size(109, 23);
            this.cmbTipoDeTarjeta.TabIndex = 36;
            // 
            // FrmCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 392);
            this.Controls.Add(this.gbDatosDeTarjeta);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.gbProducto);
            this.Controls.Add(this.gbDatosDeContacto);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario de compra";
            this.Load += new System.EventHandler(this.FrmCompra_Load);
            this.gbDatosDeContacto.ResumeLayout(false);
            this.gbDatosDeContacto.PerformLayout();
            this.gbProducto.ResumeLayout(false);
            this.gbProducto.PerformLayout();
            this.gbDatosDeTarjeta.ResumeLayout(false);
            this.gbDatosDeTarjeta.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.GroupBox gbDatosDeContacto;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.GroupBox gbProducto;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtNumeroDeTarjeta;
        private System.Windows.Forms.GroupBox gbDatosDeTarjeta;
        private System.Windows.Forms.Label lblTipoDeTarjeta;
        private System.Windows.Forms.ComboBox cmbTipoDeTarjeta;
        private System.Windows.Forms.TextBox txtCodigoDeSeguridad;
        private System.Windows.Forms.Label lblCodigoDeSeguridad;
        private System.Windows.Forms.Label lblNumeroDeTarjeta;
        private System.Windows.Forms.TextBox txtEncabezado;
        private System.Windows.Forms.TextBox txtProductoAComprar;
    }
}
