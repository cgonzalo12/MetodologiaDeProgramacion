using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararAlumPromedio:EstrategiaAlumno
    {
        public Alumno comparacion(Alumno alum1,Alumno alum2){
            if (alum1.getPromedio>=alum2.getPromedio)
            {
                return alum1;
            }else
            {
                return alum2;
            }
        }
         public int datoComparacion(Alumno alumno){
            return alumno.getPromedio;
        }       
    }
}