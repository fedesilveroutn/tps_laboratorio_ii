using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace miCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }


        //METODOS PROPIOS
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.cmbOperador.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.lstOperaciones.Text = "";
        }
    }
}
