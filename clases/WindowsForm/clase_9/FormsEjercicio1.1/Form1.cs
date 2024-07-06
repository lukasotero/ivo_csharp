namespace FormsEjercicio1
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
            btnSubmit.Enabled = false; // Inicializamos el botón de submit deshabilitado (agregado en el Ejercicio 1.1)
            tbPasswordConfirm.Enabled = false; // Inicializamos el campo de confirmar contraseña deshabilitado (agregado en el Ejercicio 1.1)
        }

        /*
         * Cosas que faltan:
         * Los campos se validarán al quitar del foco del mismo. Se podrán agregar otros eventos para mejorar la funcionalidad.
         * El botón Submit deberá abrir un formulario nuevo, cerrando el anterior.
         * Para marcar los errores no se mostrará un MsgBox, sino que se deberá informar sobre el campo del formulario de alguna forma.
         */

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

            // Validar que el campo de nombre completo sea solo letras y espacios (agregado en el Ejercicio 1.1)
            if (!IsValidFullName(tbFullName.Text))
            {
                MessageBox.Show("El campo de nombre completo no es válido.");
                return;
            }

            // Validar que el campo de usuario sea todo minúscula (agregado en el Ejercicio 1.1)
            if (!IsValidUsername(tbUserName.Text))
            {
                MessageBox.Show("El campo de usuario no es válido.");
                return;
            }

            // El botón de submit deberá estar inhabilitado hasta que todos los campos sean correctos (agregado en el Ejercicio 1.1)
            if (IsValidEmail(tbEmail.Text) && IsValidPassword(tbPassword.Text, tbPasswordConfirm.Text) && IsValidFullName(tbFullName.Text) && IsValidUsername(tbUserName.Text))
            {
                btnSubmit.Enabled = true;
            }
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

            return true;
        }

        // Función para validar contraseña
        private static bool IsValidPassword(string password, string passwordConfirm)
        {
            // Validar que la contraseña sea fuerte, ó sea tenga máyusculas y números (agregado en el Ejercicio 1.1)
            if (!password.Any(char.IsUpper) || !password.Any(char.IsDigit))
            {
                MessageBox.Show("La contraseña debe tener al menos una mayúscula y un número.");
                return false;
            }

            // Validar que la contraseña coincida con la cotraseña de confirmacion
            if (password != passwordConfirm)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return false;
            }

            return true;
        }

        // Función para validar nombre completo (agregado en el Ejercicio 1.1)
        private static bool IsValidFullName(string fullName)
        {
            // Validar que el campo de nombre completo no esté vacío
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("El campo de nombre completo no puede estar vacío.");
                return false;
            }

            // Validar que el campo de nombre completo sea solo letras y espacios
            foreach (char c in fullName)
            {
                if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                {
                    MessageBox.Show("El campo de nombre completo no es válido.");
                    return false;
                }
            }

            return true;
        }

        // Función para validar usuario (agregado en el Ejercicio 1.1)
        private static bool IsValidUsername(string username)
        {
            // Validar que el campo de usuario no esté vacío
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("El campo de usuario no puede estar vacío.");
                return false;
            }

            // Validar que el campo de usuario sea todo minúscula
            if (username != username.ToLower())
            {
                MessageBox.Show("El campo de usuario no es válido.");
                return false;
            }

            return true;
        }

    }
}
