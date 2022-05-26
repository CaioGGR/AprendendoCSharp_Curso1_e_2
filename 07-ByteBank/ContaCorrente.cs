namespace _07_ByteBank //necessário para que o código reconheça as clases espalhadas pelos arquivos
{
    public class ContaCorrente
    {
        
        public Cliente Titular { get; set; } //mesma coisa
        public static int TotalDeContasCriadas { get; private set; } //static = da class
        private int _agencia;
        public int Agencia // com o objetivo de não aceitar nenhuma agência que seja menor ou igual a 0
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value <= 0)
                {
                    return;
                }
                _agencia = value;    
            }
        }
        public int Numero { get; set; }

        private double _saldo = 100; //atribuindo um valor padrão ao saldo

        public double Saldo
        {
            get 
            { 
                return _saldo; 
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }

        public ContaCorrente(int agencia, int numero) //o objetivo disso é fazer com que seja OBRIGATÓRIO colocar a agencia e o numero ao criar uma conta
        {
            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++; //para contabilizar toda vez que uma conta for criada
        }

        public double GetSaldo()
        {
            return _saldo;
        }

        public void SetSaldo(double saldo)
        {
            if (_saldo < 0)
            {
                //ou seja, não faça nada
            }
            else
            {
                this._saldo = saldo;
            }
        }
        // o objetivo desses dois métodos são fazer com que não seja possível haver saldo negativo no banco ByteBank
        public bool Sacar(double valor)
        {
            if (this._saldo < valor) // o this server para dizer ao código que iremos usar variáveis de uma classe
            {
                return false;
            }
            else
            {
                this._saldo -= valor;
                return true;
            }
        }

        public void Depositar(double valor) //void pois a função não tem retorno, diferente de saldo que pode dar errado ao tentar sacar um número maior que o saldo
        {
            this._saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this._saldo < valor)
            {
                return false;
            }

            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}
