using System;

namespace P03_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaDoTiago = new ContaCorrente();
      contaDoTiago.Titular = "Tiago";
      contaDoTiago.Agencia = 764;
      contaDoTiago.Numero = 764123;

      ContaCorrente contaDoTiagoBarbosa = new ContaCorrente();
      contaDoTiagoBarbosa.Titular = "Tiago";
      contaDoTiagoBarbosa.Agencia = 764;
      contaDoTiagoBarbosa.Numero = 764123;

      Console.WriteLine($"Igualdade do tipo referência: {contaDoTiago == contaDoTiagoBarbosa}");

      int idade = 27;
      int idadeMaisUmaVez = 27;

      Console.WriteLine($"Igualdade do tipo de valor: {idade == idadeMaisUmaVez}");

      contaDoTiago = contaDoTiagoBarbosa;
      Console.WriteLine(contaDoTiago == contaDoTiagoBarbosa);

      contaDoTiago.Saldo = 300;
      Console.WriteLine(contaDoTiago.Saldo);
      Console.WriteLine(contaDoTiagoBarbosa.Saldo);
    }
  }
}