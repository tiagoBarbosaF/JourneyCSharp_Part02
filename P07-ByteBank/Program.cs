using System;

namespace P07_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
      
      ContaCorrente contaCorrente = new ContaCorrente(987, 987321);
      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

      Console.WriteLine(contaCorrente.Agencia);
      Console.WriteLine(contaCorrente.Numero);

      ContaCorrente contaCorrenteTiago = new ContaCorrente(987, 987435);
      Console.WriteLine(contaCorrenteTiago.Agencia);
      Console.WriteLine(contaCorrenteTiago.Numero);
      
      Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
    }
  }
}