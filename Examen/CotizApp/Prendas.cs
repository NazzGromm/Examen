using System;
using System.Collections.Generic;
using System.Text;

namespace CotizApp
{
    class Prendas
    {


        List<int> pantalon;
        List<int> camisa;

        float precio;
        public Prendas()
        {
            camisa = new List<int>();
            pantalon = new List<int>();
        }
       
        public void TipoCamisa(int camisa)
        {
            int mL, mC, CuMao, CuNor;
            camisa = 1000;
            mL = camisa - 500;
            mC = camisa - 500;
            CuMao = mL - 300 + mC - 350;
            CuNor = mL - 200 + mC - 150;                         
            
        }
        public void TipoPantalon(int pantalon) 
        {
            int comun, chupin;
            pantalon = 2000;
            comun = pantalon - 500;
            chupin = pantalon - 1500;
        }

    }
}
