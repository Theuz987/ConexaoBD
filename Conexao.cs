using System;
using System.Collections.Generic;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace ConexaoBD {

    class Conexao
    {
        string dadosConexao="server=localhost;user=root;database=teste_ti42;port=3306;password=";

        public List<Produto> BuscaProdutos()
        {
            // Abrir conexão com o banco
            MySqlConnection c = new MySqlConnection(dadosConexao);
            c.Open();
            Console.WriteLine("Conexão realizada com sucessu!");
        
            // Rodar o SQL dentro de banco
            string sql = "SELECT * FROM produtos;";
            MySqlCommand comando = new MySqlCommand(sql, c); // Se colocar SELECT * FROM produtos; dentro do parênteses, a linha acima não é necessária
            MySqlDataReader dados = comando.ExecuteReader();

            List<Produto> listamesmo = new List<Produto>();
            while( dados.Read() )
            {
                // Console.WriteLine("ID: "+dados[0]+" | Nome: "+dados[1]+" | Preço: "+dados[2]);
                Produto p = new Produto();
                p.id = dados.GetInt32("id");
                p.nome = dados.GetString("nome");
                p.preco = dados.GetFloat("preco");
                p.registro = dados.GetDateTime("registro");

                listamesmo.Add(p);
            }

            c.Close();

            return listamesmo;
        }

    }
}
