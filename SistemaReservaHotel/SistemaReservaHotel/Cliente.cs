using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaReservaHotel
{
    public class Cliente
    {
        //atributos
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipoDoc;

        public string TipoDoc
        {
            get { return tipoDoc; }
            set { tipoDoc = value; }
        }
       
       
        private int telefono;

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        private string numDoc;

        public string NumDoc
        {
            get { return numDoc; }
            set { numDoc = value; }
        }

        
         //constructor sin parametros
        public Cliente()
         {
             this.nombre = "Cesar";
             this.tipoDoc = "DNI";
             this.numDoc = "2";
             this.telefono = 9999999;
         }

        //constructor con parametros
        public Cliente(string nombre, string tipoDoc, string Direccion, string email, string dni, int telefono)
        {
            this.nombre = nombre;
            this.tipoDoc = tipoDoc;
            this.numDoc = dni;
            this.telefono = telefono;

        }

    }
}
