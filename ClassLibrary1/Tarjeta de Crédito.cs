using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Tarjeta_de_Crédito
    {
        public int id { get; set; }
        public int numeroTarjeta { get; set; }
        public double limiteCredito { get; set; }
        public double saldoDisponible { get; set; }
        public string estado { get ; set; }
        public double montoDeuda { get; set; }
    }
}
