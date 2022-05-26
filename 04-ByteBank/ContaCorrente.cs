public class ContaCorrente
{
    public string titular;
    public int agencia;
    public int numero;
    public double saldo = 100; //atribuindo um valor padrão ao saldo

    public bool Sacar(double valor)
    {
        if (this.saldo < valor) // o this server para dizer ao código que iremos usar variáveis de uma classe
        {
            return false;
        }
        else
        {
            this.saldo -= valor;
            return true;
        }
    }

    public void Depositar(double valor) //void pois a função não tem retorno, diferente de saldo que pode dar errado ao tentar sacar um número maior que o saldo
    {
        this.saldo += valor;
    }

    public bool Transferir(double valor, ContaCorrente contaDestino)
    {
        if (this.saldo < valor)
        {
            return false;
        }

        this.saldo -= valor;
        contaDestino.Depositar(valor);
        return true;
    }
}