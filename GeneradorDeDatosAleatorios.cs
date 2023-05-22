using System.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class GeneradorDeDatosAleatorios
    {
       private int numero;
       private string palabra;

       //get y set
       public int getNumero{
        get{return numero;}
       }
       public string getPalabra{
        get{return palabra;}
       }
       //constructor

       public GeneradorDeDatosAleatorios(){
       }

       //metodos
       public int numeroAleatorio(int limite){
        Random randomNum=new Random();
        numero =randomNum.Next(0,limite);
        return getNumero;
       }

       public string stringAleatorio(int longitud){
            string cadena="QWERTYUIOPASDFGHJKLÑZXCVBNMqwertyuiopasdfghjkllñzxcvbnm1234567890";
            Random randomCadena=new Random();
            int indice;
            char[] letras=new char[longitud];
            string stringAleatori;
            for (int x= 0;  x<longitud; x++)
            {
                indice=randomCadena.Next(0,64);
                letras[x]=cadena[indice];
            }

            palabra=new string(letras);
            stringAleatori=this.palabra;
            return this.getPalabra;
       }
    }
}