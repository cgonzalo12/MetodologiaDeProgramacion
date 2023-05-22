using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    interface FabricaDeComparables
    {
        Comparable crearAleatorio();

        Comparable crearPorTeclado();

      
    }
}