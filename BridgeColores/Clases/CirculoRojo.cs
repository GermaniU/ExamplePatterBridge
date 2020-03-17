using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeColores.Interfaces;

namespace BridgeColores.Clases
{
    public class CirculoRojo : IFiguraConColor
    {
        public void FiguraConColor()
        {
            Console.WriteLine("Circulo Rojo");
        }
    }
}
