using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface IAlumno : Comparable
    {
       int responderPregunta(int pregunta);
       string mostrarCalificacion();
       int getCalificacion();
       void setCalificacion(int califica);
       string getNombre();
       int getDNI();
       int getLegajo();
       int getPromedio();
       EstrategiaAlumno GetEstrategiaAlumno();
    }
}