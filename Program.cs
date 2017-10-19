using System;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcao = "";
            do
            {
                System.Console.WriteLine("Digite a opção...");
                System.Console.WriteLine("1 - Cadastrar Cliente");
                System.Console.WriteLine("2 - Cadastrar Produto");
                System.Console.WriteLine("3 - Realizar venda");
                System.Console.WriteLine("4 - Extrato Cliente");
                System.Console.WriteLine("9 - Sair");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        CadastrarCliente();
                        break;

                    case "2":
                         CadastrarProduto();
                        break;

                    case "3":
                         RealizarVenda();
                        break;

                    case "4":
                        ExtratoCliente();
                        break;
                }

            } while (opcao != "9");
        }

        //Cadastro novo cliente
        static void CadastrarCliente(){

        }
            //Cadastrar Produto
        static void CadastrarProduto(){

        }
            // Realiza as vendas
        static void RealizarVenda(){

        }
            //Mostra Extrato do Cliente
        static void ExtratoCliente(){

        }

    }
}
