using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IProductoRequisicion
    {
        void CreaNuevo(int _iCantidad, string _cProducto);
        void Mostrarmensaje();
    }
}
