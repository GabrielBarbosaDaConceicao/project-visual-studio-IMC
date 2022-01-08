using System;

namespace Desafio_IMC
{

    class Program
    {
        static void ImprimeResultado(double imc)
        {
            if (imc < 18.5)
            {
                Console.WriteLine(string.Format("Abaixo do peso {0:0,0.00}", imc));
            }
            if (imc >= 18.5 && imc < 24.9)
            {
                Console.WriteLine(string.Format("Peso normal {0:0,0.00}", imc));
            }
            if (imc >= 25 && imc < 29.9)
            {
                Console.WriteLine(string.Format("Sobre peso {0:0,0.00}", imc));
            }
            if (imc >= 30 && imc < 34.9)
            {
                Console.WriteLine(string.Format("Obesidade Grau 1 {0:0,0.00}", imc));
            }
            if (imc >= 35 && imc < 39.9)
            {
                Console.WriteLine(string.Format("Obesidade Grau 2 {0:0,0.00}", imc));
            }
            else if (imc >= 40)
            {
                Console.WriteLine(string.Format("Obesidade Morbida {0:0,0.00}", imc));
            }
        }

        static void ImprimirCabecalho(string texto)
        {
            Console.WriteLine("------------------------------ " + texto + " -------------------------\n");
        }

        static void ImprimirCabecalho(string texto, string subTitulo)
        {
            Console.WriteLine("------------------------------ " + texto + " -------------------------\n");
            Console.WriteLine("------------------------------ " + subTitulo + " -------------------------\n");
        }

        static void ImprimirCabecalho(string texto, double numero)
        {
            Console.WriteLine("------------------------------ " + texto + " -------------------------\n");
            Console.WriteLine("------------------------------ " + numero.ToString() + " -------------------------\n");
        }

        static double CalculaImc(double peso, double altura)
        {
            return peso / Math.Pow(altura, 2);
        }

        static string RetornaNome(string texto)
        {
            Console.Write(texto);
            return Console.ReadLine();
        }

        static double RetornaPeso(string texto)
        {
            Console.WriteLine(texto);
            return double.Parse(Console.ReadLine());
        }

        static double RetornaAltura(string texto)
        {
            Console.WriteLine(texto);
            return double.Parse(Console.ReadLine());
        }



        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();



            ImprimirCabecalho("Calcular IMC", 0.0);

            p.Nome = RetornaNome("Qual seu nome: ");

            p.Peso = RetornaPeso("Qual seu Peso: ");

            p.Altura = RetornaAltura("Qual sua altura? ");


            //imc = CalculaImc(p.Peso, p.Altura);
            ImprimeResultado(p.CalcularIMCPublico());

            Console.WriteLine(p.Nome);


        }
    }
}
