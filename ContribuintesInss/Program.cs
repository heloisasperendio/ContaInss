using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContribuintesInss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Contribuinte Empregado\n");
            var ce1 = new ContribuinteEmpregado("Heloisa", 22, "551199999999", 2000);
            var ce2= new ContribuinteEmpregado("Thuilo", 25, "551199999999", 300);
            var ce3 = new ContribuinteEmpregado("Thuilo", 25, "551199999999", 15000);

            ce1.Imprimir();
            ce2.Imprimir();
            ce3.Imprimir();

            Console.WriteLine("\nContribuinte Individual\n");
            var ci1 = new ContribuinteIndividual("Heloisa", 22, "551199999999", 600);
            var ci2 = new ContribuinteIndividual("Thuilo", 25, "551199999999", 4000);

            ci1.Imprimir();
            ci2.Imprimir();


        }
    }
}
