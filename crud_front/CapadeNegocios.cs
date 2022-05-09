using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crud_front
{
    public class CapadeNegocios
    {
        private CapadeAccesoaDatos _capadeAccesoaDatos;

        //Método constructor de esta clase
        public CapadeNegocios()
        {
            _capadeAccesoaDatos= new CapadeAccesoaDatos();
        }

        public Contacto guardarContacto(Contacto Contact)
        {
            if (Contact.Id == 0) {
                _capadeAccesoaDatos.InsertContact(Contact);
            }
            else{
                _capadeAccesoaDatos.ActualizarContact(Contact);
            }

            return Contact;
             
        }

        public List<Contacto> tenerContacts(){
        
            return _capadeAccesoaDatos.tenerContacts();
        
        }

        //Mandamos solo el Id porque realmento no nos hace
        //falta todo el objeto
        public void DeleteContact(int Id){
        
            _capadeAccesoaDatos.DeleteContact(Id);
        
        }

    }
}
