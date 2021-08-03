using System;


namespace ExplicitInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            objeto o = new objeto();
            //o.EmitirSom();
            IAnimal a = (IAnimal)o;
            a.EmitirSom();

            IBrinquedo b = (IBrinquedo)o;
            b.EmitirSom();
        }
    }
    class objeto : IAnimal, IBrinquedo
    {
        void IAnimal.EmitirSom()
        {
            Console.WriteLine("Animal emitiu som");
        }

        void IBrinquedo.EmitirSom()
        {
            Console.WriteLine("Brinquedo emitiu som");
        }
    }
}
