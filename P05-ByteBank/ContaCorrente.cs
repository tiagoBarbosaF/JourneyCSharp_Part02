namespace P05_ByteBank
{
  public class ContaCorrente
  {
    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
    public decimal Saldo { get; set; } = 100;

    public bool Sacar(decimal valor)
    {
      if (Saldo < valor)
        return false;

      Saldo -= valor;
      return true;
    }

    public void Depositar(decimal valor)
    {
      Saldo += valor;
    }

    public bool Transferir(decimal valor, ContaCorrente contaDestino)
    {
      if (Saldo < valor)
        return false;

      Saldo -= valor;
      contaDestino.Saldo += valor;
      return true;
    }
  }
}