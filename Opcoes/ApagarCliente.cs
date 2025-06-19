using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Opcoes;

internal class ApagarCliente
{
    public void DeletarCliente(List<Cliente> listaClientes)
    {
        string conexao = "server=localhost;database=clientesdb;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();

        Console.WriteLine("Digite o nome que deseja excluir");
        string nomeRemover = Console.ReadLine();

        var cmd = new MySqlCommand($"DELETE FROM clientes WHERE nome = '{nomeRemover}'", conn);
        cmd.ExecuteNonQuery();

        conn.Close();
        Console.WriteLine("Cliente excluído com sucesso");

        /*Console.WriteLine("Digite o Cliente que deseja deletar");
        string nomeRemover = Console.ReadLine();

        for (int i = 0; i < listaClientes.Count; i++)
        {
            if (listaClientes[i].Nome == nomeRemover)
            {
                listaClientes.RemoveAt(i);
                Console.WriteLine("Cliente removido");
            }
        }*/

        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();

    }
}
