using AbstractFactory.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Interfaces
{
    public interface IFactoryProducto
    {
        void CreaDELL(int _iCantidad, string _cProducto);
        void CreaHP(int _iCantidad, string _cProducto);

    }
}
