using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    abstract class FabricaComparables:FabricaDeComparables
    {
        public const int NUM = 0;
        public const int ALUM = 1;
        public const int VEND=2;
        public static int porDefecto=NUM;

        public static Comparable crearComparableSeteado(){
            return crearComparable(porDefecto);
        }

        public static Comparable crearComparable(int clase){
            FabricaComparables fabrica=null;
            if (clase==NUM)
            {
                fabrica=new FabricaDeNumeros();
            }
            if (clase==ALUM)
            {
                fabrica=new FabricaDeAlumnos();
            }
            if (clase==VEND)
            {
                fabrica=new FabricaDeVendedores();   
            }
            return fabrica.crearComparable();
        }



        public static Comparable crearAleatorio(int clase){
           FabricaComparables fabrica=null;
            if (clase==NUM)
            {
                fabrica=new FabricaDeNumeros();
            }
            if (clase==ALUM)
            {
                fabrica=new FabricaDeAlumnos();
            }
            if (clase==VEND)
            {
                fabrica=new FabricaDeVendedores();   
            }
            return fabrica.crearAleatorio(); 
        }

        public static Comparable crearPorTeclado(int clase){
            FabricaComparables fabrica=null;
           if (clase==NUM)
            {
                fabrica=new FabricaDeNumeros();
            }
            if (clase==ALUM)
            {
                fabrica=new FabricaDeAlumnos();
            }
            if (clase==VEND)
            {
                fabrica=new FabricaDeVendedores();   
            }
            return fabrica.crearPorTeclado(); 
        }

  
        public abstract Comparable crearComparable();
        public abstract Comparable crearAleatorio();
        public abstract Comparable crearPorTeclado();   
    }
}