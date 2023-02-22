using System;

namespace Prestamo
{
    class Datos_prestamo
    {
        float monto_capital;
        float tasaInteresAnual;
        int numCuotas;
        public float Monto_capital
        {
            get { return monto_capital; }
            set { monto_capital = value; }
        }
        public float TasaInteresAnual
        {
            get { return tasaInteresAnual;}
            set { tasaInteresAnual = value;}
        }
        public int NumCuotas
        {
            get { return numCuotas; }
            set { numCuotas = value;}
        }

        //////////////
        /// no cambia una vez calculado
        
        public float ImporteCapital()
        {
            return  this.monto_capital / this.numCuotas;
           
        }
       
        public float MontoInteres(float prestamo) {
            
            return  prestamo *(this.tasaInteresAnual/100/360)*30 ;
            
        }



    }
}
