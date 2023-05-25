using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class FabricaMejoresAlumnos:FabricaComparables
    {
        public override AlumnoMuyEstudioso crearComparable(){
        AlumnoMuyEstudioso _alumno;
        Console.WriteLine("ingrese nombre: ");
        string _nombre=Console.ReadLine();
        Console.WriteLine("ingrese DNI: ");
        int _dni=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese Legajo: ");
        int _legajo=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese Promedio: ");
        int _promedio=int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese ultima calificacion");
        int _calificacion=int.Parse(Console.ReadLine());
        return _alumno=new AlumnoMuyEstudioso(_nombre,_dni,_legajo,_promedio,_calificacion);
       }

       public override AlumnoMuyEstudioso crearAleatorio(){
        GeneradorDeDatosAleatorios generador=new GeneradorDeDatosAleatorios();
        AlumnoMuyEstudioso _alumno;
        return _alumno= new AlumnoMuyEstudioso(generador.stringAleatorio(10),generador.numeroAleatorio(99999999),generador.numeroAleatorio(9999),generador.numeroAleatorio(10),generador.numeroAleatorio(10));

       }
       public override AlumnoMuyEstudioso crearPorTeclado(){
        LectorDeDatos lec=new LectorDeDatos();
        Console.Write("ingrese Nombre: ");
        string nombre=lec.stringPorTeclado();
        Console.Write("ingrese Dni: ");
        int dni=lec.numeroPorTeclado();
        Console.Write("ingrese legajo: ");
        int legajo=lec.numeroPorTeclado();
        Console.Write("ingrese promedio: ");
        int promedio=lec.numeroPorTeclado();
        Console.WriteLine("ingrese ultima calificacion: ");
        int calificacion=lec.numeroPorTeclado();

        AlumnoMuyEstudioso _alumno;
        return _alumno= new AlumnoMuyEstudioso(nombre,dni,legajo,promedio,calificacion);
       } 
    }
}