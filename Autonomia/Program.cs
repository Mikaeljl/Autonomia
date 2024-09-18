using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Autonomia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Veiculo> veiculos = new List<Veiculo>()
            {
                new VeiculoCombustao { Modelo = "Corola" },
                new VeiculoEletrico { Modelo = "Prisma" }

            };
            foreach (var veiculo in veiculos)
            {
                veiculo.CalcularAutonomia(); // Polimorfismo em ação
            }

            Console.ReadLine();
        }
    }
}
