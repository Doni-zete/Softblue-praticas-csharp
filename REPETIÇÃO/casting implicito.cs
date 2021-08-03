using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main()

        {
            //casting implicito
            int i = 10;
            double d = i;

            //Casting Implicito
            short s = 5;
            long l = s;

            //casting explicito
            double d2 = 3.5;
            int i2 = (int)d2;

            long l2 = 25;
            int i3 = (int)l2;

            long l3 = 438746387462735;
            int i4 = (int)l3;

            Console.WriteLine(i4);

        }
    }

}    






