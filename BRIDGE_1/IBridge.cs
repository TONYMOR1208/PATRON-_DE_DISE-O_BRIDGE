using System;
using System.Collections.Generic;
using System.Text;

namespace BRIDGE_1
{
    //Esta es la interface que las implementaciones deben mostrar
    interface  IBridge
    {
        void MostrarTotales(Dictionary<string, double>pProductos);
        void ListarProductos(Dictionary<string, double> pProductos);

    }
}
