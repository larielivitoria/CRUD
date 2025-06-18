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
        Console.WriteLine("Lista de clientes");
        for (int i = 0; i < listaClientes.Count; i++)
        {
            Cliente cliente = listaClientes[i];
            Console.WriteLine($"Nome: {cliente.Nome}");
        }

        Console.WriteLine("Lista completa");
        Console.WriteLine("Digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();

    }

}
