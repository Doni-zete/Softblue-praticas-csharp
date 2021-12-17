namespace ExemploConstrutores.models
{
  public class Pessoa
  {
    private readonly string nome = "Doni";
    private readonly string sobrenome;
    public Pessoa()
    {
      nome = string.Empty;
      sobrenome = string.Empty;
    }

    public Pessoa(string nome, string sobrenome)
    {

      this.nome = nome;
      this.sobrenome = sobrenome;

    }

    public void Apresentar()
    {
     
      System.Console.WriteLine($"Olá, meu nome e: {nome} {sobrenome}");
    }

  }
}