using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararVendedorDNI:EstrategiaVendedor
    {
        public double datoComparacion(Vendedor _vendeodr){
            double dni=_vendeodr.getDNI;
            return dni;
        }
    }
}