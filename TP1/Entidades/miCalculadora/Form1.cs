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
        /// <summary>
        /// Muestra un cuadro de si o no al hacer click en cerrar, de ser positivo cierra el formulario
        /// sino continua su ejecucion
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;

            respuesta = MessageBox.Show("¿Está seguro que desea salir ?", "Salir", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Al hacer click se llama al metodo que convierte un numero decimal a binario
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
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
        /// <summary>
        /// Cuando se clikea sobre este boton se llama al metodo que convierte un numero binario a decimal
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
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
        /// <summary>
        /// Limpia los valores guardados en ambos textbox, el combobox y el listbox
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }
       /// <summary>
       /// Invoca al metodo Operar de la clase Calculadora y realiza la operacion solicitada
       /// </summary>
       /// <param name="numero1">Recibe un tipo de dato string</param>
       /// <param name="numero2">Recibe un tipo de dato string</param>
       /// <param name="operador">Recibe un tipo de dato string</param>
       /// <returns>Retorna el resultado del metodo Operar correspondiente a Calculadora</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            
            return Calculadora.Operar(operando1, operando2, operador[0]);
        }
        /// <summary>
        /// Se encarga de cargar el formulario
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }
        /// <summary>
        /// Inicializa los componenetes
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Se encarga de resetear los valores de los componentes
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.cmbOperador.Text = "";
            this.txtNumero2.Text = "";
            this.lblResultado.Text = "";
            this.lstOperaciones.Items.Clear();
        }
        /// <summary>
        /// Valida que el contenido de las textbox y combobox y si es correcto, llama al metodo Operar 
        /// </summary>
        /// <param name="sender">object</param>
        /// <param name="e">EventArgs</param>
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
