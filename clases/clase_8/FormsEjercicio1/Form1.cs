namespace FormsEjercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Boton de Submit
        private void button1_Click(object sender, EventArgs e)
        {
            tbEmail.Text = tbEmail.Text.Trim();

            if (tbEmail.Text == "")
            {
                MessageBox.Show("El campo de email no puede estar vacio");
                return;
            }
        }
    }
}
