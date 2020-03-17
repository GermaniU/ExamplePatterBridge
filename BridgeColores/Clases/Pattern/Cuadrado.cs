using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeColores.Interfaces;

namespace BridgeColores.Clases.Pattern
{
    public class Cuadrado :IFigura
    {
        private readonly IColor color;

        public Cuadrado(IColor color)
        {
            this.color = color ?? throw new ArgumentNullException(nameof(color));
        }

        public string dibujar()
        {
            return "Cuadrado" + color.RellenarColor();
        }
    }
}
