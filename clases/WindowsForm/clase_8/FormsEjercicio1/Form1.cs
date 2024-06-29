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
            // Validar que el campo de email sea un email válido
            if (!IsValidEmail(tbEmail.Text))
            {
                MessageBox.Show("El campo de email no es válido.");
                return;
            }

            // Validar si las contraseñas coinciden
            if (!IsValidPassword(tbPassword.Text, tbPasswordConfirm.Text))
            {
                MessageBox.Show("El campo de email no es válido.");
                return;
            }

            MessageBox.Show("Está todo OK");
        }

        // Función para validar un email
        private bool IsValidEmail(string email)
        {
            // Validar que el campo de email no esté vacío
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("El campo de email no puede estar vacío.");
                return false;
            }

            // Validar que el campo de email tenga un arroba "@"
            if (!email.Contains("@"))
            {
                MessageBox.Show("El campo de email no es válido.");
                return false;
            }

            /* Validar que el campo de email sea un email válido

            string patron = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(tbEmail.Text, patron))
            {
                MessageBox.Show("El campo de email no es válido.");
                return false;
            } */

            return true;
        }

        // Función para validar contraseña
        private static bool IsValidPassword(string password, string passwordConfirm)
        {
            // Validar que la contraseña coincida con la cotraseña de confirmacion
            if (password != passwordConfirm)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            return true;
        }
    }
}
