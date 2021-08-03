using System;


namespace Heranca
{
    sealed class Animal
    {
        public double Altura { get; set; }
        public double Peso { get; set; }
        protected string nome;


        public void Mover()
        {
            Console.WriteLine("Animal se moveu"); 
        }
        public void MostrarDados()
        {
            Console.WriteLine("Altura =" + Altura + "Peso =" );
        }
    }
}
