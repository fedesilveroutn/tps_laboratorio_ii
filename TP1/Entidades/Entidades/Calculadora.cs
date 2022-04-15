﻿using System;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            if(operador == '+' || operador == '-' || operador == '/' || operador == '*')
            {
                return operador;
            }
            else
            {
                return '+';
            }
        }

        
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            char operadorValidado;
            double resultado = double.MinValue;

            operadorValidado = ValidarOperador(operador);
            switch (operadorValidado)
            {
                case '+':
                        resultado = num1 + num2;
                        break;

                case '-':
                        resultado = num1 - num2;
                        break;

                case '/':
                        resultado = num1 / num2;
                        break;

                case '*':
                        resultado = num1 * num2;
                        break;
            }
            return resultado;
        }
    }



    public class Operando
    {
        //CAMPOS
        private double numero;


        //CONSTRUCTOR
        public Operando()
        {
            this.numero = 0;
        }
    
        

        //PROPIEDADES
        private string Numero
        {
            set
            {
                if(ValidarOperando(value) != 0)
                {
                    this.Numero = value;
                }

            }
        }




        //METODOS
        private double ValidarOperando(string strNumero)
        {
            double ret = 0;

            if(double.TryParse(strNumero, out ret) == true)
            {
                ret = double.Parse(strNumero);
            }
            return ret;
        }


        private bool EsBinario(string binario)
        {
            bool ret = true;

            for(int i = 0; i < binario.Length; i++)
            {
                if(binario[i] != '0' || binario[i] != '1')
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }
    
    
        public string BinarioDecimal(string binario)
        {
            int digito;
            int potencia;
            int calculo;
            int numeroDecimal = 0;
            string ret;

            if (EsBinario(binario) == true)
            {                       
                for(int i = binario.Length - 1; i >= 0 ; i--)
                {
                    digito = Math.Abs((int)binario[i]);
                    potencia = Math.Abs((int)Math.Pow(2, i));
                    calculo = digito * potencia;
                    numeroDecimal += calculo;
                }
                ret = numeroDecimal.ToString();
            }
            else
            {
                ret = "Valor inválido";
            }

            return ret;
        }
    
        public string DecimalBinario(double numero)
        {
            StringBuilder sb = new StringBuilder();
            string ret;
            int valorAbsoluto;
            int resto;

            if (numero > 0)
            {
                valorAbsoluto = Math.Abs((int)numero);
                for (int i = valorAbsoluto; i > 1; i--)
                {
                    resto = i % 2;
                    sb.Append(resto.ToString());
                    i = i / 2;
                }
                ret = sb.ToString();
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }


        
        public string DecimalBinario(string numero)
        {
            double numeroValidado;
            string ret;
                         
            if(double.TryParse(numero, out numeroValidado) == true)
            {
                numeroValidado = double.Parse(numero);
                ret = this.DecimalBinario(numeroValidado);
            }
            else
            {
                ret = "Valor inválido";
            }
            return ret;
        }




        //SOBRECARGA DE OPERADORES

        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;   
        }

        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        public static double operator / (Operando n1, Operando n2)
        {
            double resultado;

            if(n2.numero == 0)
            {
                resultado = double.MinValue;
            }
            else
            {
                resultado = n1.numero / n2.numero;
            }
            return resultado;
        }

        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
    }
}