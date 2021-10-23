using System;

namespace P02_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaCorrente = new ContaCorrente();

      contaCorrente.Titular = "Tiago";

      Console.WriteLine(contaCorrente.Titular);
      Console.WriteLine(contaCorrente.Agencia);
      Console.WriteLine(contaCorrente.Saldo);
    }
  }
}