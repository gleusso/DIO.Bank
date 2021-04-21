using System;
using Enum;

namespace Classes
{
    public class Conta
    {
        private TipoConta TipoConta { get; set; }

        private double Saldo { get; set; }

        private double Credito { get; set; }
        private string Nome { get; set; }


        public Conta(TipoConta tipoConta, double saldo, double cretido, string nome)
        {
            this.TipoConta = tipoConta;
            this.Saldo = saldo;
            this.Credito = cretido;
            this.Nome = nome;

        }

        public bool Sacar(double valorSaque)
        {
            // Validação  de saldo Suficiente 
            if(this.Saldo - valorSaque < (this.Credito= -1))
            {
                Console.WriteLine("Saldo Insuficiente");
                return false;

            }
            this.Saldo -= valorSaque;
              Console.WriteLine("Saldo Atual da Conta é {0} é {1}", this.Nome, this.Saldo);

              return true;
        }

        public void Depisitar(double valorDepoisito)
        {
            this.Saldo += valorDepoisito;

              Console.WriteLine("Saldo Atual da conta é {0} {1}", this.Nome , this.Saldo);
        }

        public void Tranferencia(double valorTrasferencia , Conta contaDeposito)
        {
            if(this.Sacar(valorTrasferencia))
            {
                contaDeposito.Depisitar(valorTrasferencia);
            }
        }

        public override string ToString()
        {

            string retorno = "";
            retorno += "TipodeConta " + this.TipoConta + " | ";
            retorno += "Nome " + this.Nome + " | ";
            retorno += "Saldo " + this.Saldo + " | ";
            retorno += "Credito " + this.Credito;
            return retorno;
        }

    }
}