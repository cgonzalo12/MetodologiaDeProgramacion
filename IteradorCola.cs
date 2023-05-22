using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class IteradorCola:Iterador
    {
        private int elementoActual;
        private List<Comparable> lista;

        public IteradorCola(Cola _cola){
            lista=_cola.getCola;

        }
        public void primero(){
            elementoActual=0;
        }
        public void siguiente(){
            elementoActual++;
        }
        public bool fin(){
            return elementoActual >= lista.Count();
        }
        public Comparable actual(){
            return lista[elementoActual];
        }

        
    }
}