using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class AlumnoMuyEstudioso:Alumno
    {
        public AlumnoMuyEstudioso(string nombre,int dni,int legajo,int promedio,int calificacion):base(nombre,dni,legajo,promedio,calificacion){

        }
        public override int responderPregunta(int pregrunta){
            int resp=pregrunta%3;
            return resp;
        }

    }
}