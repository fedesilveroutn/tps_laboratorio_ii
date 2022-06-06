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
    public partial class FrmProductos : Form, ICampos
    {
        private FrmInicio inicio;      

        public FrmProductos(FrmInicio inicioRecibido)
        {
            InitializeComponent();
            this.inicio = inicioRecibido;
        }    

        private void FrmProductos_Load(object sender, EventArgs e)
        {          
            foreach (Dispositivo item in inicio.publicaciones)
            {
                lstProductos.Items.Add(item);
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComprarAhora_Click(object sender, EventArgs e)
        {
            if(LeerEstadoCampos() == true)
            {
                Dispositivo? dispositivoSeleccionado = lstProductos.SelectedItem as Dispositivo;
                if(dispositivoSeleccionado is not null)
                {
                    FrmCompra formularioCompra = new FrmCompra(this, dispositivoSeleccionado);
                    this.Visible = false;
                    formularioCompra.ShowDialog();
                    lstProductos.SelectedItem = null;
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Implementacion de los metodos de la interface
        public bool LeerEstadoCampos()
        {
            bool ret = false;
            if(lstProductos.SelectedItem is not null)
            {
                ret = true;
            }
            return ret;
        }

        public void LimpiarCampos()
        {
            lstProductos.SelectedItem = null;           
        }

        private void FrmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.inicio.Visible = true;
        }
    }
}
