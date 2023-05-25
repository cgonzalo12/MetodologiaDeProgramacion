using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Persona:Comparable
    {
        //atributos
        protected string nombre;
        private int dni;
        public Comparable compara;
        //constructor
        public Persona(string _nombre,int _dni){
            this.nombre=_nombre;
            this.dni=_dni;
            this.compara=new Estrategia_DNI(this);
        }
        //encampusamiento
        public string getNombre{
            get{return nombre;}
        }
        public int getDNI(){
            return this.dni;
        }

        //metodos
        public override string ToString()
        {
            return "Nombre: "+this.getNombre+" \n DNI: "+this.getDNI();
        }
        public virtual bool sosIgual(Comparable comparable){
            return this.compara.sosIgual(comparable);
           
        }
        public virtual bool sosMayor(Comparable comparable){
            return this.compara.sosMayor(comparable);
            
        }
        public virtual bool sosMenor(Comparable comparable){
            
            return this.compara.sosMenor(comparable);
        
        }
        
        

    }
}