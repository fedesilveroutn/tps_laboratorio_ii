using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca;

namespace Formulario
{
    public partial class FrmCompra : Form, ICampos
    {
        private FrmProductos formularioProductos;
        private Dispositivo dispositivoAComprar;
        private List<Cliente> listaClientes;

        public FrmCompra(FrmProductos formularioProductosRecibido, Dispositivo dispositivoSeleccionado)
        {
            InitializeComponent();
            formularioProductos = formularioProductosRecibido;
            dispositivoAComprar = dispositivoSeleccionado;
            listaClientes = new List<Cliente>();
        }

        private void FrmCompra_Load(object sender, EventArgs e)
        {
            txtProductoAComprar.Text = dispositivoAComprar.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.formularioProductos.Visible = true;
            this.Close();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (this.LeerEstadoCampos() == true)
            {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string email = txtCorreoElectronico.Text;
                bool campoDocumento = int.TryParse(txtDocumento.Text, out int documento);
                bool campoTelefono = int.TryParse(txtTelefono.Text, out int telefono);
                bool campoNumeroDeTarjeta = long.TryParse(txtNumeroDeTarjeta.Text, out long numeroDeTarjeta);
                bool campoCodigoDeSeguridad = short.TryParse(txtCodigoDeSeguridad.Text, out short codigoDeSeguridad);
                
                if(campoDocumento == true && campoTelefono == true && campoNumeroDeTarjeta == true && campoCodigoDeSeguridad == true)
                {
                    Cliente cliente = new Cliente(nombre, apellido, documento, telefono, email);                   
                    cliente.AsignarTipoDeTarjeta(cmbTipoDeTarjeta.SelectedItem.ToString());
                    cliente.NumeroTarjeta = numeroDeTarjeta;
                    cliente.CodigoDeSeguridad = codigoDeSeguridad;
                    cliente.Dispositivo = dispositivoAComprar;
                    listaClientes.Add(cliente);
                    MessageBox.Show("¡Compra realizada exitosamente!", "Compra exitosa", MessageBoxButtons.OK);
                    LimpiarCampos();
                    FrmInformacion ticket = new FrmInformacion(cliente);
                    ticket.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Los campos DNI / TELEFONO / N°TARJETA / CODIGO DE SEGURIDAD solo aceptan valores numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }               
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Implementacion de los metodos de la interface 
        public bool LeerEstadoCampos()
        {
            bool estanCargados;

            bool campoProductoAComprar = string.IsNullOrEmpty(txtProductoAComprar.Text);
            bool campoNombre = string.IsNullOrEmpty(txtNombre.Text);
            bool campoApellido = string.IsNullOrEmpty(txtApellido.Text);
            bool campoDocumento = string.IsNullOrEmpty(txtDocumento.Text);
            bool campoTelefono = string.IsNullOrEmpty(txtTelefono.Text);
            bool campoEmail = string.IsNullOrEmpty(txtCorreoElectronico.Text);
            bool campoNumeroTarjeta = string.IsNullOrEmpty(txtNumeroDeTarjeta.Text);
            bool campoCodigoDeSeguridad = string.IsNullOrEmpty(txtCodigoDeSeguridad.Text);
      
            if(campoProductoAComprar == false && 
               campoNombre == false && 
               campoApellido == false && 
               campoDocumento == false &&
               campoTelefono == false && 
               campoEmail == false &&
               campoNumeroTarjeta == false && 
               campoCodigoDeSeguridad == false && 
               cmbTipoDeTarjeta.SelectedItem is not null)
            {
                estanCargados = true;
            }
            else
            {
                estanCargados = false;
            }
            
            return estanCargados;
        }      
        
        public void LimpiarCampos()
        {
            this.txtProductoAComprar.Clear();

            this.txtNombre.Clear();
            this.txtApellido.Clear();
            this.txtDocumento.Clear();
            this.txtTelefono.Clear();
            this.txtCorreoElectronico.Clear();

            this.txtCodigoDeSeguridad.Clear();
            this.txtNumeroDeTarjeta.Clear();
            this.cmbTipoDeTarjeta.SelectedItem = null;

        }

        
    }
}



    
        
        
        
        
