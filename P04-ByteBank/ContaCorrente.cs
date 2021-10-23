namespace P04_ByteBank
{
  public class ContaCorrente
  {
    public string Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
    public decimal Saldo { get; set; } = 100;

    public bool Sacar(decimal valor)
    {
      if (this.Saldo < valor)
      {
        return false;
      }
      else
      {
        this.Saldo -= valor;
        return true;
      }
    }

    public void Depositar(decimal valor)
    {
      this.Saldo += valor;
    }
  }
}