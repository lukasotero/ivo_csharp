namespace FormsEjercicio1
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false; // Inicializamos el bot�n de submit deshabilitado (agregado en el Ejercicio 1.1)
            tbPasswordConfirm.Enabled = false; // Inicializamos el campo de confirmar contrase�a deshabilitado (agregado en el Ejercicio 1.1)
        }

        /*
         * Cosas que faltan:
         * Los campos se validar�n al quitar del foco del mismo. Se podr�n agregar otros eventos para mejorar la funcionalidad.
         * El bot�n Submit deber� abrir un formulario nuevo, cerrando el anterior.
         * Para marcar los errores no se mostrar� un MsgBox, sino que se deber� informar sobre el campo del formulario de alguna forma.
         */

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

            // Validar que el campo de nombre completo sea solo letras y espacios (agregado en el Ejercicio 1.1)
            if (!IsValidFullName(tbFullName.Text))
            {
                MessageBox.Show("El campo de nombre completo no es v�lido.");
                return;
            }

            // Validar que el campo de usuario sea todo min�scula (agregado en el Ejercicio 1.1)
            if (!IsValidUsername(tbUserName.Text))
            {
                MessageBox.Show("El campo de usuario no es v�lido.");
                return;
            }

            // El bot�n de submit deber� estar inhabilitado hasta que todos los campos sean correctos (agregado en el Ejercicio 1.1)
            if (IsValidEmail(tbEmail.Text) && IsValidPassword(tbPassword.Text, tbPasswordConfirm.Text) && IsValidFullName(tbFullName.Text) && IsValidUsername(tbUserName.Text))
            {
                btnSubmit.Enabled = true;
            }
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

            return true;
        }

        // Funci�n para validar contrase�a
        private static bool IsValidPassword(string password, string passwordConfirm)
        {
            // Validar que la contrase�a sea fuerte, � sea tenga m�yusculas y n�meros (agregado en el Ejercicio 1.1)
            if (!password.Any(char.IsUpper) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("La contrase�a debe tener al menos una may�scula y un n�mero.");
                return false;
            }

            // Validar que la contrase�a coincida con la cotrase�a de confirmacion
            if (password != passwordConfirm)
            {
                MessageBox.Show("Las contrase�as no coinciden.");
                return false;
            }

            return true;
        }

        // Funci�n para validar nombre completo (agregado en el Ejercicio 1.1)
        private static bool IsValidFullName(string fullName)
        {
            // Validar que el campo de nombre completo no est� vac�o
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("El campo de nombre completo no puede estar vac�o.");
                return false;
            }

            // Validar que el campo de nombre completo sea solo letras y espacios
            foreach (char c in fullName)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El campo de nombre completo no es v�lido.");
                    return false;
                }
            }

            return true;
        }

        // Funci�n para validar usuario (agregado en el Ejercicio 1.1)
        private static bool IsValidUsername(string username)
        {
            // Validar que el campo de usuario no est� vac�o
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("El campo de usuario no puede estar vac�o.");
                return false;
            }

            // Validar que el campo de usuario sea todo min�scula
            if (username != username.ToLower())
            {
                MessageBox.Show("El campo de usuario no es v�lido.");
                return false;
            }

            return true;
        }

    }
}
