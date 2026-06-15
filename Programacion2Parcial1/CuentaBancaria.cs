public class CuentaBancaria
{
    private decimal saldo;

    public void Depositar(decimal monto)
    {
        saldo += monto;
    }

    public decimal ObtenerSaldo()
    {
        return saldo;
    }
}