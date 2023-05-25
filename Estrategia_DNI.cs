using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Estrategia_DNI:Comparable
    {
        public Persona persona;
        public Estrategia_DNI(Persona _persona){
            this.persona=_persona;
        }
        public bool sosIgual(Comparable dni)
        {
            if ((this.persona).getDNI() == ((Persona)dni).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMayor(Comparable dni)
        {
            if (this.persona.getDNI() < ((Persona)dni).getDNI())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool sosMenor(Comparable dni)
        {
            if (this.persona.getDNI() > (((Persona)dni).getDNI()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}