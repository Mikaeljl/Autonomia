using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonomia
{
    public class VeiculoEletrico : Veiculo
    {
        public override void CalcularAutonomia()
        {
            double capacidadeBateria = 100;
            double consumoMedio = 6;
            double autonomia = (capacidadeBateria / consumoMedio) * 100;
            Console.WriteLine($"Autonomia de{Modelo}" + autonomia + "kms");
        }
    }
}
