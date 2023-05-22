using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararVendedorBonus:EstrategiaVendedor
    {
        public double datoComparacion(Vendedor _vendedor){
            return _vendedor.getBonus;
        }
    }
}