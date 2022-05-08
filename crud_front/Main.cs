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

        #endregion

        #region METODOS PRIVADOS

        private void mostrarAdd()
        {
            addContact_Form segundo = new addContact_Form();

            /*Como Owner ponemos el this, que hace referencia al objeto
             * de la segunda ventana para después poder retornar algo*/
            segundo.ShowDialog(this);//Muestra la ventada por sobre la otra como un pop up
        }

        public void populateContacts(){

            List<Contacto> Contact = _capadeNegocios.tenerContacts();

            gridContacts.DataSource = Contact;//Para que retorne a la grilla la lista de contactos

        }

        #endregion

    }
}