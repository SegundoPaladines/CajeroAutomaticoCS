using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Cliente
    {
        private int cedula;
        private string direccion;
        private string email;
        private string nombre;
        private int telefono;

        public int Getcedula()
        {
            int cedula= this.cedula;
            return cedula;
        }
        public string Getdireccion()
        {
            string direccion = this.direccion;
            return direccion;
        }
        public string Getemail()
        {
            string email = this.email;
            return email;
        }
        public string Getnombre()
        {
            string nombre = this.nombre;
            return nombre;
        }
        public int Gettelefono()
        {
            int telefono = this.telefono;
            return telefono;
        }
        public Cliente(int cedula, String direccion, String email, String nombre, int telefono)
            {
                this.cedula = cedula;
                this.direccion = direccion;
                this.email = email;
                this.nombre = nombre;
                this.telefono = telefono;
            }
    }
}
