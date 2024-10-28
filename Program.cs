using System;

namespace ConversorDeTemperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversor de Temperatura");

            Console.Write("Digite a temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escolha a unidade inicial (C para Celsius, F para Fahrenheit, K para Kelvin): ");
            char unidadeInicial = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.WriteLine("Escolha a unidade final (C para Celsius, F para Fahrenheit, K para Kelvin): ");
            char unidadeFinal = Convert.ToChar(Console.ReadLine().ToUpper());

            double resultado = 0;

            if (unidadeInicial == 'C')
            {
                if (unidadeFinal == 'F')
                {
                    resultado = temperatura * 9 / 5 + 32;
                }
                else if (unidadeFinal == 'K')
                {
                    resultado = temperatura + 273.15;
                }
            }
            else if (unidadeInicial == 'F')
            {
                if (unidadeFinal == 'C')
                {
                    resultado = (temperatura - 32) * 5 / 9;
                }
                else if (unidadeFinal == 'K')
                {
                    resultado = (temperatura - 32) * 5 / 9 + 273.15;
                }
            }
            else if (unidadeInicial == 'K')
            {
                if (unidadeFinal == 'C')
                {
                    resultado = temperatura - 273.15;
                }
                else if (unidadeFinal == 'F')
                {
                    resultado = (temperatura - 273.15) * 9 / 5 + 32;
                }
            }

            Console.WriteLine($"O resultado da conversão é: {resultado} {unidadeFinal}");
        }
    }
}
