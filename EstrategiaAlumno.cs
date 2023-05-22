using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface EstrategiaAlumno
    {
        Alumno comparacion(Alumno alum1,Alumno alum2);

        int datoComparacion(Alumno alum);

    }
}