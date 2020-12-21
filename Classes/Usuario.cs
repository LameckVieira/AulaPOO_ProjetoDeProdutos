using System;

namespace Classes
{
    public class Usuario
    {
        public Usuario(){
            // Cadastrar usuário automatico quando esta classe for instanciada
            Cadastrar();
        }
        public Usuario(int _codigo, string _nome, string _email, string _senha){
            Codigo = _codigo;
            Nome   = _nome;
            Email  = _email;
            Senha  = _senha;
            DataCastro = DateTime.UtcNow;


        }
        int Codigo { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        DateTime DataCastro { get; set; }
        
        public void Cadastrar(){
            Nome = "Lameck";
            Email = "lameck.v.barbosa@gmail.com";
            Senha = "123456";
            DataCastro = DateTime.UtcNow;
        }
        
        public void Deletar(){
            Nome = "";
            Email = "";
            Senha = "";
            DataCastro = DateTime.Parse("0000-00-00T00:00:00");
        }
        
    }
}