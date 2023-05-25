using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class DecoradorPromocion:AdicionalDecorador
    {
        public DecoradorPromocion(IAlumno alum):base(alum){
        }

        public static string nota(int calificacion){
            if (calificacion<4)
            {
                return "DESAPROBADO";   
            }
            if (calificacion >=4 && calificacion <=7)
            {
                return "APROBADO";   
            }
            if (calificacion >= 7)
            {
                return "PROMOCION" ;  
            }
            return "no";
        }

        public override string mostrarCalificacion()
        {
            return base.mostrarCalificacion()+" ("+nota(base.getCalificacion())+")";
        }
    }
}