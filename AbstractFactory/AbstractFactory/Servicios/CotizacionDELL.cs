using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Servicios
{
    public class CotizacionDELL : IProductoCotizacion
    {
        private int _iCantidad;
        public int iPrecio = 6150;
        public decimal iva = 1.15M;
        public void Mostrarmensaje()
        {
            decimal importe = ObtenerImporte();
            Console.WriteLine("La compra tendria un importe de {0}", importe);
        }

        public decimal ObtenerImporte()
        {
            return ((Convert.ToDecimal(_iCantidad) * Convert.ToDecimal(iPrecio)) * iva);
        }

        public void CreaNuevo(int _iCantidad)
        {
            this._iCantidad = _iCantidad;
        }
    }
}
