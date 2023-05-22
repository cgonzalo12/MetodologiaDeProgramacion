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

        //constructor
        public Persona(string _nombre,int _dni){
            this.nombre=_nombre;
            this.dni=_dni;
        }
        //encampusamiento
        public string getNombre{
            get{return nombre;}
        }
        public int getDNI{
            get{return dni;}
        }

        //metodos
        public override string ToString()
        {
            return "Nombre: "+this.getNombre+" \n DNI: "+this.getDNI;
        }
        public virtual bool sosIgual(Comparable comparable){
            Persona _persona=(Persona)comparable;
            if (this.dni==_persona.dni)
            {
                return true;   
            }else{
                return false;
            }
        }
        public virtual bool sosMayor(Comparable comparable){
            Persona _persona=(Persona)comparable;
            if (_persona.dni<this.dni)
            {
                return true;
            }else
            {
                return false;
            }
        }
        public virtual bool sosMenor(Comparable comparable){
            Persona _persona=(Persona)comparable;
            if (_persona.dni>this.dni)
            {   
                return true;
            }else
            {
                return false;
            }
        }
        
        

    }
}