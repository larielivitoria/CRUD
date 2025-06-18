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
        Console.WriteLine("Digite o nome que deseja atualizar");
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
        }

        Console.WriteLine("Cliente atualizado");
        Console.WriteLine("Digite uma tecla para continuar");
        Console.ReadKey();
        Console.Clear();
    }
}
