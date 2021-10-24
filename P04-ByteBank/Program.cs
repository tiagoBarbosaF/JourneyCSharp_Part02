using System;

namespace P04_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaCorrenteTiago = new ContaCorrente();

      contaCorrenteTiago.Titular = "Tiago";

      Console.WriteLine($"Titular: {contaCorrenteTiago.Titular}");
      Console.WriteLine($"Saldo atual: {contaCorrenteTiago.Saldo}");
      bool resultSaque = contaCorrenteTiago.Sacar(500);

      if (resultSaque)
      {
        Console.WriteLine("Saque realizado com sucesso:");
        Console.WriteLine($"Saldo após o saque: {contaCorrenteTiago.Saldo}");
      }
      else
      {
        Console.WriteLine("Você não possui saldo para realizar este saque.");
      }

      ContaCorrente contaCorrenteGabriele = new ContaCorrente();

      contaCorrenteGabriele.Titular = "Gabriele";
      Console.WriteLine($"\nSaldo conta Tiago: R$ {contaCorrenteTiago.Saldo}.");
      Console.WriteLine($"Saldo conta Gabriele: R$ {contaCorrenteGabriele.Saldo}.");
      contaCorrenteTiago.Depositar(500);
      Console.WriteLine($"\nVocê realizou um deposito seu saldo é de R$ {contaCorrenteTiago.Saldo}");

      Console.WriteLine($"\nSaldo conta Tiago: R$ {contaCorrenteTiago.Saldo}.");
      Console.WriteLine($"Saldo conta Gabriele: R$ {contaCorrenteGabriele.Saldo}.");

      bool resultTransferTiago = contaCorrenteTiago.Transferir(200, contaCorrenteGabriele);

      if (resultTransferTiago)
      {
        Console.WriteLine($"\nVocê realizou uma transferência com sucesso!");
        Console.WriteLine($"Saldo conta Tiago: R$ {contaCorrenteTiago.Saldo}.");
        Console.WriteLine($"Saldo conta Gabriele: R$ {contaCorrenteGabriele.Saldo}.");
      }
      else
      {
        Console.WriteLine($"Saldo insuficiente para transferência.");
      }

      bool resultTransferGabriele = contaCorrenteGabriele.Transferir(100, contaCorrenteTiago);
      
      if (resultTransferGabriele)
      {
        Console.WriteLine($"\nVocê realizou uma transferência com sucesso!");
        Console.WriteLine($"Saldo conta Tiago: R$ {contaCorrenteTiago.Saldo}.");
        Console.WriteLine($"Saldo conta Gabriele: R$ {contaCorrenteGabriele.Saldo}.");
      }
      else
      {
        Console.WriteLine($"Saldo insuficiente para transferência.");
      }

      bool resulTransferTiago = contaCorrenteTiago.Transferir(2000, contaCorrenteGabriele);
      
      if (resulTransferTiago)
      {
        Console.WriteLine($"\nVocê realizou uma transferência com sucesso!");
        Console.WriteLine($"Saldo conta Tiago: R$ {contaCorrenteTiago.Saldo}.");
        Console.WriteLine($"Saldo conta Gabriele: R$ {contaCorrenteGabriele.Saldo}.");
      }
      else
      {
        Console.WriteLine($"Saldo insuficiente para transferência.");
      }
    }
  }
}