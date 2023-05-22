using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class IteradorConjunto:Iterador
    {
        private int elementoActual;
        private List<Comparable> elementos;

        public IteradorConjunto(Conjunto _conjunto){
            elementos=_conjunto.getElementos;
            primero();
        }
        public void primero(){
            elementoActual=0;
        }
        public void siguiente(){
            elementoActual++;
        }
        public bool fin(){
            return elementoActual >= elementos.Count();
        }
        public Comparable actual(){
            return elementos[elementoActual];
        }
    }
}