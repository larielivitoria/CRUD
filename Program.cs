using System.Collections.Generic;
using System.Linq;
using CRUD.Opcoes;
// criar, listar, atualizar, deletar clientes

string conexao = "server=localhost;database=clientesdb;uid=root;";

List<Cliente> listaClientes = new List<Cliente>();


void Menu()
{
    Console.WriteLine("Bem vindo ao Cadastro de Clientes");
    Console.WriteLine("1 - Criar Cliente");
    Console.WriteLine("2 - Listar Clientes");
    Console.WriteLine("3 - Atualizar Cliente");
    Console.WriteLine("4 - Deletar Cliente");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            {
                CriarCliente Novo = new CriarCliente();
                Novo.CriarNovoCliente(listaClientes);
                Menu();
                break;
            }
        case 2:
            {
                ListaCliente Lista = new ListaCliente();
                Lista.ListarClientes(listaClientes);
                Menu();
                break;
            }
        case 3:
            {
                MudarCliente Atualizar = new MudarCliente();
                Atualizar.AtualizarCliente(listaClientes);
                Menu();
                break;
            }
        case 4:
            {
                ApagarCliente Apagar = new ApagarCliente();
                Apagar.DeletarCliente(listaClientes);
                Menu();
                break;
            }
        default:
            {
                Console.WriteLine("Opção inválida");
                break;
            }
    }
}


Menu();