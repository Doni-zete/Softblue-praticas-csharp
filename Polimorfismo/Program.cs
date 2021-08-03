using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Program
    {
        static void Main()
        {

            Animal a = new Gato();
            //if( a is Cachorro)
            //{

            //    Cachorro c = (Cachorro)a;
            //    c.Morder();
            //}
            //else
            //{
            //    Console.WriteLine("o casting não pode ser feito");
            //}
            Cachorro c = a as Cachorro;
            if (c != null)
            {
                c.Morder();
            }
            else
            {
                Console.WriteLine("o casting não pode ser feito");
            }

        }
    }
    public class Animal
    {
        public virtual void Falar()
        {
            Console.WriteLine("---");
        }
    }

    public class Cachorro : Animal
    {
        public override void Falar()
        {
            Console.WriteLine("AU-AU");
        }
        public void Morder()
        {
            Console.WriteLine("nhaque");
        }

    }




    public class Gato : Animal
    {

        public override void Falar()
        {
            Console.WriteLine("MIAU");
        }
    }
}
