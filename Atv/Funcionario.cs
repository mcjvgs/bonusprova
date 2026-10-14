using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmpresa
{
    // Herança: Funcionario "é uma" Pessoa
    public class Funcionario : Pessoa
    {
        public string Cargo { get; set; }
        public decimal Salario { get; set; }

        public Funcionario(string nome, string cpf, string telefone, string cargo, decimal salario)
            : base(nome, cpf, telefone)
        {
            Cargo = cargo;
            Salario = salario;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("--- FUNCIONÁRIO ---");
            base.ExibirDados();
            Console.WriteLine($"Cargo: {Cargo}");
            Console.WriteLine($"Salário: {Salario:C2}");
        }
    }
}
