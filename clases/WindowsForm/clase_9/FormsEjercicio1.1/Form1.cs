using FormsEjercicio1._1;

namespace FormsEjercicio1
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
            btnSubmit.Visible = false; // Inicializamos el botón de submit deshabilitado (agregado en el Ejercicio 1.1)
            labelConfirmPassword.Visible = false; // Inicializamos el label de confirmar contraseña deshabilitado (agregado en el Ejercicio 1.1)
            tbPasswordConfirm.Visible = false; // Inicializamos el campo de confirmar contraseña deshabilitado (agregado en el Ejercicio 1.1)

            // Inicializamos todos los errores en false (agregado en el Ejercicio 1.1)
            errorFullName.Visible = false;
            errorEmail.Visible = false;
            errorAddress.Visible = false;
            errorUserName.Visible = false;
            errorPassword.Visible = false;
            errorPasswordConfirm.Visible = false;

            // Agregar eventos Leave a los TextBox para validar al perder el foco
            tbFullName.Leave += TbFullName_Leave;
            tbEmail.Leave += TbEmail_Leave;
            tbUserName.Leave += TbUserName_Leave;
            tbPassword.Leave += TbPassword_Leave;
            tbPasswordConfirm.Leave += TbPasswordConfirm_Leave;
            tbAddress.Leave += TbAddress_Leave;
        }

        // Boton de Submit
        private void Button1_Click(object sender, EventArgs e)
        {
            PanelDeLaAplicacion panel = new PanelDeLaAplicacion();
            panel.Show(); // Mostrar el formulario de PanelDeLaAplicacion
            this.Hide(); // Cerrar el formulario actual
        }

        // Función para validar si todos los text box son válidos
        private bool AreAllTextboxValid()
        {
            // El botón de submit deberá estar inhabilitado hasta que todos los campos sean correctos (agregado en el Ejercicio 1.1)
            if (!errorFullName.Visible && !errorEmail.Visible && !errorAddress.Visible && !errorUserName.Visible && !errorPassword.Visible && !errorPasswordConfirm.Visible)
            {
                btnSubmit.Visible = true;
                return true;
            }

            btnSubmit.Visible = false;
            return false;
        }

        // Validaciones al escribir en los campos
        private void TbFullName_TextChanged(object sender, EventArgs e) => ValidateFullName();
        private void TbEmail_TextChanged(object sender, EventArgs e) => ValidateEmail();
        private void TbAddress_TextChanged(object sender, EventArgs e) => ValidateAddress();
        private void TbUserName_TextChanged(object sender, EventArgs e) => ValidateUserName();
        private void TbPassword_TextChanged(object sender, EventArgs e) => ValidatePassword();
        private void TbPasswordConfirm_TextChanged(object sender, EventArgs e) => ValidatePasswordConfirm();

        
        // Validaciones al perder el foco
        private void TbFullName_Leave(object? sender, EventArgs e) => ValidateFullName();
        private void TbEmail_Leave(object? sender, EventArgs e) => ValidateEmail();
        private void TbUserName_Leave(object? sender, EventArgs e) => ValidateUserName();
        private void TbPassword_Leave(object? sender, EventArgs e) => ValidatePassword();
        private void TbPasswordConfirm_Leave(object? sender, EventArgs e) => ValidatePasswordConfirm();
        private void TbAddress_Leave(object? sender, EventArgs e) => ValidateAddress();


        // Funciones de validación
        private void ValidateFullName()
        {
            // Validar que el campo de nombre completo no esté vacío
            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                errorFullName.Visible = true;
                errorFullName.Text = "El campo de nombre completo no puede estar vacío.";
            }
            else
            {
                // Validar que el campo de nombre completo sea solo letras y espacios
                foreach (char c in tbFullName.Text)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        errorFullName.Visible = true;
                        errorFullName.Text = "El campo de nombre completo no es válido.";
                        return;
                    }
                }
                errorFullName.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateEmail()
        {
            // Validar que el campo de email no esté vacío y tenga un arroba "@"
            if (string.IsNullOrEmpty(tbEmail.Text) || !tbEmail.Text.Contains('@'))
            {
                errorEmail.Visible = true;
                errorEmail.Text = "El campo de email no es válido.";
            }
            else
            {
                errorEmail.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateAddress()
        {
            // Validar que el campo de dirección no esté vacío
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                errorAddress.Visible = true;
                errorAddress.Text = "El campo de dirección no puede estar vacío.";
            }
            else
            {
                errorAddress.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateUserName()
        {
            // Validar que el campo de usuario no esté vacío y sea todo minúscula
            if (string.IsNullOrEmpty(tbUserName.Text) || tbUserName.Text != tbUserName.Text.ToLower())
            {
                errorUserName.Visible = true;
                errorUserName.Text = "El campo de usuario no es válido.";
            }
            else
            {
                errorUserName.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidatePassword()
        {
            // Validar que la contraseña sea fuerte (al menos una mayúscula y un número)
            if (!tbPassword.Text.Any(char.IsUpper) || !tbPassword.Text.Any(char.IsDigit))
            {
                errorPassword.Visible = true;
                errorPassword.Text = "La contraseña debe tener al menos una mayúscula y un número.";
            }
            else
            {
                errorPassword.Visible = false;
                labelConfirmPassword.Visible = true;
                tbPasswordConfirm.Visible = true;
            }

            AreAllTextboxValid();
        }

        private void ValidatePasswordConfirm()
        {
            // Validar que la contraseña coincida con la de confirmación
            if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                errorPasswordConfirm.Visible = true;
                errorPasswordConfirm.Text = "Las contraseñas no coinciden.";
            }
            else
            {
                errorPasswordConfirm.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void Label1_Click(object sender, EventArgs e) { }
    }
}