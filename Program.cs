using System;
using System.Collections.Generic; // biblioteca utilizada

namespace ConexaoBD // nome do projeto
{
    class Program // primeiro arquivo que o sistema roda
    {
        static void Main(string[] args)
        {
            Conexao c = new Conexao ();
            List<Produto> listamesmo = c.BuscaProdutos();

            foreach(Produto p in listamesmo){
                Console.WriteLine("ID: "+p.id+"; Nome: "+p.nome+"; Preço: "+p.preco);
            }

            // Console.WriteLine("Hello World!");
            // Console.WriteLine("Põe o nome aê: ");
            // string nome = Console.ReadLine();
            // Console.WriteLine("Seja bem-vindo Sr. " +nome);
            //
            // Produto p = new Produto();
            // p.nome = "Lençol";
            // p.preco = 78.90f;
            //
            // Console.WriteLine("O produto é: "+p.nome+" e o preço é :"+p.preco);
        }
    }
}
