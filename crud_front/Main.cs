namespace crud_front
{
    public partial class Main_Form : Form
    {
        // Pallete Colors
        // #06113C azul
        // #FF8C32 anaranjado
        // #DDDDDD gris con poca opacidad
        public Main_Form()
        {
            InitializeComponent();
        }

        #region EVENTOS

        #region EVENTOS SIN USAR

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttSearch_Click(object sender, EventArgs e)
        {

        }

        #endregion

        //Button Add
        private void button1_Click(object sender, EventArgs e)
        {
            mostrarAdd();
        }

        #endregion

        #region METODOS PRIVADOS

        private void mostrarAdd()
        {
            addContact_Form segundo = new addContact_Form();
            segundo.ShowDialog();//Muestra la ventada por sobre la otra como un pop up
        }

        #endregion

    }
}