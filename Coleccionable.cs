using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface Coleccionable
    {
        int cuantos();
        Comparable minimo();
        Comparable maximo();

        public void agregar(Comparable a);

        public bool contiene(Comparable a);
        
    }
}