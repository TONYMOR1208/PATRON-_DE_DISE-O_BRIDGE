using System;
using System.Collections.Generic;
using System.Text;

namespace BRIDGE_1
{
    class CImplementacion1:IBridge
    {
        public void MostrarTotales(Dictionary<string, double>pProductos)
        {
            double total = 0;
            int cantidad = 0;

            foreach(KeyValuePair<string, double> p in pProductos)
            {

                total+=p.Value;
                cantidad++; 
            }
            Console.WriteLine("El total de {0} productos ${1}", cantidad, total);
        } 
        public void ListarProductos (Dictionary<string, double> pProductos)
        {
            foreach (KeyValuePair<string, double> p in pProductos)
            {

                Console.WriteLine(p.Key);
            }
        }
    }
}
