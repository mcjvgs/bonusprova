using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEmpresa
{
    // Classe base: dados comuns a Funcionario e Cliente
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Telefone { get; set; }

        public Pessoa(string nome, string cpf, string telefone)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
        }

        // virtual: permite que as classes filhas sobrescrevam (override)
        public virtual void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}