using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class compararAlumPromedio:EstrategiaAlumno
    {

         public int datoComparacion(IAlumno alumno){
            return alumno.getPromedio();
        }       
    }
}