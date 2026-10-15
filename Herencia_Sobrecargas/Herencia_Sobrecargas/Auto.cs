using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Herencia_Sobrecargas
{
    class Auto: Vehiculo
    {
        private int cantidadPuertas;
        private bool esAutomatico;

        public Auto(string marca, string modelo, int anio, int cantidadPuertas, bool esAutomatico)
            :base(marca, modelo, anio)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.esAutomatico = esAutomatico;
        }
        public Auto(string marca, string modelo, int cantidadPuertas)
    : base(marca, modelo)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.esAutomatico = true;
        }

        public new string MostrarInformacion()
        {            
            string datosVehiculo = base.MostrarInformacion();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(datosVehiculo);
            sb.AppendLine($"Cantidad Puertas: {this.cantidadPuertas}");
            sb.AppendLine($"Es automatico: {this.esAutomatico}");

            return sb.ToString();
        }
    }



}
