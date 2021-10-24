namespace P07_ByteBank
{
  public class ContaCorrente
  {
    public Cliente Titular { get; set; }

    public static int TotalDeContasCriadas { get; private set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }

    private decimal _saldo = 100;

    public decimal Saldo
    {
      get => _saldo;
      set
      {
        if (value < 0)
          return;

        _saldo = value;
      }
    }

    public ContaCorrente(int agencia, int numero)
    {
      Agencia = agencia;
      Numero = numero;

      TotalDeContasCriadas++;
    }

    public bool Sacar(decimal valor)
    {
      if (_saldo < valor)
        return false;

      _saldo -= valor;
      return true;
    }

    public void Depositar(decimal valor)
    {
      _saldo += valor;
    }

    public bool Transferir(decimal valor, ContaCorrente contaDestino)
    {
      if (_saldo < valor)
        return false;

      _saldo -= valor;
      contaDestino.Depositar(valor);
      return true;
    }
  }
}