using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararAlumDni:EstrategiaAlumno

    {
        public  Alumno comparacion(Alumno alum1,Alumno alum2){
            if (alum1.getDNI>=alum2.getDNI)
            {
                return alum1;
            }else
            {
                return alum2;
            }
        }   

        public int datoComparacion(Alumno alumno){
            return alumno.getDNI;
        }

    }
}