using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public interface Comparable
    {
        public bool sosIgual(Comparable c);

        public bool sosMenor(Comparable c);


        public bool sosMayor(Comparable c);
    }
}