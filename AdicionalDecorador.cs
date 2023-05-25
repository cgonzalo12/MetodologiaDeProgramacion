using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    abstract class AdicionalDecorador:IAlumno
    {
        public IAlumno adicional;

        public AdicionalDecorador(IAlumno _adicional){
            this.adicional=_adicional;
        }
        virtual public int getCalificacion(){
            return this.adicional.getCalificacion();
        }

        virtual public void setCalificacion(int num){
            this.adicional.setCalificacion(num);
        }
        virtual public int responderPregunta(int num){
            return this.adicional.responderPregunta(num);
        }
        virtual public string getNombre(){
            return this.adicional.getNombre();
        }
        virtual public int getDNI(){
            return this.adicional.getDNI();
        }
        virtual public int getLegajo(){
            return this.adicional.getLegajo();
        }
        virtual public int getPromedio(){
            return this.adicional.getPromedio();
        }
        virtual public string mostrarCalificacion(){
            return this.adicional.mostrarCalificacion();
        }
        virtual public bool sosIgual(Comparable _alum){
            IAlumno alum=(IAlumno)_alum;
            return this.adicional.sosIgual(alum);
        }
        virtual public bool sosMenor(Comparable _alum){
            IAlumno alum=(IAlumno)_alum;
            return this.adicional.sosMenor(alum);
        }
        virtual public bool sosMayor(Comparable _alum){
            IAlumno alum=(IAlumno)_alum;
            return this.adicional.sosMayor(alum);
        }
        virtual public EstrategiaAlumno GetEstrategiaAlumno(){
            return this.adicional.GetEstrategiaAlumno();
        }
    }
}