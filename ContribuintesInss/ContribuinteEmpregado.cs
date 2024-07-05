using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesInss
{
    internal class ContribuinteEmpregado : Contribuinte
    {
        public ContribuinteEmpregado(string nome, int idade, string telefone, double salario) : base(nome, idade, telefone, salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }
        double contribuicao;
        public override double ContribuirInss()
        {
            if(salario <= 1399.12)
            {
                contribuicao = salario * 0.08;
            }
            else if(salario <= 2331.88)
            {
                contribuicao = salario * 0.09;
            }
            else
            {
                contribuicao = salario * 0.11;
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
