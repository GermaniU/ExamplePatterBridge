using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BridgeColores.Clases;
using BridgeColores.Clases.Pattern;

namespace BridgeColores
{
    class Program
    {
        static void Main(string[] args)
        {
            //var CirculoAzul = new CirculoAzul();

            //CirculoAzul.FiguraConColor();

            //var CirculoRojo = new CirculoRojo();

            //CirculoRojo.FiguraConColor();

            //var cuadradoRojo = new CuadradoRojo();

            //cuadradoRojo.FiguraConColor();

            //var CuadradoAzul = new CuadradoAzul();

            //CuadradoAzul.FiguraConColor();

            var color = new Azul();

            var cuadrado = new Cuadrado(color);
            Console.WriteLine(cuadrado.dibujar());

            Console.ReadKey();


       

        }
    }
}
