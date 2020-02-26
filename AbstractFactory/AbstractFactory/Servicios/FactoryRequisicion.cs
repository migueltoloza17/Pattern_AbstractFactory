using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Servicios
{
    public class FactoryRequisicion : IFactoryProducto
    {

        private IProductoRequisicion proveedor;
        public FactoryRequisicion(IProductoRequisicion _proveedor)
        {
            this.proveedor = _proveedor;
        }
       
        public void CreaDELL(int _iCantidad, string _cProducto)
        {
            this.proveedor.CreaNuevo(_iCantidad, _cProducto);
            this.proveedor.Mostrarmensaje();
        }       

        public void CreaHP(int _iCantidad, string _cProducto)
        {
            this.proveedor.CreaNuevo(_iCantidad, _cProducto);
            this.proveedor.Mostrarmensaje();
        }

        
    }
}
