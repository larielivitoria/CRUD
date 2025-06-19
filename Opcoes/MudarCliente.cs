using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Opcoes;

internal class MudarCliente
{
    public void AtualizarCliente(List<Cliente> listaClientes)
    {

        string conexao = "server=localhost;database=clientesdb;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();

        Console.WriteLine("Digite o nome que deseja atualizar");
        string nomeAntigo = Console.ReadLine();

        Console.WriteLine("Digite o novo nome");
        string nomeNovo = Console.ReadLine();

        var cmd = new MySqlCommand($"UPDATE clientes SET nome = '{nomeNovo}' WHERE nome = '{nomeAntigo}'",conn);
        cmd.ExecuteNonQuery();

        conn.Close();

        /* Console.WriteLine("Digite o nome que deseja atualizar");
         string nomeAtualizar = Console.ReadLine();
         Console.WriteLine("Digite o novo nome");
         string novoNome = Console.ReadLine();

         for (int i = 0; i < listaClientes.Count; i++)
         {
             if (nomeAtualizar == listaClientes[i].Nome)
             {
                 listaClientes[i].Nome = novoNome;
                 break;
             }
         }*/

        Console.WriteLine("Cliente atualizado com sucesso");
        Console.WriteLine("Digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}
