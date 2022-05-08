﻿using System;
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

            //No es necesario colocar el ID porque se
            //inserta solo al ser autoincrementable

            _capadeNegocios.guardarContacto(Contact);

        }

        private CapadeNegocios _capadeNegocios;

        #endregion

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

        #endregion

    }
}
