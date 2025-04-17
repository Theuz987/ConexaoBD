using System;
using System.Collections.Generic; // biblioteca utilizada

namespace ConexaoBD // nome do projeto
{
    class Program // primeiro arquivo que o sistema roda
    {
        static void Main(string[] args)
        {
            Produto p2 = new Produto();
            p2.nome = "Mochila Camu(in)flada";
            p2.preco = 109.90f;
            p2.Insert();

            Produto p = new Produto();
            List<Produto> listamesmo = p.BuscaTodos();

            foreach (Produto produto in listamesmo)
            {
                Console.WriteLine("ID: "+produto.id+" | Nome: "+produto.nome+" | Preço: "+produto.preco);
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
