using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crud_front
{
    public partial class addContact_Form : Form
    {

        private CapadeNegocios _capadeNegocios;
        private Contacto _Contacto;

        public addContact_Form()
        {
            InitializeComponent();

            //De esta forma podemos tener acceso a la capa
            //de negocios que es la encargada de grabar los datos y
            //el proceso que usará para grabar los datos.
            _capadeNegocios = new CapadeNegocios();
        }

        #region MÉTODOS

        private void saveContact(){

            Contacto Contact = new Contacto();

            //Estos son los nombres
            //de los textBox de
            //la segunda Ventana
            Contact.FirstName = txtFirstName.Text;
            Contact.LastName = txtLastName.Text;
            Contact.Phone = txtPhone.Text;
            Contact.Address = txtAddress.Text;

            /*Si _Contacto posee un valor, entonces _Contacto = _Contacto.Id
             Si _Contacto no posee un valor, entonces _Contacto = 0*/
            Contact.Id = _Contacto != null ? _Contacto.Id : 0;


            /*Le pasamos los valores de Contact a la función
             que guarda/inserta los contactos*/
            _capadeNegocios.guardarContacto(Contact);

        }

        public void loadContact(Contacto Contact)/*Contact va a contener los valores que
                                                  que tenía anteriormente en la grilla*/
        {
            /*Esto nos permite tener el ID, porque en el formulario no existe un
             textBox donde metamos el ID. Necesitamos el ID para poder Editar
             el contacto. Sino va a crear un nuevo contacto*/
            _Contacto = Contact;
            /*El id lo metememos en la ventana Main cuando
            ejecutamos la función loadContact() desde allá*/

            if (Contact != null){

                clearForm(); //Limpiamos primero las cajas.
            
                txtFirstName.Text = Contact.FirstName;
                txtLastName.Text = Contact.LastName;
                txtPhone.Text = Contact.Phone;
                txtAddress.Text = Contact.Address;
            
            }
        }

        private void clearForm(){

            /*Esto borra el contenido de las cajas de texto si es que anteriormente
             habiamos editado otro usuario*/

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtAddress.Text = string.Empty;

        }

        #endregion

        #region EVENTOS

        #region EVENTOS QUE NO SIRVEN

        private void labelSearch_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion

        //Evento del botón cancelr de la segunda ventana
        private void buttCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttAddContact_Click(object sender, EventArgs e)
        {
            saveContact();
            this.Close();

            /*Esto nos permite ejeciutar el desde el botón de esta ventana, una
             * acción que queremos que ocurra en la otra ventana. La otra ventana se
             llama Main_Form.
            
             Para poder usar el método populateContacts() este debe ser público en la
            ventana prinicpal.
            
             No entiendo bien la lógica del Owner. En ShowDialog() de la primera ventana, para mostrar
            la segunda ventana tuvimos que añadir un "this" para luego en este lado, en vez de usar "Parent"
            usaramos "Owner", y como arte de magia todo funciona*/
            ((Main_Form)this.Owner).populateContacts();
        }
        #endregion

    }
}
