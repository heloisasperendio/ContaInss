using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesInss
{
    internal class ContribuinteIndividual : Contribuinte
    {
        public ContribuinteIndividual(string nome, int idade, string telefone, double salario) : base(nome, idade, telefone, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }
        double contribuicao;
        public override double ContribuirInss()
        {
            if (this.salario <= 788)
            {
                contribuicao = this.salario * 0.11;
            }
            else
            {
                contribuicao = this.salario * 0.20;
            }
            return contribuicao;
        }
        public override void Imprimir()
        {
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Salario: {salario}");
            Console.WriteLine($"Contribuição: {ContribuirInss()}");
        }
    }
}
