using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class DecoradorAsteriscos:AdicionalDecorador
    {
       public DecoradorAsteriscos(IAlumno alum):base(alum){

       }

        public override string mostrarCalificacion()
        {
            return "*******************************************\n" + "*  " + base.mostrarCalificacion() + "   *\n" + "*******************************************\n";
        }
    }
}