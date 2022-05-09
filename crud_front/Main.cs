namespace crud_front
{
    public partial class Main_Form : Form
    {
        // Pallete Colors
        // #06113C azul
        // #FF8C32 anaranjado
        // #DDDDDD gris con poca opacidad

        private CapadeNegocios _capadeNegocios;

        public Main_Form()
        {
            InitializeComponent();
            _capadeNegocios = new CapadeNegocios();
        }

        #region EVENTOS

        #region EVENTOS SIN USAR

        private void buttSearch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //Button Add
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarAdd();
        }

        private void Main_Form_Load(object sender, EventArgs e) //El evento de cargar el formulario
        {
            populateContacts();
        }


        /*Este evento es cuando se hace click a un elemento dentros de la celda
         del Grid*/
        private void gridContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*aqu� capturamos si en lo que se hizo click fue en una celda que contenga el link. Si no lo es,
             va a retornar una valor que no es de tipo "DataGridViewLinkCell" por lo que "cell = null".
            
                                          Esta parte (DataGridViewLinkCell)
                                          Verifica que el valor
                                          que se devuelva sea de
                                          tipo LinkCell*/
            DataGridViewLinkCell cell = (DataGridViewLinkCell)gridContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

            //Cuando se haya echo click
            //en una columna llamada
            //Edit
            if (cell.Value.ToString() == "Edit") {

                addContact_Form addContact = new addContact_Form();

                addContact.loadContact(new Contacto
                {

                    Id = int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = gridContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = gridContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = gridContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Address = gridContacts.Rows[e.RowIndex].Cells[4].Value.ToString()

                });
                addContact.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete"){

                DeleteContact(int.Parse(gridContacts.Rows[e.RowIndex].Cells[0].Value.ToString()));
                populateContacts(); //Despu�s de borrar al contacto, actualizamos la Grilla.
            
            }
            
        }

        #endregion

        #region METODOS PRIVADOS

        private void mostrarAdd()
        {
            addContact_Form segundo = new addContact_Form();

            /*Como Owner ponemos el this, que hace referencia al objeto
             * de la segunda ventana para despu�s poder retornar algo*/
            segundo.ShowDialog(this);//Muestra la ventada por sobre la otra como un pop up
        }

        public void populateContacts(){

            List<Contacto> Contact = _capadeNegocios.tenerContacts();

            gridContacts.DataSource = Contact;//Para que retorne a la grilla la lista de contactos

        }

        private void DeleteContact(int Id){

            _capadeNegocios.DeleteContact(Id);

        }

        #endregion

    }
}