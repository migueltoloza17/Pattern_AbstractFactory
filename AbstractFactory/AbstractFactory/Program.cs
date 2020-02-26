using AbstractFactory.Interfaces;
using AbstractFactory.Servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int iCantidad = (int)decimal.Zero;
            string cProveedor = string.Empty, cProducto = string.Empty;
            IProductoCotizacion productoCotizacion;
            IProductoRequisicion productoRequisicion;
            IFactoryProducto factoryProducto;

            Console.WriteLine("Ingrese un proveedor");
            cProveedor = Console.ReadLine();
            Console.WriteLine("Ingrese un producto");
            cProducto = Console.ReadLine();
            Console.WriteLine("Ingrese un producto");
            iCantidad = Convert.ToInt32(Console.ReadLine());

            if (cProveedor == "HP")
            {
                productoCotizacion = new CotizacionHP();
                factoryProducto = new FactoryCotizacion(productoCotizacion);
                factoryProducto.CreaDELL(iCantidad, cProducto);

                productoRequisicion = new RequisicionHP();
                factoryProducto = new FactoryRequisicion(productoRequisicion);
                factoryProducto.CreaDELL(iCantidad, cProducto);
            }
            else {
                productoCotizacion = new CotizacionDELL();
                factoryProducto = new FactoryCotizacion(productoCotizacion);
                factoryProducto.CreaDELL(iCantidad, cProducto);

                productoRequisicion = new RequsisicionDELL();
                factoryProducto = new FactoryRequisicion(productoRequisicion);
                factoryProducto.CreaDELL(iCantidad, cProducto);
            }

            Console.ReadKey();
        }
    }
}
