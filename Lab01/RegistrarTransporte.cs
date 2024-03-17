using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    public class RegistrarTransporte
    {
        public DateTime FecDoc { get; set; }
        public string NomCliente { get; set; }
        public string Descrip { get; set; }
        public double TnMetricas { get; set; }


        //Método de descuento
        public double CostoTransporte()
        {
            return TnMetricas * 150;
        }

        public double Seguro()
        {
            return CostoTransporte() * 0.02;
        }

        public double Monto()
        {
            return CostoTransporte() + Seguro();
        }

        public double IGV()
        {
            return Monto() * 0.18;
        }

        public double ImporteTotal()
        {
            return Monto() + IGV();
        }




    }
}
