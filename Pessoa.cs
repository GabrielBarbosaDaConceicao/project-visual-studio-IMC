using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_IMC
{
    public class Pessoa
    {
        private string nome;
        public string Nome
        {
            get { return nome.ToLower(); }
            set { nome = value.ToUpper(); }
        }

        public double Peso { get; set; }
        public double Altura { get; set; }

        private double CalcularIMC()
        {
            return Peso / Math.Pow(Altura, 2);
        }
        public double CalcularIMCPublico()
        {
            return CalcularIMC();
        }


    }
}