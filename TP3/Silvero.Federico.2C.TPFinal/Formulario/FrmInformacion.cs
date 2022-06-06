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
    public partial class FrmInformacion : Form
    {
        private Cliente cliente;

        public FrmInformacion(Cliente clienteRecibido)
        {
            InitializeComponent();
            cliente = clienteRecibido;
        }

        private void FrmInformacion_Load(object sender, EventArgs e)
        {
            rtbInformacion.Text = cliente.ToString();
        }
    }
}
