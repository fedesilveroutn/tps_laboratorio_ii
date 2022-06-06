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
    public partial class FrmInicio : Form
    {
        public List<Dispositivo> publicaciones;

        public FrmInicio()
        {
            InitializeComponent();
            publicaciones = new List<Dispositivo>();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            if(publicaciones.Count > 0)
            {
                FrmProductos listaProductos = new FrmProductos(this);
                listaProductos.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("No existen publicaciones cargadas, deberá intentar más tarde.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            FrmVenta publicacion = new FrmVenta(this);
            publicacion.Show();
            this.Visible = false;
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = MessageBox.Show("¿Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if(DialogResult == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

    }
}
