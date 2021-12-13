using Exemplos.Models;

namespace EXEMPLOS.Models
{
  public class Corrente : Conta
  {
    public override void Creditar(double valor)
    {
      base.saldo = valor;
    }
  }
}