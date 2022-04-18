using System;
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
    
        public Operando(double numero)
        {
            this.numero = numero;
        }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        

        //PROPIEDADES
        private string Numero
        {
            set
            {
                if(ValidarOperando(value) != 0)
                {
                    this.numero = double.Parse(value);
                }

            }
        }




        //METODOS
        private double ValidarOperando(string strNumero)
        {
            double ret = 0;

            

            if (double.TryParse(strNumero, out ret) == true)
            {
                ret = double.Parse(strNumero);
            }

            return ret;
        }


        
        private bool EsBinario(string binario)
        {
            bool ret = true;
            double aux;

            for(int i = 0; i < binario.Length; i++)
            {
                aux = Char.GetNumericValue(binario[i]);
                if (aux != 0 && aux != 1)
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }
    
        
        public string BinarioDecimal(string binario)
        {
            int posicion;
            int digito;
            int potencia;
            int calculo;
            int numeroDecimal = 0;
            string ret;

            if (EsBinario(binario) == true)
            {
                posicion = binario.Length - 1;
                for(int i = 0; i < binario.Length; i++) 
                {
                    digito = Math.Abs((int)Char.GetNumericValue(binario[i]));
                    potencia = Math.Abs((int)Math.Pow(2, posicion));
                    calculo = digito * potencia;
                    numeroDecimal += calculo;
                    posicion--;
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
            StringBuilder cadenaDesordenada = new StringBuilder();
            StringBuilder cadenaOrdenada = new StringBuilder();
            string aux;
            string ret;
            int cociente;
            int resto;

            if (numero > 0)
            {
                cociente = Math.Abs((int)numero);
                do
                {
                    resto = cociente % 2;
                    cadenaDesordenada.Append(resto);
                    cociente = cociente / 2;
                    if(cociente < 2)
                    {
                        cadenaDesordenada.Append(cociente);
                    }

                } while (cociente > 1);

                aux = cadenaDesordenada.ToString();
                for(int i = aux.Length - 1; i >= 0 ; i--)
                {
                    cadenaOrdenada.Append(aux[i]);
                }
                ret = cadenaOrdenada.ToString();
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
