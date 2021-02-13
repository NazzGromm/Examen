using System;
using System.Collections.Generic;
using System.Text;

namespace CotizApp
{
    class Vendedor
    {
        List<string> nombre;
        List<string> apellido;
        List<int> iDVendedor;
        List<int> vendedores;
        public Vendedor() 
        {
            string nombre, apellido;
            iDVendedor = new List<int>();
            vendedores = new List<int>();
        }
        public void CantidadVendedores(int vendedores) 
        {            
            vendedores = 3;            
        }
       /*public int IDVendedores(int iDVendedor)
        {
            iDVendedor = 0002, 0001, 0035;
             
             
        }*/
        public void ApellidoVendedor(string apellido) 
        {
            apellido = "Bertaina" +" Blotta"+ "Vilches";
        }
        public void NombreVendedor(string nombre)
        {
            nombre = "Joel" + "Antonella" + "Franco";
        }
        
    }
}
