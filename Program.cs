using System;
using System.IO;

namespace sistema_vendas
{
    class Program
    {
        static void Main(string[] args)
        {
             string opcao = "";
            do
            {
                System.Console.WriteLine("Menu Principal: digite uma opção...");
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
        static void CadastrarCliente()
        {
            System.Console.WriteLine("Por favor escolha uma opção:");
            System.Console.WriteLine("1 - Cliente Pessoa Física ");
            System.Console.WriteLine("2 Cliente Pessoa Jurídica");

            string cpf;
            string cnpj;
            string nome;
            string email;
            string opcao = Console.ReadLine();

            switch (opcao)
            {

                case "1":
                    {
                        bool cpfvalido = false;

                        do
                        {
                            Console.WriteLine("Digite seu cpf");
                            cpf = Console.ReadLine();
                           
                            cpfvalido = validarCPF(cpf);

                            if (cpfvalido == true)
                            {
                                System.Console.WriteLine("Cpf Valido");
                            }
                            else
                            System.Console.WriteLine("Cpf incorreto, Digite novamente");

                        } while (cpfvalido != true);

                         System.Console.WriteLine("Digite seu nome:");
                         nome = Console.ReadLine();
                         System.Console.WriteLine("Digite seu email");
                         email = Console.ReadLine();


                        StreamWriter sw = new StreamWriter("Cadastro de Cliente.csv", true);
                        sw.WriteLine(cpf + ";" + email + ";" + nome);
                        sw.Close();

                        break;
                    }


                case "2":
                {
                    bool cnpjvalido = false;

                        do
                        {
                            Console.WriteLine("Digite seu CNPJ");
                            cnpj = Console.ReadLine();
                           
                            cnpjvalido = validarCNPJ(cnpj);

                            if (cnpjvalido == true)
                            {
                                System.Console.WriteLine("CNPJ Valido");
                            }
                            else
                            System.Console.WriteLine("CNPJ incorreto, Digite novamente");

                        } while (cnpjvalido != true);

                         System.Console.WriteLine("Digite seu nome:");
                         nome = Console.ReadLine();
                         System.Console.WriteLine("Digite seu email");
                         email = Console.ReadLine();


                        StreamWriter sw = new StreamWriter("Cadastro de Cliente.csv", true);
                        sw.WriteLine(cnpj + ";" + email + ";" + nome);
                        sw.Close();
                    
                }
                break;
            }

        }
            //Cadastrar Produto
        static void CadastrarProduto(){

            string codigoProduto, nomeProduto, descricao, preco;

            System.Console.WriteLine("Digite o codigo do produto");
            codigoProduto = Console.ReadLine();

            System.Console.WriteLine("Digite o nome do Produto ");
            nomeProduto = Console.ReadLine();

            System.Console.WriteLine("Faça uma breve descrição do produto");
            descricao = Console.ReadLine();

            System.Console.WriteLine("Qual o preço do Produto");
            preco = Console.ReadLine();

              StreamWriter sw = new StreamWriter("Produtos Cadastrados.csv", true);
                        sw.WriteLine(codigoProduto + ";" + nomeProduto + ";" + descricao + ";" + preco);
                        sw.Close();

        }
            // Realiza as vendas
        static void RealizarVenda(){

            string  documento;

            System.Console.WriteLine("---------Vamos pesquisar o cliente---------- \n Digite o CNPJ ou CPF");
            documento = Console.ReadLine();

            
            //trazendo dados do arquivo externo para o array linhasCliente
           string[] linhasCliente = System.IO.File.ReadAllLines("Cadastro de Cliente.csv");


            foreach(string linha in linhasCliente){

                    if(linha.Contains(documento) == true)
                    {
                    System.Console.WriteLine("Os dados do cliente São: \n " + linha);
                    }
            }

            string[] linhasProduto = System.IO.File.ReadAllLines("Produtos Cadastrados.csv");
            System.Console.WriteLine("Escolha um produto da lista a seguir: \n");

          foreach (string linha in linhasProduto)
          {              
              System.Console.WriteLine(linha);
          }

          
          System.Console.WriteLine("Digite o código do produto");
          string codigoDigitado = Console.ReadLine();

          StreamWriter sw = new StreamWriter("Vendas realizadas.csv", true);
          string nomeCliente, nomeProduto, dataVenda;

          

          foreach(string codigo in linhasProduto){

              if(codigo.Contains(codigoDigitado) == true)
              {
                
                //falta inserir os dados da venda
                        sw.WriteLine(documento + );
                        sw.Close();
              }
          }
        

            
        }
            //Mostra Extrato do Cliente
        static void ExtratoCliente(){

        }

        static bool validarCPF(string cpf){
            bool cpfvalido = false;

            if(cpf == "40344056864")
                cpfvalido = true;
        
        return cpfvalido;
        
        }

        static bool validarCNPJ(string cnpj){
            bool cnpjvalido = false;

            if (cnpj == "40344056864")
                cnpjvalido = true;

            return cnpjvalido;    
            
                
            

        }
    }
}
