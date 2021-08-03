using System;
using System.Text;

namespace GenericsConstraints
{
    class Program
    {
        static void Main()
        {
            Creator<StringBuilder> c1 = new Creator<StringBuilder>();
            StringBuilder sb = c1.Create();

            Creator<int> c2 = new Creator<int>();
            int s = c2.Create();
        }
    }

    public class Creator<T> where T : class, new()
    {
         public T Create()

        {
            return new T();
        }
    }


}

