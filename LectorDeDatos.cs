using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class LectorDeDatos
    {
        //atributos
        private int numero;
        private string palabra;

        //constructor 
        public LectorDeDatos(){}

        //get
        public int getNumero{
            get{return numero;}
        }
        public string getPalabra{
            get{return palabra;}
        }
        //metodos
        public int numeroPorTeclado(){
            Console.WriteLine("Ingrese numero por telcado: ");
            numero = int.Parse(Console.ReadLine());
            return getNumero;
        }

        public string stringPorTeclado(){
            Console.WriteLine("Ingese string por teclado: ");
            palabra=Console.ReadLine();
            return getPalabra;
        }

    }
}