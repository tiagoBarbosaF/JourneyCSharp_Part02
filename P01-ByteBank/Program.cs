using System;

namespace P01_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaCorrente = new ContaCorrente();

      contaCorrente.Titular = "Tiago Barbosa";
      contaCorrente.Agencia = 897;
      contaCorrente.Numero = 897325;
      contaCorrente.Saldo = 10000.50;

      Console.WriteLine("\nBanco ByteBank\n");
      Console.WriteLine($"Titular: {contaCorrente.Titular}");
      Console.WriteLine($"Agência: {contaCorrente.Agencia}");
      Console.WriteLine($"Número: {contaCorrente.Numero}");
      Console.WriteLine($"Saldo: {contaCorrente.Saldo:F2}");

      contaCorrente.Saldo += 500.65;
      Console.WriteLine($"\nNovo saldo: {contaCorrente.Saldo:F2}");
      
    }
  }
}