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
        Console.WriteLine("Digite o Cliente que deseja deletar");
        string nomeRemover = Console.ReadLine();

        for (int i = 0; i < listaClientes.Count; i++)
        {
            if (listaClientes[i].Nome == nomeRemover)
            {
                listaClientes.RemoveAt(i);
                Console.WriteLine("Cliente removido");
            }
        }

        Console.WriteLine("Digite uma tecla para voltar ao menu");
        Console.ReadKey();
        Console.Clear();

    }
}
