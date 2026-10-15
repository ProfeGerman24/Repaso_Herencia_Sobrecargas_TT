using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Herencia_Sobrecargas;

namespace Herencia_Sobrecargas
{
    class Vehiculo
    {
        protected string marca;
        protected string modelo;
        protected int anio;

//Un constructor que no reciba parámetros y asigne valores predeterminados.
        public Vehiculo()
        {

        }
        public Vehiculo(string marca, string modelo)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.anio = DateTime.Now.Year;
        }
        public Vehiculo(string marca, string modelo, int anio):this(marca, modelo) 
        {
            this.anio = anio;
        }

        public string MostrarInformacion()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Marca: {this.marca}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Año: {this.anio}");
            return sb.ToString();
        }

        public static void MostrarInformacion(Vehiculo vehiculoMostrar)
        {
            Console.WriteLine(vehiculoMostrar.MostrarInformacion());
        }

        public int CalcularAntiguedad()
        {
            return DateTime.Now.Year - this.anio;
        }

        public int CalcularAntiguedad(int anio)
        {
            return anio - this.anio;
        }



        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool esIgual = false;
            if(v1.marca == v2.marca && v1.anio == v2.anio && v1.modelo == v2.modelo) 
            {
                esIgual = true;
            }
            return esIgual;
        }
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
    
            return !(v1 == v2);
        }

        public static bool operator >(Vehiculo v1, Vehiculo v2)
        { 
            return v1.anio > v2.anio;
        }
        public static bool operator <(Vehiculo v1, Vehiculo v2)
        {
            return v1.anio < v2.anio;
        }
        //Operador ==: dos vehículos serán iguales si tienen la misma marca, el mismo modelo y
        //el mismo año.
        //Operador !=: dos vehículos serán distintos si no cumplen la condición anterior.
        //Operador >: permite determinar si un vehículo es más nuevo que otro, comparando sus 
        //años de fabricación.



    }
}
