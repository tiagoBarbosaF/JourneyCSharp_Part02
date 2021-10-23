using System;

namespace P04_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaCorrente = new ContaCorrente();

      contaCorrente.Titular = "Tiago";

      Console.WriteLine($"Titular: {contaCorrente.Titular}");
      Console.WriteLine($"Saldo atual: {contaCorrente.Saldo}");
      bool resultSaque = contaCorrente.Sacar(500);

      if (resultSaque == true)
      {
        Console.WriteLine("Saque realizado com sucesso:");
        Console.WriteLine($"Saldo após o saque: {contaCorrente.Saldo}");
      }
      else
      {
        Console.WriteLine("Você não possui saldo para realizar este saque.");
      }

      Console.WriteLine($"\nSeu saldo atual é {contaCorrente.Saldo}.");
      contaCorrente.Depositar(500);
      Console.WriteLine($"\nVocê realizou um deposito seu saldo é de R$ {contaCorrente.Saldo}");
    }
  }
}