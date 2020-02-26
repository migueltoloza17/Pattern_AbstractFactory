using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Servicios
{
    public class RequsisicionDELL : IProductoRequisicion
    {
        public int iCantidad;
        public string cProducto;
        public void CreaNuevo(int _iCantidad, string _cProducto)
        {
            this.iCantidad = _iCantidad;
            this.cProducto = _cProducto;
        }
        public void Mostrarmensaje()
        {
            Console.WriteLine("Compra de {0} {1} con DELL", iCantidad, cProducto);
        }
    }
}
