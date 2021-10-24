using System;

namespace P06_ByteBank
{
  internal class Program
  {
    public static void Main(string[] args)
    {
      ContaCorrente contaCorrente = new ContaCorrente();
      Cliente cliente = new Cliente();

      cliente.Nome = "Tiago";
      cliente.Cpf = "123.456.789-00";
      cliente.Profissao = "Desenvolvedor";
      
      contaCorrente.Saldo = -10;
      contaCorrente.Titular = cliente;

      Console.WriteLine(contaCorrente.Titular.Nome);
      Console.WriteLine(contaCorrente.Saldo);
    }
  }
}