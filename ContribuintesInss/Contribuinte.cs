using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesInss
{
    abstract class Contribuinte
    {
        protected string nome;
        protected int idade;
        protected string telefone;
        protected double salario;
      

        public Contribuinte(string nome, int idade, string telefone, double salario)
        {
            this.nome = nome;
            this.idade = idade;
            this.telefone = telefone;
            this.salario = salario;
        }

        public virtual double ContribuirInss()
        {
            return 0.0;
        }
        public virtual void Imprimir()
        {
            Console.WriteLine();
        }
    }
}
