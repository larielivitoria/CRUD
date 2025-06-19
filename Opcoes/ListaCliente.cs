using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD.Opcoes;

internal class ListaCliente
{
    public void ListarClientes(List<Cliente> listaClientes)
    {
        string conexao = "server=localhost;database=clientesdb;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();

        Console.WriteLine("Lista de clientes");
        var cmd = new MySqlCommand("SELECT * FROM clientes", conn);
        var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            Console.WriteLine($"{reader["nome"]}");
        }

        reader.Close();
        conn.Close();

        /*Console.WriteLine("Lista de clientes");
        for (int i = 0; i < listaClientes.Count; i++)
        {
            Cliente cliente = listaClientes[i];
            Console.WriteLine($"Nome: {cliente.Nome}");
        }*/

        Console.WriteLine("Lista completa");
        Console.WriteLine("Digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();

    }

}
