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

            }
        }

        public void GerarMenu(){
            Produto prod = new Produto();
            Marca marca= new Marca();

            string opcao = "n";

            do{
                Console.WriteLine("Escolha uma Opção :");
                Console.WriteLine("1 - Cadastrar Produtos");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Deletar Produtos");
                Console.WriteLine("4 - Cadastrar Marcas");
                Console.WriteLine("5 - Listar Marcas");
                Console.WriteLine("6 - Deletar Marcas");
                Console.WriteLine("0 - Sair da aplicação");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        prod.Cadastrar();
                        break;
                    case "2":
                        prod.Listar();
                        break;
                    case "3":
                        break;
                    case "4":
                        marca.CadastrarMarca();
                        break;
                    case "5":
                        break;
                    case "6":
                        break;

                       
                    default:
                        break;
                }
                
            }
        }
        
        public void Logar(Usuario usuario){
            
            Console.WriteLine("Digite seu email :");
            string emailLogin = Console.ReadLine();

            Console.WriteLine("Digite sua Senha: ");
            string senhaLogin = Console.ReadLine();

            if(usuario.Email && senhaLogin == usuario.Senha)

            }
        }
        public void Deslogar(){
            Logado = false;
        }
    }
}