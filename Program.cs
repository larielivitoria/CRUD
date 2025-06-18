using System.Linq;
    // criar listar atualizar deletar clientes
List<Cliente> listaClientes = new List<Cliente>();
{
    new Cliente { Nome = "Larieli" };
}



//criar cliente
void Menu()
{
    Console.WriteLine("Bem vindo ao Cadastro de Clientes");
    Console.WriteLine("1 - Criar Cliente");
    Console.WriteLine("2 - Lista de Clientes");
    Console.WriteLine("3 - Atualizar Cliente");
    Console.WriteLine("4 - Deletar Cliente");
    int opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            {
                CriarCliente();
                break;
            }
        case 2:
            {
                ListarClientes();
                break;
            }
        case 3:
            {
                AtualizarCliente(); 
                break;
            }
        default:
            {
                Console.WriteLine("Opção inválida");
                break;
            }
    }
}



    
    void CriarCliente()
    {
        Console.WriteLine("Adicione um cliente:");
        
        Console.WriteLine("Insira o nome do cliente");
    
    new Cliente { Nome = Console.ReadLine() };
  

    Console.WriteLine("Nome cadastrado com sucesso");
    Console.WriteLine("digite uma tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    Menu();
    }

void AtualizarCliente()
{
    Console.WriteLine("Digite o nome que deseja atualizar");
    string nomeAtualizar = Console.ReadLine();
    Console.WriteLine("Digite o novo nome");
    string novoNome = Console.ReadLine();

   for (int i = 0; i < listaClientes.Count; i++)
    {
        if(nomeAtualizar == listaClientes[i].Nome)
        {
            listaClientes[i].Nome = novoNome;
            break;
        }
    }

    Console.WriteLine("Nome atualizado");
    Console.WriteLine("Digite uma tecla para continuar");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void ListarClientes()
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
    Menu();
}

Menu();