using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Cola:Coleccionable,Iterable
    {
        private List<Comparable> cola;

        public Cola (){
            this.cola=new List<Comparable>();
        }
        public List<Comparable> getCola{
            get{return this.cola;}
        }
        public void agregar(Comparable c){
            cola.Add(c);
        }

        public Comparable pop(){
            Comparable aux;
            aux=(Comparable)cola[0];
            cola.Remove(aux);
            return aux;
        }
        public bool vacia(){
            return cola.Count==0;
        }
        public Comparable tope(){
            int tam=cola.Count;
            return (Comparable)cola[0];
        }

        public int cuantos(){
            return cola.Count;   
        }
        public Comparable minimo(){
            Comparable min=cola[0];
            foreach (Comparable item in cola)
            {
                if (item.sosMenor(min))
                {
                    min=item;
                }
            }
            return min;
        }

        public Comparable maximo(){
            Comparable max=cola[0];
            foreach (Comparable item in cola)
            {
                if (item.sosMayor(max))
                {
                    max=item;
                }
            }
            return max;
        }

        public bool contiene(Comparable c){
            bool resp=false;
            foreach (Comparable item in cola)
            {
                if (item.sosIgual(c))
                {
                    resp= true;   
                }
            }
            return resp;
        }
        public Iterador crearIterador(){
            return new IteradorCola(this);
        }

    }
}