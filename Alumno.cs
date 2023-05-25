using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Alumno:Persona,IAlumno
    {
        private int legajo;
        private int promedio;
        private int calificacion;
        private EstrategiaAlumno estrategiaAlum;

        private AdicionalDecorador decorador;
        //constructor

        public Alumno(string _nombre,int _dni,int _legajo,int _promedio,int _calificacion):base(_nombre,_dni){
            this.legajo=_legajo;
            this.promedio=_promedio;
            this.calificacion=_calificacion;
            estrategiaAlum = new compararAlumLegajo();
        }

        //get
        public int setCalifica{
            set{calificacion=value;}
        }
        public int getCalifica{
            get{return calificacion;}
        }
        public void SetEstrategiaAlum(EstrategiaAlumno est){
            this.estrategiaAlum=est;
        }
        public EstrategiaAlumno GetEstrategiaAlumno(){
            return this.estrategiaAlum;
        }
            
        
        public int getLegajo(){
            return this.legajo;
        }
        public int getPromedio(){
            return this.promedio;
        }

        //metodos
        
        public void setCalificacion(int califica){
            this.calificacion=califica;
        }
        public string getNombre(){
            return this.nombre;
        }
        public int getCalificacion(){
            return this.calificacion;
        }
        public override string ToString()
        {
            return "\n Nombre: "+this.getNombre()+" \n DNI: "+this.getDNI()+"\n Legajo: "+this.getLegajo()+"\n Promedio: "+this.getPromedio()+"\n calificacion: "+this.mostrarCalificacion();
        }
        public void cambiarEstrategia(EstrategiaAlumno _estrategia){
            this.estrategiaAlum=_estrategia;
        }
        
        public override bool sosIgual(Comparable comparable){
            IAlumno alumno=(IAlumno)comparable;
            if (estrategiaAlum.datoComparacion(this)==estrategiaAlum.datoComparacion(alumno))
            {
                return true;   
            }else
            {
                return false;
            }
        }
        public override bool sosMayor(Comparable comparable){
            IAlumno alumno=(IAlumno)comparable; 
            if (estrategiaAlum.datoComparacion(this)>estrategiaAlum.datoComparacion(alumno))
            {
                return true;   
            }else
            {
                return false;
            }
        }
        public override bool sosMenor(Comparable comparable){
            IAlumno alumno=(IAlumno)comparable; 
            if (estrategiaAlum.datoComparacion(this)<estrategiaAlum.datoComparacion(alumno))
            {
                return true;   
            }else
            {
                return false;
            }
        }

        //Ejercicio numero1 practica 4
        public virtual int responderPregunta(int pregrunta){
            Random random =new Random();
            return random.Next(1,4);
        }
        public string mostrarCalificacion(){
            string respuesta=this.nombre+"    "+this.getCalificacion();
            return respuesta;
        }
        
    }
}