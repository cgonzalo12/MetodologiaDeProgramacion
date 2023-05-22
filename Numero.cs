using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Numero:Comparable
    {

        //atributos
        public int valor;



        public Numero(int _valor){
            this.valor=_valor;
        }
        //metodos
       
        public int getValor(){
            return this.valor;
        }
        public override string ToString()
        {
            return "valor: "+this.valor;
        }
        public bool sosIgual(Comparable c){
            Numero n = (Numero) c;
            if (this.getValor()==n.getValor())
            {
                return true;   
            }else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable c){
            Numero n = (Numero) c;
            if (this.getValor()>=n.getValor())
            {
                return true;   
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable c){
            Numero n = (Numero) c;
            if (this.getValor()<=n.getValor())
            {
                return true;   
            }else
            {
                return false;
            }
        }
        
    }
}