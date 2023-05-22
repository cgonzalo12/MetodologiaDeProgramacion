using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararAlumNombre:EstrategiaAlumno
    {
        public Alumno comparacion(Alumno alum1,Alumno alum2){
            if (alum1.getNombre.Count()>=alum2.getNombre.Count())
            {
                return alum1;
            }else
            {
                return alum2;
            }
        
        }
         public int datoComparacion(Alumno alumno){
            return alumno.getNombre.Count();
        }
    }
}