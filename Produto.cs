using System;
using System.Collections.Generic;
using System.Data;

namespace ConexaoBD
{
    class Produto 
    {
        public int id {get; set;}
        public string nome {get; set;}

        public float preco {get; set;}

        public DateTime registro {get; set;}
        
        Conexao c { get; set;}

        public Produto()
        {
            c = new Conexao();
        }

        public void Insert()
        {
            string query = $"INSERT INTO produtos (nome,preco) VALUES ( '{nome}', {preco.ToString().Replace(",",".")} );";
            c.ExecutaComando(query);
            Console.WriteLine("Produto inserido com sucessu!");
        }

        public List<Produto> BuscaTodos()
        {
           DataTable dt = c.ExecutaSelect("SELECT * FROM produtos;");

           List<Produto> listamesmo = new List<Produto>();
            foreach (DataRow dr in dt.Rows) // ou (DataRow linha in dt.Rows) //
            {
                Produto p = new Produto();

                p.id = int.Parse( dr["id"].ToString() );
                p.nome = dr["nome"].ToString();
                p.preco = float.Parse( dr["preco"].ToString() );
                p.registro = DateTime.Parse ( dr["registro"].ToString() );

                listamesmo.Add( p );
            }

            return listamesmo;
        }
    }
}