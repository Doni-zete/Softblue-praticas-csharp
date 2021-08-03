using System;


namespace ApplicationExcepions
{
    public class ContaCorrentes
    {
        private double saldo;
        public void Sacar(double valor)
        {
            if (valor <= 0)
            {
                throw new ContaCorrente("valor tem que ser maior que zero");
            }

            if (saldo - valor < 0)

            {
                throw new ContaCorrente("O saldo e insuficiente");
            }

            saldo -= valor;
        }
        public void Depositar(double valor)
        {
            if (valor <= 0)
            {
                throw new ContaCorrente("Valor tem que ser maior que zero");
            }

            saldo += valor;
        }
    }
}
