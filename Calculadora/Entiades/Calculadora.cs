using System;

namespace Entidades
{
    public static class Calculadora
    {
        private static string validarOperador(string operador)
        {
            if ((operador != "+") && (operador != "-") && (operador != "/") && (operador != "*"))
            {
                operador = "+";
            }
            return operador;
        }
        public static double operar(Numero num1, Numero num2, string operador)
        {
            double resultado = 0;

            switch (operador)
            {
                case "+":
                    resultado = num1 + num2;
                    break;
                case "-":
                    resultado = num1 - num2;
                    break;
                case "*":
                    resultado = num1 * num2;
                    break;
                case "/":
                    resultado = num1 / num2;
                    break;
                default:
                    break;
            }
            return resultado;
        }
    }
}


