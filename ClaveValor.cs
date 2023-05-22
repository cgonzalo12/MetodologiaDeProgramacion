using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class ClaveValor:Comparable
    {
        //atributos
        private Comparable clave;
        private int valor;

        public ClaveValor(Comparable _clave,int _valor){
            this.clave=_clave;
            this.valor=_valor;
        }
        public override string ToString()
        {
            return "valor: "+this.getValor;
        }
        public Comparable getClave{
            get{return clave;}
        }
        public int getValor{
            get{return valor;}
        }

        public bool sosIgual(Comparable _comparable){
            ClaveValor _claveValor=(ClaveValor)_comparable;
            if (this.clave.sosIgual(_claveValor.getClave)){
                return true;
            }else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable _comparable){
           ClaveValor _claveValor=(ClaveValor)_comparable;
            if (this.clave.sosMenor(_claveValor.getClave)){
                return true;
            }else
            {
                return false;
            }
        }
        public bool sosMayor(Comparable _comparable){
           ClaveValor _claveValor=(ClaveValor)_comparable;
            if (this.clave.sosMayor(_claveValor.getClave)){
                return true;
            }else
            {
                return false;
            }
        }

    }
}