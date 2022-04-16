﻿using System;
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
            this.lstOperaciones.Items.Clear();
        }

        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando operando1 = new Operando(numero1);
            Operando operando2 = new Operando(numero2);
            
            return Calculadora.Operar(operando1, operando2, operador[0]);
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            StringBuilder listaOperaciones = new StringBuilder();
            double resultado;

            if (this.cmbOperador.Text != "")
            {
                resultado = FormCalculadora.Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text);
                this.lblResultado.Text = resultado.ToString();

                listaOperaciones.Append(this.txtNumero1.Text + " " +
                                        this.cmbOperador.Text + " " +
                                        this.txtNumero2.Text + " = " +
                                        resultado.ToString());

                this.lstOperaciones.Items.Add(listaOperaciones.ToString());
            }
        }





        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstOperaciones_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            //REVISAR
            MessageBox.Show("¿Está seguro que desea salir ?");
            this.Close();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();
            double resultadoAConvertir;
            string resultadoEnBinario;

            if(this.lblResultado.Text != "")
            {
                resultadoAConvertir = double.Parse(this.lblResultado.Text);
                resultadoEnBinario = operando.DecimalBinario(resultadoAConvertir);
                this.lblResultado.Text = resultadoEnBinario;
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
                this.lblResultado.Text = resultadoEnDecimal;
            }
        }
    }
}
