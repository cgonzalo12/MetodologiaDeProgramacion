using System.Numerics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Diccionario:Coleccionable,Iterable
    {
       //atributos
       private Conjunto diccionario;
        //constructor
        public Diccionario(){
            diccionario=new Conjunto();
        }
        //metodos
        public void agregar(Comparable _comparable){
            Comparable _claveValor=(Comparable)_comparable;
            if (diccionario.contiene(_claveValor))
            {
                diccionario.eliminar(_claveValor);   
            }
            diccionario.agregar(_claveValor);
        }
        public Conjunto GetConjunto{
            get{return diccionario;}
        }

        public int? valorDe(Comparable _comparable){
            ClaveValor _claveValor=(ClaveValor)_comparable;
            if (diccionario.contiene(_claveValor))
            {
                 return _claveValor.getValor;   
            }
            return null;    
        }
        public bool contiene(Comparable _comparable){
            ClaveValor _claveValor=(ClaveValor)_comparable;
            return diccionario.contiene(_claveValor);
        }
        public int cuantos(){
            return diccionario.cuantos();
        }
        public Comparable minimo(){
            return diccionario.minimo();
        }
        public Comparable maximo(){
            return diccionario.maximo();
        }
        public Iterador crearIterador(){
            return new IteradorConjunto(diccionario);
        }
    }
}