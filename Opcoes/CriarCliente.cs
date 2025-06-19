using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CRUD.Opcoes;

internal class CriarCliente
{
    public void CriarNovoCliente(List<Cliente> listaClientes)
    {
        string conexao = "server=localhost;database=clientesdb;uid=root;pwd=4161;";

        var conn = new MySqlConnection(conexao);
        conn.Open();

        Console.WriteLine("Digite o nome do cliente");
        string nome = Console.ReadLine();

        var cmd = new MySqlCommand("INSERT INTO clientes (nome) VALUES (@nome)", conn);
        cmd.Parameters.AddWithValue("@nome", nome);
        cmd.ExecuteNonQuery();

        conn.Close();

        /*Console.WriteLine("Adicione um cliente");

        Console.WriteLine("Insira o nome do cliente");
        string nome1 = Console.ReadLine();

        Cliente novoCliente = new Cliente
        {
            Nome = nome
        };

        listaClientes.Add(novoCliente);*/

       

        Console.WriteLine("Cliente criado com sucesso");
        Console.WriteLine("digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
       
    }
}
