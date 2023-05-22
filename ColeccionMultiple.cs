using System.Collections.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class ColeccionMultiple:Coleccionable
    {
        Pila pila;
        Cola cola;

        public ColeccionMultiple(Pila _pila, Cola _cola){
            this.cola=_cola;
            this.pila=_pila;
        }
       
        public int cuantos(){
            int suma=pila.cuantos()+cola.cuantos();
            return suma;
        }

        public Comparable minimo(){
            Comparable colaMin=cola.minimo();
            Comparable pilaMinimo=cola.minimo();
            if (colaMin.sosMenor(pilaMinimo))
            {
                return colaMin;   
            }else{
                return pilaMinimo;
            }
        }
        public Comparable maximo(){
            Comparable colaMax=cola.maximo();
            Comparable pilaMax=cola.maximo();
            if (colaMax.sosMayor(pilaMax))
            {
                return colaMax;   
            }else{
                return pilaMax;
            }
        }
        public void agregar(Comparable _comparable){

        }
        public bool contiene(Comparable _comparable){
            if (pila.contiene(_comparable) || cola.contiene(_comparable))
            {
                return true;   
            }else
            {
                return false;
            }

        }
    }
}