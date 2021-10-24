using System;

namespace P05_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      Cliente tiago = new Cliente();

      tiago.Nome = "Tiago";
      tiago.Cpf = "123.456.789-0";
      tiago.Profissao = "Desenvolvedor C#";

      ContaCorrente contaCorrente = new ContaCorrente();

      contaCorrente.Titular = tiago;
      contaCorrente.Saldo = 1000;
      contaCorrente.Agencia = 789;
      contaCorrente.Numero = 789123;

      contaCorrente.Titular.Nome = "Tiago Barbosa";

      Console.WriteLine(tiago.Nome);
      Console.WriteLine(contaCorrente.Titular.Nome);
    }
  }
}