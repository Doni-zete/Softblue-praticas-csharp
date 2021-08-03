using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main()
        {
        }
    }

    public interface IMotorizado
    {
        void Ligar();
        string NomeMotor { get; set; }
    }

    public class Carro : IMotorizado
    {
        public string NomeeMotor { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Ligar()
        {
            throw new NotImplementedException();
        }
    }

}
