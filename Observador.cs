using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface Observador
    {
       void actualizar(Observado _observado);
    }
}