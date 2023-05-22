using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface Observado
    {
       void agregarObservador(Observador _observador);
       void quitarObservador(Observador _observador);
       void notificar();
    }
}