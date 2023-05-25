using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class AlumnoAdapter:Student
    {   //atributos
        IAlumno alumno;

        //constructor
        public AlumnoAdapter(IAlumno alumno){
            this.alumno=alumno;
        }
        //metodos

        public string getName(){
            return alumno.getNombre();
        }
        public int yourAnswerIs(int question){
            return alumno.responderPregunta(question);
        }
        public void setScore(int score){
            alumno.setCalificacion(score);
        }
        public string showResult(){
            return alumno.mostrarCalificacion();
        }

        public bool equals(Student _student){
            AlumnoAdapter alumnoA=(AlumnoAdapter)_student;
            return this.alumno.sosIgual(alumnoA.getAlumno());
        }
        public bool lessThan(Student _student){
            AlumnoAdapter alumnoA=(AlumnoAdapter)_student;
            return this.alumno.sosMenor(alumnoA.getAlumno());
        }
        public bool greaterThan(Student _student){
            AlumnoAdapter alumnoA=(AlumnoAdapter)_student;
            return this.alumno.sosMayor(alumnoA.getAlumno());
        }

        public IAlumno getAlumno(){
            return this.alumno;
        }
    }
}