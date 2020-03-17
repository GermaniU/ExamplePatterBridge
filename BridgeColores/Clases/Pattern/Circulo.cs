using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeColores.Interfaces;

namespace BridgeColores.Clases.Pattern
{
    public class Circulo :IFigura
    {
        private readonly IColor color;

        public Circulo(IColor color)
        {
            this.color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public string dibujar()
        {
            return "Circulo" + color.RellenarColor();
        }
    }
}
