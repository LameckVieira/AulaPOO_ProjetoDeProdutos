using System;
using System.Collections.Generic;

namespace Classes
{
    public class Marca
    {
        private int Codigo { get; set; }
        
        public string NomeMarca { get; set; }

        private DateTime DataCadastro { get; set; }
        
        List<Marca> Marcas { get; set; }

        public Marca CadastrarMarca(){

            Marca novaMarca = new Marca();
            
            Console.WriteLine("Digite o código da marca :");
            Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da marca :");
            NomeMarca = Console.ReadLine();

            DataCadastro = DateTime.UtcNow;

            Marcas.Add(novaMarca);

            return novaMarca;
        }
        public void Listar(){
            Console.WriteLine("MArcas cadastradas :");

            foreach (Marca item in Marcas)
            {
                Console.WriteLine($"Código: {item.Codigo}");
                Console.WriteLine($"Marca: {item.NomeMarca}");
                Console.WriteLine($"data do cadastro: {item.DataCadastro}");
            }

        }
        public void Deletar(int cod){
            Marca marcaDelete = new Marcas.Find(m => m.Codigo == cod);
            Marcas.Remove(marcaDelete);
           
        }
    }
}