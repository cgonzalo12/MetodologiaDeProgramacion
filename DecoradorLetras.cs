using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class DecoradorLetras:AdicionalDecorador
    {
        public DecoradorLetras(IAlumno alumno):base(alumno){

        }
        public override string mostrarCalificacion()
        {
            int calificacion=base.getCalificacion();
            string num="uno";
            switch (calificacion)
            {
                case 1:
                    num="(UNO)";
                    break;
                case 2:
                    num="(DOS)";
                    break;
                case 3:
                    num="(TRES)";
                    break;
                case 4:
                    num="(CUATRO)";
                    break;
                case 5:
                    num="(CINCO)";
                    break;
                case 6:
                    num="(SEIS)";
                    break;
                case 7:
                    num="(SIETE)";
                    break;
                case 8:
                    num="(OCHO)";
                    break;
                case 9:
                    num="(NUEVE)";
                    break;
                case 10:
                    num="(DIEZ)";
                    break;
            }
            return base.mostrarCalificacion()+" "+num;
        }
    }
}