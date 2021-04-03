using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaHotel
{
    class ReservaHabitacion
    {
        private int codigoHabitacion;

        public int CodigoHabitacion
        {
            get { return codigoHabitacion; }
            set { codigoHabitacion = value; }
        }
        private int tiempoReserva;

        public int TiempoReserva
        {
            get { return tiempoReserva; }
            set { tiempoReserva = value; }
        }
        private string categoria;

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }


        public ReservaHabitacion()
        {
            this.codigoHabitacion = 0;
            this.tiempoReserva = 0;
           
        }


        public double pagoAlHotelxdia()
        {
            double cantidad = 0.0;
            switch (this.Categoria)
            {
                case "comun": cantidad = 100; break;
                case "premium": cantidad = 200; break;
                case "superPremium": cantidad = 300; break;
                default: cantidad = 500; break;
            }
            return cantidad;
        }

        public double pagototal()
        {
            return pagoAlHotelxdia() * TiempoReserva;
        }


    }
}
