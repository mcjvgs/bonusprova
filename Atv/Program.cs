using System;

namespace SistemaEmpresa
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa("Tech Solutions Ltda", "12.345.678/0001-90");

            empresa.ContratarFuncionario(new Funcionario("Ana Souza", "111.111.111-11", "(11) 91111-1111", "Desenvolvedora", 6500m));
            empresa.ContratarFuncionario(new Funcionario("Carlos Lima", "222.222.222-22", "(11) 92222-2222", "Gerente", 9800m));

            empresa.CadastrarCliente(new Cliente("Maria Oliveira", "333.333.333-33", "(11) 93333-3333", "maria@email.com", "São Paulo"));
            empresa.CadastrarCliente(new Cliente("João Pereira", "444.444.444-44", "(21) 94444-4444", "joao@email.com", "Rio de Janeiro"));

            empresa.ExibirDados();

            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}