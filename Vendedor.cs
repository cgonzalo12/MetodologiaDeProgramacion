using System.Diagnostics;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clase1
{
    public class Vendedor:Persona,Observado
    {
        //atributos
        private double sueldoBasico;
        private double bonus;
        private double monto;
        private List<double> ventas=new List<double>();
        private EstrategiaVendedor estrategiaVendedor;

        private List<Observador> observadores=new List<Observador>();

        //get y set
        public List<double> getVentas{
            get{return ventas;}
        }
        public double getMonto{
            get{return monto;}
        }
        public double getSueldoBAsico{
            get{return sueldoBasico;}
        }
        public double setSueldoBasico{
            set{sueldoBasico=value;}
        }
        public double getBonus{
            get{return bonus;}
        }
        public double setBonus{
            set{bonus=value;}
        }
        //constructor
        public Vendedor(string _nombre,int _dni,double _sueldo,double _bonus):base(_nombre,_dni){
            this.sueldoBasico=_sueldo;
            this.bonus=_bonus;
            monto=0;
            estrategiaVendedor=new compararVendedorDNI();
        }
        //metodos
        public void venta(double monto){
            Console.WriteLine("Precio de venta: "+monto);
            this.monto=monto;
            ventas.Add(monto);

        }
        public void aumentaBonus(){
            this.setBonus=0.01+bonus;
        }
         public override string ToString()
        {
            return "\n Nombre: "+this.getNombre+" \n DNI: "+this.getDNI+"\n Sueldo: "+this.getSueldoBAsico+"\n Bonus: "+this.getBonus;
        }
        //metodos de comparable
        public override bool sosIgual(Comparable _comparable)
        {
            Vendedor _vendedor=(Vendedor)_comparable;
            if (this.estrategiaVendedor.datoComparacion(this)==this.estrategiaVendedor.datoComparacion(_vendedor))
            {   
               return true; 
            }else
            {
                return false;
            }
        }
        public override bool sosMayor(Comparable _comparable)
        {
           Vendedor _vendedor=(Vendedor)_comparable;
            if (this.estrategiaVendedor.datoComparacion(this)>=this.estrategiaVendedor.datoComparacion(_vendedor))
            {   
               return true;
            }else
            {
                return false;
            } 
        }
        public override bool sosMenor(Comparable _comparable)
        {
            Vendedor _vendedor=(Vendedor)_comparable;
            if (this.estrategiaVendedor.datoComparacion(this)<=this.estrategiaVendedor.datoComparacion(_vendedor))
            {   
               return true;
            }else
            {
                return false;
            }
        }

        //cambio de estrategia
        public void cambiarEstrategia(EstrategiaVendedor _estrategia){
            this.estrategiaVendedor=_estrategia;
        }

        //metodos de observado
        public void agregarObservador(Observador _observador){
            observadores.Add(_observador);
        }
        public void quitarObservador(Observador _observador){
            observadores.Remove(_observador);
        }
        public void notificar(){
            foreach (Observador item in observadores)
            {
                item.actualizar(this);   
            }
        }

    }
}