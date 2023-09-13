using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Tarjeta
    {
        private int cedula_cliente;
        private int clave;
        private int num_tarjeta;
        private int saldo;
        private bool tipo_tarjeta;
        private Cliente cliente;

        public int Getcedula_cliente()
        {
            int cedula_cliente=this.cedula_cliente;
            return cedula_cliente;
        }
        public int Getclave()
        {
            int clave = this.clave;
            return clave;
        }
        public int Getnum_tarjeta()
        {
            int num_tarjeta = this.num_tarjeta;
            return num_tarjeta;
        }
        public int Getsaldo()
        {
            int saldo = this.saldo;
            return saldo;
        }
        public bool Gettipo_tarjeta()
        {
            bool tipo_tarjeta = this.tipo_tarjeta;
            return tipo_tarjeta;
        }
        public Tarjeta(int clave, int num_tarjeta, bool tipo_tarjeta)
        {
            this.clave = clave;
            this.num_tarjeta = num_tarjeta;
            this.tipo_tarjeta = tipo_tarjeta;
        }
        public void AsignarCliente(int cedula_cliente, int saldo, bool tipo_tarjeta, Cliente cliente)
        {
            this.cedula_cliente = cedula_cliente;
            this.saldo = saldo;
            this.tipo_tarjeta = tipo_tarjeta;
            this.cliente=cliente;
        }
    }
}