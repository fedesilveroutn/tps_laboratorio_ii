using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;


namespace miCalculadora
{
    public partial class FormCalculadora : Form
    {
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Está seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();      
            string resultadoEnBinario;
           
            if(this.lblResultado.Text.Length < 12)
            { 
                if(this.lblResultado.Text != "" && this.lblResultado.Text[0] != '-')
                {
                    resultadoEnBinario = operando.DecimalBinario(this.lblResultado.Text);
                    this.lblResultado.Text = resultadoEnBinario;
                
                }
                else
                {
                    MessageBox.Show("Solo es posible convertir numeros enteros.", "Error");
                }
            }
            else
            {
                MessageBox.Show("No se puede convertir un numero tan grande.", "Error");
            }
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            string resultadoAConvertir = this.lblResultado.Text;
            string resultadoEnDecimal;

            if(this.lblResultado.Text != "")
            {
                resultadoEnDecimal = operando.BinarioDecimal(resultadoAConvertir);
                if (resultadoEnDecimal != "Valor inválido") 
                {
                    this.lblResultado.Text = resultadoEnDecimal;
                }
                else
                {
                    this.lblResultado.Text = resultadoEnDecimal;
                    MessageBox.Show("Solo se permite convertir numeros binarios.", "Error");
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
       
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            
            return Calculadora.Operar(operando1, operando2, operador[0]);
        }
        
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        
        public FormCalculadora()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.cmbOperador.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.lstOperaciones.Items.Clear();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            StringBuilder listaOperaciones = new StringBuilder();
            double resultado;

            if (this.cmbOperador.Text != "" && this.txtNumero1.Text != "" && this.txtNumero2.Text != "")
            {
                if (double.TryParse(txtNumero1.Text, out double r1) == true && double.TryParse(txtNumero2.Text, out double r2) == true) 
                {
                    resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                    this.lblResultado.Text = resultado.ToString();

                    listaOperaciones.Append(this.txtNumero1.Text + " " +
                                            this.cmbOperador.Text + " " +
                                            this.txtNumero2.Text + " = " +
                                            resultado.ToString());

                    this.lstOperaciones.Items.Add(listaOperaciones.ToString());              
                }
                else
                {
                    MessageBox.Show("Valor inválido. Solo se aceptan numeros decimales.", "Error");
                }          
            }
        }

    }
}
