using System;


namespace ClassesAbstratas
{
   public abstract class Bebida
    {
        public void Preparar ()
        {
            Console.WriteLine("incio da preparação");
            AdicionarAgua(); 
            AdicionarSubstancia();
            AdicionarAcucar();
            Console.WriteLine("Bebida preparada");

        }
        public abstract void AdicionarAgua();
        public abstract void AdicionarSubstancia();
        public abstract void AdicionarAcucar();
    }
    public class Cha : Bebida
    {
        public override void AdicionarAgua()
        {
            Console.WriteLine("Adicionadno agua para o Chá");
        }
        public override void AdicionarSubstancia()
        {
            Console.WriteLine("Adicionando Chá");
        }
        public override void AdicionarAcucar()
        {
            Console.WriteLine("Adicionando Açucar ao Chá");
        }
    }


        public class Cafe : Bebida
        {
            public override void AdicionarAgua()
            {
                Console.WriteLine("Adicionadno agua para o Chá");
            }
            public override void AdicionarSubstancia()
            {
                Console.WriteLine("Adicionando Chá");
            }
            public override void AdicionarAcucar()
            {
                Console.WriteLine("Adicionando Açucar ao Chá");
            }


        }
        }
    
