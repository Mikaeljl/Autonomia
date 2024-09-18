using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonomia
{
    public class VeiculoCombustao : Veiculo
    {

        public override void CalcularAutonomia()
        {
            double capacidadeTanque = 100;
            double consumoMedio = 2;
            double autonomia = (capacidadeTanque / consumoMedio)*100;
            Console.WriteLine($"Autonomia de{Modelo}" + autonomia + "kms");
        }
    }
}
