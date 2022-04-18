using System;
using System.Text;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Realiza la operacion indicada entre los dos objetos del tipo Operando
        /// </summary>
        /// <param name="num1">Recibe el primer objeto de tipo Operando </param>
        /// <param name="num2">Recibe el segundo objeto de tipo Operando</param>
        /// <param name="operador">Recibe el operador correspondiente a la cuenta a realizar</param>
        /// <returns>Retorna el resultado de la cuenta si todo salio bien y sino doble.MinValue</returns>
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
        /// <summary>
        /// Valida que el operador sea + || - || / || *
        /// </summary>
        /// <param name="operador">Recibe un char</param>
        /// <returns>De ser correcto retorna el mismo operador, sino el operador suma</returns>
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
    }



    public class Operando
    {
        private double numero;
   
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

        /// <summary>
        /// Convierte de binario a decimal el numero que se le pasa como argumento 
        /// </summary>
        /// <param name="binario">Recibe un tipo de dato string</param>
        /// <returns>Retorna un string que representa el numero decimal o "Valor invalido"</returns>
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
        /// <summary>
        /// Convierte de decimal a binario el numero que se le pasa como argumento
        /// </summary>
        /// <param name="numero">Recibe un tipo de dato double</param>
        /// <returns>Retorna un string que representa la conversion exitosa o "Valor invalido"</returns>
        public string DecimalBinario(double numero)
        {
            StringBuilder cadenaDesordenada = new StringBuilder();
            StringBuilder cadenaOrdenada = new StringBuilder();
            string aux;
            string ret;
            int cociente;
            int resto;

            if (numero > -1)
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
        /// <summary>
        /// Convierte de decimal a binario el numero que representa el string pasado como argumento
        /// </summary>
        /// <param name="numero">Recibe un tipo de dato string</param>
        /// <returns>Retorna la representacion exitosa de la conversion o "Valor invalido"</returns>
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
        /// <summary>
        /// Valida que el string pasado como argumento represente un numero binario
        /// </summary>
        /// <param name="binario">Recibe un tipo de dato string</param>
        /// <returns>Retorna true si es binario o false si algun caracter del string no es 0 o 1</returns>
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
        /// <summary>
        /// Es el constructor por defecto, inicializa el campo numero en 0
        /// </summary>
        public Operando()
        {
            this.numero = 0;
        }
        /// <summary>
        /// Sobrecarga del constructor que inicializa el campo numero con el double pasado como argumento
        /// </summary>
        /// <param name="numero">Recibe un tipo de dato double</param>
        public Operando(double numero)
        {
            this.numero = numero;
        }
        /// <summary>
        /// Sobrecarga del constructor que inicializa la propiedad Numero con el string pasado como argumento 
        /// </summary>
        /// <param name="strNumero">Recibe un tipo de dato string</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        /// <summary>
        /// Sobrecarga del operador '-', realiza la resta entre dos objetos Operadores
        /// </summary>
        /// <param name="n1">Recibe un tipo de dato Operando</param>
        /// <param name="n2">Recibe un tipo de dato Operando</param>
        /// <returns>Retorna el resultado de la resta entre n1 y n2</returns>
        public static double operator - (Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;   
        }
        /// <summary>
        /// Sobrecarga del operador '*', realiza la multiplicacion entre dos objetos tipo Operando
        /// </summary>
        /// <param name="n1">Recibe un tipo de dato Operando</param>
        /// <param name="n2">Recibe un tipo de dato Operando</param>
        /// <returns>Retorna la multiplicacion entre n1 y n2</returns>
        public static double operator * (Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        /// <summary>
        /// Sobrecarga del operador '/', realiza la division entre dos objetos de tipo Operando
        /// </summary>
        /// <param name="n1">Recibe un objeto de tipo Operando</param>
        /// <param name="n2">Recibe un objeto de tipo Operando</param>
        /// <returns>Retorna la division entre n1 y n2, o double.MinValue si n2 es 0</returns>
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
        /// <summary>
        /// Sobrecarga del operador '+', realiza la suma entre dos objetos de tipo Operando
        /// </summary>
        /// <param name="n1">Recibe un objeto de tipo Operando</param>
        /// <param name="n2">Recibe un objeto de tipo Operando</param>
        /// <returns>Retorna la suma entre n1 y n2</returns>
        public static double operator + (Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }
        /// <summary>
        /// Comprobará que el valor recibido sea numérico, y lo retornará en formato double. 
        /// </summary>
        /// <param name="strNumero"></param>
        /// <returns>Retorna el valor numerico en double o 0 si no es numerico</returns>
        private double ValidarOperando(string strNumero)
        {
            double ret = 0;          

            if (double.TryParse(strNumero, out ret) == true)
            {
                ret = double.Parse(strNumero);
            }

            return ret;
        }
    
    }
}
