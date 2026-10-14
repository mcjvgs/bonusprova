using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEmpresa
{
    // Empresa possui funcionários e clientes
    public class Empresa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public List<Funcionario> Funcionarios { get; } = new List<Funcionario>();
        public List<Cliente> Clientes { get; } = new List<Cliente>();

        public Empresa(string razaoSocial, string cnpj)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
        }

        public void ContratarFuncionario(Funcionario f) => Funcionarios.Add(f);
        public void CadastrarCliente(Cliente c) => Clientes.Add(c);

        public void ExibirDados()
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"EMPRESA: {RazaoSocial}");
            Console.WriteLine($"CNPJ: {Cnpj}");
            Console.WriteLine("========================================");

            Console.WriteLine($"\nTotal de funcionários: {Funcionarios.Count}\n");
            foreach (var f in Funcionarios)
            {
                f.ExibirDados();
                Console.WriteLine();
            }

            Console.WriteLine($"Total de clientes: {Clientes.Count}\n");
            foreach (var c in Clientes)
            {
                c.ExibirDados();
                Console.WriteLine();
            }
        }
    }
}

