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
        Console.WriteLine("Adicione um cliente");

        Console.WriteLine("Insira o nome do cliente");
        string nome = Console.ReadLine();

        Cliente novoCliente = new Cliente
        {
            Nome = nome
        };

        listaClientes.Add(novoCliente);

        Console.WriteLine("Cliente criado com sucesso");
        Console.WriteLine("digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
       
    }
}
