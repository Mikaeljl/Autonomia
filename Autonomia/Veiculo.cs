using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autonomia
{
    public abstract class Veiculo
    {
        public string Modelo { get; set; }
        public abstract void CalcularAutonomia();
    }
}
