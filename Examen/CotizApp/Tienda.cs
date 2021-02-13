using System;
using System.Collections.Generic;
using System.Text;

namespace CotizApp
{
    class Tienda
    {
        string nombre, direccion;
        List<Vendedor> vendedores;
        List<Prendas> stock; 
        public Tienda()
        {
            
            stock = new List<Prendas>();
            vendedores = new List<Vendedor>();
        }
        

        
    }
    

}
