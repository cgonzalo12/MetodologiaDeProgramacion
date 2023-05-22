using System.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Alumno:Persona
    {
        private int legajo;
        private int promedio;
        private int calificacion;
        private EstrategiaAlumno estrategiaAlum;
        //constructor

        public Alumno(string _nombre,int _dni,int _legajo,int _promedio,int _calificacion):base(_nombre,_dni){
            this.legajo=_legajo;
            this.promedio=_promedio;
            this.calificacion=_calificacion;
            estrategiaAlum = new compararAlumLegajo();
        }

        //get

        public int getCalificacion{
            get{return this.calificacion;}
        }
        public int setCalificacion{
            set{this.calificacion = value;}
        }
        public EstrategiaAlumno SetEstrategiaAlum{
            set{estrategiaAlum = value;}
        }
        public EstrategiaAlumno GetEstrategiaAlumno{
            get{return estrategiaAlum;}
        }
        public int getLegajo{
            get{return legajo;}
        }
        public int getPromedio{
            get{return promedio;}
        }

        //metodos
        public override string ToString()
        {
            return "\n Nombre: "+this.getNombre+" \n DNI: "+this.getDNI+"\n Legajo: "+this.getLegajo+"\n Promedio: "+this.getPromedio+"\n calificacion: "+this.calificacion;
        }
        public void cambiarEstrategia(EstrategiaAlumno _estrategia){
            this.estrategiaAlum=_estrategia;
        }
        
        public override bool sosIgual(Comparable comparable){
            Alumno _alumno=(Alumno)comparable;
            if (estrategiaAlum.datoComparacion(this)==estrategiaAlum.datoComparacion(_alumno))
            {
                return true;   
            }else
            {
                return false;
            }
        }
        public override bool sosMayor(Comparable comparable){
            Alumno _alumno=(Alumno)comparable;
            if (this.estrategiaAlum.comparacion(this,_alumno)==this)
            {
                return true;   
            }else
            {
                return false;
            }
        }
        public override bool sosMenor(Comparable comparable){
            Alumno _alumno=(Alumno)comparable;
            if (this.estrategiaAlum.comparacion(this,_alumno)==this)
            {
                return false;   
            }else
            {
                return true;
            }
        }

        //Ejercicio numero1 practica 4
        public virtual int responderPregunta(int pregrunta){
            Random random =new Random();
            return random.Next(1,4);
        }
        public string mostrarCalificacion(){
            string respuesta=this.nombre+"    "+this.getCalificacion;
            return respuesta;
        }
    }
}