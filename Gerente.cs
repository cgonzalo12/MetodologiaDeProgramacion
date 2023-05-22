using System.Security.Cryptography.X509Certificates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Gerente:Observador
    {
        //Atributos
        private Coleccionable vendedores;

        public Coleccionable mejoresVendedores;
       
        //constructor
        public Gerente(Coleccionable _vendedores,Coleccionable _mejoresVendedores){
            vendedores=_vendedores;
            mejoresVendedores=_mejoresVendedores;
        }
        //get
        public Coleccionable getVendedores{
            get{return vendedores;}
        }
        public Coleccionable getMejoresVendedores{
            get{return mejoresVendedores;}
        }

        //metodos
        public void cerrar(){
            int contador;
            contador=this.getMejoresVendedores.cuantos();
            Iterable _iterable=(Iterable)mejoresVendedores;
            Iterador _iterador=_iterable.crearIterador();
            while (! _iterador.fin())
            {
                Console.WriteLine("***************** separador *********************");
                Console.WriteLine(_iterador.actual().ToString());
                _iterador.siguiente(); 
                contador--; 
            }
        }

        public void venta(double monto,Vendedor _vendedor){
            if (monto>=5000)
            {
                if (!mejoresVendedores.contiene(_vendedor))
                {
                    mejoresVendedores.agregar(_vendedor);
                }  
                _vendedor.aumentaBonus();
            }
        }
        public void actualizar(Observado _observado){
            Vendedor _vendedor=(Vendedor)_observado;
            venta(_vendedor.getMonto,_vendedor);
        }
        public void llenarVendedores(Coleccionable _coleccion){
            Iterable iterable=(Iterable)_coleccion;
            Iterador iterador=iterable.crearIterador();
            while (!iterador.fin())
            {
                Vendedor vend= (Vendedor)iterador.actual();  
                vend.agregarObservador(this);
                iterador.siguiente();
            }
        }
    }
}