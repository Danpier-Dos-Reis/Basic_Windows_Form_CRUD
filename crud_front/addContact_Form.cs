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
        public addContact_Form()
        {
            InitializeComponent();

            //De esta forma podemos tener acceso a la capa
            //de negocios que es la encargada de grabar los datos y
            //el proceso que usará para grabar los datos.
            _capadeNegocios = new CapadeNegocios();
        }

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

        #region BOTÓN ADD

        private void buttAddContact_Click(object sender, EventArgs e)
        {

            Contacto Contact = new Contacto();

                                //Estos son los nombres
                                //de los textBox de
                                //la segunda Ventana
            Contact.FirstName = txtFirstName.Text;
            Contact.LastName = txtLastName.Text;
            Contact.Phone = txtPhone.Text;
            Contact.Address = txtAddress.Text;

            //No es necesario colocar el ID porque se
            //inserta solo al ser autoincrementable

            _capadeNegocios.guardarContacto(Contact);

        }
        #endregion

        #endregion

    }
}
