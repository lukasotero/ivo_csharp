using FormsEjercicio1._1;

namespace FormsEjercicio1
{
    public partial class SingUpForm : Form
    {
        public SingUpForm()
        {
            InitializeComponent();
            btnSubmit.Visible = false; // Inicializamos el bot�n de submit deshabilitado (agregado en el Ejercicio 1.1)
            labelConfirmPassword.Visible = false; // Inicializamos el label de confirmar contrase�a deshabilitado (agregado en el Ejercicio 1.1)
            tbPasswordConfirm.Visible = false; // Inicializamos el campo de confirmar contrase�a deshabilitado (agregado en el Ejercicio 1.1)

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

        // Funci�n para validar si todos los text box son v�lidos
        private bool AreAllTextboxValid()
        {
            // El bot�n de submit deber� estar inhabilitado hasta que todos los campos sean correctos (agregado en el Ejercicio 1.1)
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


        // Funciones de validaci�n
        private void ValidateFullName()
        {
            // Validar que el campo de nombre completo no est� vac�o
            if (string.IsNullOrEmpty(tbFullName.Text))
            {
                errorFullName.Visible = true;
                errorFullName.Text = "El campo de nombre completo no puede estar vac�o.";
            }
            else
            {
                // Validar que el campo de nombre completo sea solo letras y espacios
                foreach (char c in tbFullName.Text)
                {
                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        errorFullName.Visible = true;
                        errorFullName.Text = "El campo de nombre completo no es v�lido.";
                        return;
                    }
                }
                errorFullName.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateEmail()
        {
            // Validar que el campo de email no est� vac�o y tenga un arroba "@"
            if (string.IsNullOrEmpty(tbEmail.Text) || !tbEmail.Text.Contains('@'))
            {
                errorEmail.Visible = true;
                errorEmail.Text = "El campo de email no es v�lido.";
            }
            else
            {
                errorEmail.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateAddress()
        {
            // Validar que el campo de direcci�n no est� vac�o
            if (string.IsNullOrEmpty(tbAddress.Text))
            {
                errorAddress.Visible = true;
                errorAddress.Text = "El campo de direcci�n no puede estar vac�o.";
            }
            else
            {
                errorAddress.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidateUserName()
        {
            // Validar que el campo de usuario no est� vac�o y sea todo min�scula
            if (string.IsNullOrEmpty(tbUserName.Text) || tbUserName.Text != tbUserName.Text.ToLower())
            {
                errorUserName.Visible = true;
                errorUserName.Text = "El campo de usuario no es v�lido.";
            }
            else
            {
                errorUserName.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidatePassword()
        {
            // Validar que la contrase�a sea fuerte (al menos una may�scula y un n�mero)
            if (!tbPassword.Text.Any(char.IsUpper) || !tbPassword.Text.Any(char.IsDigit))
            {
                errorPassword.Visible = true;
                errorPassword.Text = "La contrase�a debe tener al menos una may�scula y un n�mero.";
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
            // Validar que la contrase�a coincida con la de confirmaci�n
            if (tbPassword.Text != tbPasswordConfirm.Text)
            {
                errorPasswordConfirm.Visible = true;
                errorPasswordConfirm.Text = "Las contrase�as no coinciden.";
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