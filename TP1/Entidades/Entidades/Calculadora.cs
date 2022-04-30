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

}
