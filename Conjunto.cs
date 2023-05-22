using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Conjunto:Coleccionable,Iterable
    {
        //atributos
        private List<Comparable> elementos;

        //cnostructor
        public Conjunto(){
            elementos=new List<Comparable>();

        }
        //metodos
        public List<Comparable> getElementos{
            get{return this.elementos;}
        }
        public int cuantos(){
            return elementos.Count;
        }

        public Comparable minimo(){
            if (this.cuantos()==0)
            {
                return null;   
            }
            Comparable min=elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMenor(min))
                {
                    min=elem;
                } 
            }
            return min;
        }
        public Comparable maximo(){
           if (this.cuantos()==0)
            {
                return null;   
            }
            Comparable max=elementos[0];
            foreach (Comparable elem in elementos)
            {
                if (elem.sosMayor(max))
                {
                    max=elem;
                } 
            }
            return max;
        }

        public bool contiene(Comparable _comparable){
            foreach (Comparable elem in elementos)
            {
                if (elem.sosIgual(_comparable))
                {
                    return true;   
                }
            }
            return false;
        }


        public void agregar(Comparable _comparable){
            Comparable _caveValor=(Comparable)_comparable;
            if (!contiene(_comparable))
            {
                elementos.Add(_caveValor);
            }
        }
        public void eliminar(Comparable _comparable){
            Comparable _claveValor=(Comparable)_comparable;
            if (contiene(_claveValor))
            {
                elementos.Remove(_claveValor);
            }
        }
        public Iterador crearIterador(){
            return new IteradorConjunto(this);
        }
        
        
    }
}