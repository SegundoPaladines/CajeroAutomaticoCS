using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCajero
{
    public class Transaccion
    {
        private int clave;
        private int num_tarjeta;
        private int valor_operacion;

        public Transaccion(int clave, int num_tarjeta, int valor_operacion)
        {
            this.clave = clave;
            this.num_tarjeta = num_tarjeta;
            this.valor_operacion = valor_operacion;
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
        public int Getvalor_operacion()
        {
            int valor_operacion = this.valor_operacion;
            return valor_operacion;
        }

        public void Setclave(int clave)
        {
            this.clave = clave;
        }
        public void Setnum_tarjeta(int num_tarjeta)
        {
            this.num_tarjeta =num_tarjeta;
        }
        public void Setvalor_operacion(int valor_operacion)
        {
            this.valor_operacion=valor_operacion;
        }
    }
}