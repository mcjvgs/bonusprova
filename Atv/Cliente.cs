using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SistemaEmpresa
{
    // Herança: Cliente "é uma" Pessoa
    public class Cliente : Pessoa
    {
        public string Email { get; set; }
        public string Cidade { get; set; }

        public Cliente(string nome, string cpf, string telefone, string email, string cidade)
            : base(nome, cpf, telefone)
        {
            Email = email;
            Cidade = cidade;
        }

        public override void ExibirDados()
        {
            Console.WriteLine("--- CLIENTE ---");
            base.ExibirDados();
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Cidade: {Cidade}");
        }
    }
}