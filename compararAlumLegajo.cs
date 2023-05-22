using System.Runtime.InteropServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararAlumLegajo:EstrategiaAlumno
    {

        public Alumno comparacion(Alumno alum1,Alumno alum2){
            if (alum1.getLegajo>=alum2.getLegajo)
            {
                return alum1;   
            }else
            {
                return alum2;
            }
        }
         public int datoComparacion(Alumno alumno){
            return alumno.getLegajo;
        }
    }
}