using System;

namespace Classes
{
    public class Login
    {
        public bool Logado { get; set; }

        public Login(){
            Console.ResetColor();
            
            Usuario user = new Usuario();
            Logar(user);
            if (Logado){
                GerarMenu();

            }
        }

        public void GerarMenu(){
            Produto produto = new Produto();
            Marca marca= new Marca();

            string opcao = "n";

            do{
                Console.WriteLine();
                Console.WriteLine("--------Menu--------");
                Console.WriteLine();
                Console.WriteLine("Escolha uma Opção :");
                Console.WriteLine("1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Deletar Produtos");
                Console.WriteLine("4 - Cadastrar Marcas");
                Console.WriteLine("5 - Listar Marcas");
                Console.WriteLine("6 - Deletar Marcas");
                Console.WriteLine("0 - Sair da aplicação");
                Console.WriteLine();

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        produto.Cadastrar();
                        break;
                    case "2":
                        produto.Listar();
                        break;
                    case "3":
                        Console.WriteLine("Digite um codigo para excluir :");
                        int cod = int.Parse(Console.ReadLine());
                        produto.Deletar(cod);
                        break;
                    case "4":
                        marca.CadastrarMarca();
                        break;
                    case "5":
                        marca.Listar();
                        break;
                    case "6":
                        Console.WriteLine("Digite um codigo para excluir :");
                        int codMarca = int.Parse(Console.ReadLine());
                        marca.Deletar(codMarca);
                        break;   
                    default:
                        break;
                }
                
            }while(opcao != "0");
        }
        
        public void Logar(Usuario usuario){
            
            Console.WriteLine("Digite seu email :");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua Senha: ");
            string senhaLogin = Console.ReadLine();

            if(emailLogin == usuario.Email && senhaLogin == usuario.Senha){
                Logado = true;
                Console.WriteLine();
                Console.WriteLine("Login efetuado com sucesso!");
            }else{
                Console.WriteLine();
                Console.WriteLine("Falha ao logar na aplicação");
            }
        }
        public void Deslogar(){
            Logado = false;
        }
    }
}