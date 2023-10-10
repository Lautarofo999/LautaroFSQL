using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Clientes
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set;}
        public int dni { get; set; }
        

        public string MostrarCliente
        {
            get { return "id: " + id + "nombre: " + nombre + "aprellido: " + apellido + "dni: " + dni; }
        }
    }
    
    
}
