using System.Runtime.Versioning;
using System.Globalization;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
namespace Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------------Ejercicio numero 6 Practica 3
            // Pila pila = new Pila();
            // llenar(pila,2);
            // Pila pila2=new Pila();
            // Vendedor vend=new Vendedor("gonzalo",36648215,200000,1);
            // vend.aumentaBonus();
            // vend.aumentaBonus();
            // pila.agregar(vend);
            // Gerente gerente=new Gerente(pila2,pila);
            // gerente.venta(900000,vend);
            // informar(pila,2);

            // //------------------Ejercicio numero 14 Practica 3
            // Pila pila_vendedores = new Pila();
            // Pila pila_mejores=new Pila();
            // llenar(pila_vendedores,2);
            // Gerente gerente = new Gerente(pila_vendedores,pila_mejores);
            // gerente.llenarVendedores(gerente.getVendedores);
            // jornadaDeVentas(gerente.getVendedores);
            // gerente.cerrar();
            int contador=0;
            while (contador!=20)
            {
                Alumno alum=new Alumno("gonzalo",36648215,6383,8,10);
                Console.WriteLine(alum.responderPregunta(3));
                Console.WriteLine(alum.mostrarCalificacion());
                contador++;
            }

        }
        //metodos

        //ejercicio 6 .   practica 3
        public static Coleccionable llenar(Coleccionable coleccion,int clase){
            int contador=0;
            while(contador!=20){
                Comparable _comp= FabricaComparables.crearAleatorio(clase);
                coleccion.agregar(_comp);
                contador++;
            }
            return coleccion;
        }
        //ejercicio numero 6 .    practica 3
        public static void informar(Coleccionable coleccion,int clase){
            Console.WriteLine("cantidad de elementos: "+coleccion.cuantos());
            Console.WriteLine("elemento minimo: "+coleccion.minimo().ToString());
            Console.WriteLine("elemento maximo: "+coleccion.maximo().ToString());
            Comparable comp=FabricaComparables.crearPorTeclado(clase);
            if (coleccion.contiene(comp))
            {
                Console.WriteLine("El elemento leído está en la colección");
            }else
            {
               Console.WriteLine("El elemento leído no está en la colección");
            }
           
        }

        public static Coleccionable jornadaDeVentas(Coleccionable coleccion){
            int cantidad=coleccion.cuantos();
            Pila pila=(Pila)coleccion;    
            Iterable iterable=(Iterable)coleccion;
            Iterador iterador=iterable.crearIterador();
            while (!iterador.fin())
            {
                Vendedor vend=(Vendedor)iterador.actual();
                int cont=0;
                while (cont!=20)
                {
                    Random random=new Random();
                    double monto=random.Next(1,7000);
                    vend.venta(monto);
                    vend.notificar();
                    cont++;
                }


                iterador.siguiente();
            }

            return coleccion;
        }


        public static void imprimirElementos(Coleccionable _coleccion){
            Iterable iterable=(Iterable)_coleccion;
            Iterador iterador=iterable.crearIterador();
            while (!iterador.fin())
            {
                Console.WriteLine("***************** separador *********************");
                Console.WriteLine(iterador.actual().ToString());
                iterador.siguiente();   

            }
        } 
       
        public static void cambiarEstrategia(Coleccionable _coleccionable,EstrategiaAlumno _estrategia){
            Iterable iterable=(Iterable)_coleccionable;
            Iterador iterador=iterable.crearIterador();
            while (!iterador.fin())
            {
                ((Alumno)iterador.actual()).cambiarEstrategia(_estrategia);
                iterador.siguiente();
            }
        }

        

        
    }
}