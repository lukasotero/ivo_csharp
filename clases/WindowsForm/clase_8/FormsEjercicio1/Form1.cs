using System.Text.RegularExpressions;

namespace FormsEjercicio1
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
        }

        // Boton de Submit
        private void Button1_Click(object sender, EventArgs e)
        {
            // Validar que el campo de email sea un email v�lido
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("El campo de email no es v�lido.");
                return;
            }

            // Validar si las contrase�as coinciden
            if (!IsValidPassword(tbPassword.Text, tbPasswordConfirm.Text))
            {
                MessageBox.Show("El campo de email no es v�lido.");
                return;
            }

            MessageBox.Show("Est� todo OK");
        }

        // Funci�n para validar un email
        private bool IsValidEmail(string email)
        {
            // Validar que el campo de email no est� vac�o
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo de email no puede estar vac�o.");
                return false;
            }

            // Validar que el campo de email tenga un arroba "@"
            if (!email.Contains("@"))
            {
                MessageBox.Show("El campo de email no es v�lido.");
                return false;
            }

            /* Validar que el campo de email sea un email v�lido

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(tbEmail.Text, patron))
            {
                MessageBox.Show("El campo de email no es v�lido.");
                return false;
            } */

            return true;
        }

        // Funci�n para validar contrase�a
        private static bool IsValidPassword(string password, string passwordConfirm)
        {
            // Validar que la contrase�a coincida con la cotrase�a de confirmacion
            if (password != passwordConfirm)
            {
                MessageBox.Show("Las contrase�as no coinciden.");
                return false;
            }

            return true;
        }
    }
}
