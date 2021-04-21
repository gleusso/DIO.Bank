using System.Diagnostics;
using System.Collections.Generic;
using System;
using Classes;
using Enum;

namespace DIO.Bank
{
    class Program
    {
        static List<Conta> listaContas = new List<Conta>();
        static void Main(string[] args)
        {

            //  Console.BackgroundColor = ConsoleColor.Blue;
            // Conta minhaConta = new Conta(TipoConta.PessoaFisica, 0, 0, "Gleusso");
            //Console.WriteLine(minhaConta.ToString());

            string opcaoUsuario = ObterOpcaoDaConta();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        ListarContas();
                        break;
                    case "2":
                        InserirConta();
                        break;
                    case "3":
                        Traferencia();
                        break;
                    case "4":
                        Sacar();
                        break;
                    case "5":
                        Depositar();
                        break;
                    case "C":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();

                }
                opcaoUsuario = ObterOpcaoDaConta();
            }


            Console.WriteLine("Obrigado Por Utilizar nossos serviços ");
            Console.ReadLine();
        }

        private static void Depositar()
        {
            Console.WriteLine("Digite Numero da Conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite valor ser Depositado");
            double valorDepoisito = double.Parse(Console.ReadLine());


            listaContas[indiceConta].Depisitar(valorDepoisito);
        }

        private static void Traferencia()
        {
            Console.WriteLine("Digite Numero da Conta de Origem ");
            int indeceDeOrigem = int.Parse(Console.ReadLine());

             Console.WriteLine("Digite Numero a conta do Desdino");
             int indiceDesdino = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite Valor a ser Transferido ");
            double valorTrasferencia = double.Parse(Console.ReadLine());


            listaContas[indeceDeOrigem].Tranferencia(valorTrasferencia, listaContas[indiceDesdino]);

        }

        private static void Sacar()
        {
            Console.WriteLine("Digite o Número da Conta ");
            int indiceConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Valor ser Sacado ");
            double valorSaque = double.Parse(Console.ReadLine());

            listaContas[indiceConta].Sacar(valorSaque);
        }

        private static void ListarContas()
        {
            Console.WriteLine("Lista de Contas ");

            if (listaContas.Count == 0)
            {
                Console.WriteLine("Nenhuma Conta  Cadastrada");
                return;
            }
            for (int i = 0; i < listaContas.Count; i++)
            {
                Conta conta = listaContas[i];
                Console.WriteLine("#{0} . ", i);
                Console.WriteLine(conta);
            }
        }

        private static void InserirConta()
        {
            Console.WriteLine("Inserir nova Conta");

            Console.WriteLine("Digite 1 para conta Fisica ou 2 para Juridica ");
            int entradaTipoDeconta = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Nome da Cliente");
            string entradaNome = Console.ReadLine();

            Console.WriteLine("Digite  Saldo Inicial ");
            double entradaSaldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Credito ");
            double entradaCredito = double.Parse(Console.ReadLine());

            Conta novaConta = new Conta(tipoConta: (TipoConta)entradaTipoDeconta,
                                           saldo: entradaSaldo,
                                           cretido: entradaCredito,
                                           nome: entradaNome);

            listaContas.Add(novaConta);
        }

        private static string ObterOpcaoDaConta()
        {
            Console.WriteLine();
            Console.WriteLine("Dio Bank a seu Dispor!!!!!");
            Console.WriteLine("Informe a Opção ");
            Console.WriteLine("1 Listas de Contas ");
            Console.WriteLine("2 Inserir uma nova Conta ");
            Console.WriteLine("3 Traferencias ");
            Console.WriteLine("4 Sacar ");
            Console.WriteLine("5 Depoisitar");
            Console.WriteLine("C Limpar tela");
            Console.WriteLine("X Sair");
            string opcaoUsuario = Console.ReadLine().ToUpper();
            Console.WriteLine();
            return opcaoUsuario;

        }
    }
}
