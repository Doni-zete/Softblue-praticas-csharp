using EXEMPLOS.Interface;

namespace Exemplos.Models
{
  public interface IMyInterface
  {


    public int Somar(int num1, int num2)
    {
      return num1 + num2;
    }

    public int Subtrair(int num1, int num2)
    {
      return num1 - num2;
    }
  }
}