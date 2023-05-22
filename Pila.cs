using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Pila:Coleccionable,Iterable
    {
        private List <Comparable> pila;

        public Pila(){
            this.pila=new List<Comparable>();
        }
        public List<Comparable> getLista{
            get{return pila;}
        }
        public void agregar(Comparable c ){
            pila.Add(c);
        }

        public Comparable desapilar(){
            Comparable aux;
            int tam=pila.Count;
            aux=pila[tam-1];
            pila.Remove(aux);
            return aux;
        }

        public bool vacia(){
            return pila.Count==0;
        }

        public Comparable tope(){
            int tam=pila.Count;
            return pila[tam-1];
        }

        public int cuantos(){
            return pila.Count;
        }

        public Comparable maximo(){
            Comparable max=pila[0];
            foreach (Comparable item in pila)
            {
                if (item.sosMayor(max))
                {
                    max=item;   
                }
            }
            return max;
        }

        public Comparable minimo(){
            Comparable min=pila[0];
            foreach (Comparable item in pila)
            {
                if (item.sosMenor(min))
                {
                    min=item;   
                }
            }
            return min;
        }
        public bool contiene(Comparable c){
            bool resp=false;
            foreach (Comparable item in pila)
            {
                if (item.sosIgual(c))
                {
                    resp=true;   
                }   
            }
            return resp;
        }
        public Iterador crearIterador(){
            return new IteradorPila(this);
        }
    }
}