using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class DecodarorLegajo:AdicionalDecorador   
    {
        public DecodarorLegajo(IAlumno decorador):base(decorador){

        }

        public override string mostrarCalificacion()
        {
            return base.getNombre()+"("+((Alumno)this.adicional).getLegajo()+") "+"       "+base.getCalificacion();
        }

    }
}