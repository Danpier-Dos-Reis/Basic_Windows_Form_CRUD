using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_front
{
    /*En esta clase vamos a definir la mismas comlunas
    que tenemos en la DB. Esta clase es el modelo, la representación
    de los Contactos*/
    public class Contacto
    {

        /*Estas son las propiedades*/
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}
