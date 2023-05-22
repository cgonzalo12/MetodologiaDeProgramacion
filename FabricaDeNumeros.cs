using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class FabricaDeNumeros:FabricaComparables
    {
        public override Numero crearComparable(){
            Numero _numero;
            Console.WriteLine("ingrese valor por teclado: ");
            int valor=int.Parse(Console.ReadLine());
            return _numero=new Numero(valor);
        }

        public override Numero crearAleatorio()
        {
            GeneradorDeDatosAleatorios gen=new GeneradorDeDatosAleatorios();
            Numero num;
            return num=new Numero(gen.numeroAleatorio(999999999));
        }
        public override Numero crearPorTeclado()
        {
            LectorDeDatos lec=new LectorDeDatos();
            Numero num;
            Console.WriteLine("Ingrese valor del Numero:");
            int valor=lec.numeroPorTeclado();
            return num=new Numero(valor);
       }
        
    }
}