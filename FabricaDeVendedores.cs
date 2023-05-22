using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    class FabricaDeVendedores:FabricaComparables
    {
        public override Vendedor crearComparable()
        {
            Vendedor _vendedor;
            Console.WriteLine("ingrese nombre: ");
            string _nombre=Console.ReadLine();
            Console.WriteLine("ingrese DNI: ");
            int _dni=int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese sueldo: ");
            double _sueldo=double.Parse(Console.ReadLine());
            
            return new Vendedor(_nombre,_dni,_sueldo,1);
        }
        public override Vendedor crearAleatorio()
        {
            GeneradorDeDatosAleatorios generador=new GeneradorDeDatosAleatorios();
            Vendedor _vendedor;
            return _vendedor= new Vendedor(generador.stringAleatorio(10),generador.numeroAleatorio(99999999),generador.numeroAleatorio(99999999),1);
        }
        public override Vendedor crearPorTeclado()
        {
            LectorDeDatos lector=new LectorDeDatos();
            Console.Write("ingrese Nombre: ");
            string nombre=lector.stringPorTeclado();
            Console.Write("ingrese Dni: ");
            int dni=lector.numeroPorTeclado();
            Console.Write("ingrese sueldo: ");
            int sueldo=lector.numeroPorTeclado();
            Console.WriteLine("ingrese bonus: ");
            int _bonus=int.Parse(Console.ReadLine());
            Vendedor _vendedor;
            return _vendedor= new Vendedor(nombre,dni,sueldo,_bonus);
        }
       

    }
}