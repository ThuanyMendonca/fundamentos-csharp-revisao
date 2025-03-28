using Repositorio;

namespace AppClientes;

class Program
{
    static ClienteRepositorio _clienteRepositorio = new ClienteRepositorio();
    
    static void Main(string[] args)
    {
        _clienteRepositorio.LerDadosClientes();
        
        for (;;) // loop infinito
        {
            Menu();
            Console.ReadKey();
        }
    }

    static void Menu()
    {
        Console.Clear();
        
        Console.WriteLine("Cadastro de Clientes");
        Console.WriteLine("-----------------------");
        Console.WriteLine("1. Cadastrar Cliente");
        Console.WriteLine("2. Listar Clientes");
        Console.WriteLine("3. Editar Cliente");
        Console.WriteLine("4. Excluir Cliente");
        Console.WriteLine("5. Sair");
        Console.WriteLine("-----------------------");
        
        EscolherOpcao();
    }

    static void EscolherOpcao()
    {
        Console.Write("Escolha uma opção: ");
        var opcao = Console.ReadLine();

        switch (int.Parse(opcao))
        {
            case 1:
            {
                _clienteRepositorio.CadastrarCliente();
                Menu();
                break;
            }
            case 2:
            {
                _clienteRepositorio.ListarClientes();
                Menu();
                break;
            }
            case 3:
            {
                _clienteRepositorio.EditarCliente();
                Menu();
                break;
            }
            case 4:
            {
                _clienteRepositorio.ExcluirCliente();
                Menu();
                break;
            }
            case 5:
            {
                _clienteRepositorio.GravarDadosCliente();
                Environment.Exit(0);
                break;
            }
            default:
            {
                Console.Clear();
                Console.WriteLine("Opção inválida");
                break;
            }
                
        }
    }
}