using System;

namespace InnerExceptions
{
    class Program
    {
        static void Main(string[] args)
        {

        }

    }
    class Calculador
    {
        public double Dividir(double a, double b)
        {

        }
    }
    class Divisão
    {
        public double Numerador { get; private set; }
        public double Denominador { get; private set; }
        public Divisão(double numerador, double denominador)
        {
            this.Numerador = numerador;
            this.Denominador = denominador;
        }
        public double Dividir()
        {
            if (Denominador == 0)
            {
                throw new DivisaoException("Denominador não pode ser zero");
            }
            return Numerador / Denominador;
        }
    }
}
