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
    public partial class FrmVenta : Form, ICampos
    {
        private FrmInicio inicio;

        public FrmVenta(FrmInicio inicioRecibido)
        {
            InitializeComponent();
            inicio = inicioRecibido;
           
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.inicio.Visible = true;
            this.Close();
        }


        private void btnPublicar_Click(object sender, EventArgs e)
        {
            if(LeerEstadoCampos() == true)
            {
                Dispositivo dispositivoAPublicar;
                Dispositivo.Empresa marca;
                Dispositivo.Software sistemaOperativo;
                int id = this.BuscarUltimoId() + 1;
              
                marca = Dispositivo.AsignarMarca(cmbMarca.SelectedItem.ToString());
                sistemaOperativo = Dispositivo.AsignarSistemaOperativo(cmbMarca.SelectedItem.ToString(), cmbCategoria.SelectedItem.ToString());
                dispositivoAPublicar = Dispositivo.CrearDispositivo(cmbCategoria.SelectedItem.ToString(), id, marca, sistemaOperativo);

                if(float.TryParse(txtPrecio.Text, out float precio) == true)
                {
                    dispositivoAPublicar.Valor = precio;
                    this.inicio.publicaciones.Add(dispositivoAPublicar);
                    MessageBox.Show("¡Dispositivo agregado exitosamente!", "Publicación realizada", MessageBoxButtons.OK);
                    this.LimpiarCampos();
                }
                else
                {
                    MessageBox.Show("El campo PRECIO debe ser numérico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos para continuar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


               
                
            
        }

        //Implementacion de la interface
        public bool LeerEstadoCampos()
        {
            bool estanCargados;
            if(cmbCategoria.SelectedItem is not null && cmbMarca.SelectedItem is not null && 
              (String.IsNullOrEmpty(txtPrecio.Text)) == false)
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
            cmbCategoria.SelectedItem = null;
            cmbMarca.SelectedItem = null;
            txtPrecio.Clear();
        }

        public int BuscarUltimoId()
        {
            int ultimoId = 999;
            foreach (Dispositivo item in inicio.publicaciones)
            {
                if(item.Id > ultimoId)
                {
                    ultimoId = item.Id;
                }
            }
            return ultimoId;
        }

       
    }
}
