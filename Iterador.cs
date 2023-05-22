using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface Iterador
    {
       void primero();
       void siguiente();
       bool fin();
       Comparable actual();
    }
}