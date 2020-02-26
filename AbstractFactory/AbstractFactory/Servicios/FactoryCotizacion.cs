using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Servicios
{
    public class FactoryCotizacion : IFactoryProducto
    { 
        private IProductoCotizacion proveedor;
        public FactoryCotizacion(IProductoCotizacion _proveedor)
        {
            this.proveedor = _proveedor;
        }        

        public void CreaDELL(int _iCantidad, string _cProducto)
        {
            this.proveedor.CreaNuevo(_iCantidad);
            this.proveedor.Mostrarmensaje();
        }        

        public void CreaHP(int _iCantidad, string _cProducto)
        {
            this.proveedor.CreaNuevo(_iCantidad);
            this.proveedor.Mostrarmensaje();
        }
    }
}
