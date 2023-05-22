using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class IteradorPila:Iterador
    {
        private int elementoActual;
        private List<Comparable> lista;

        public IteradorPila(Pila _pila){
            lista =_pila.getLista;
            primero();
        }
        public void primero(){
            elementoActual=lista.Count()-1;
        }
        public void siguiente(){
            elementoActual--;
        }
        public bool fin(){
            return elementoActual<0;
        }
        public Comparable actual(){
            return lista[elementoActual];
        }

    }
}