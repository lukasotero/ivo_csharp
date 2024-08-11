namespace FormsEjercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            labelError.Visible = false; // Inicializar el label de error como no visible
            btnEnviar.Enabled = false; // Inicializar el bot�n de enviar como inhabilitado
        }

        // Funci�n para validar si todos los text box son v�lidos
        private bool AreAllTextboxValid()
        {
            // El bot�n de enviar deber� estar inhabilitado hasta que todos los campos esten completos
            if (!labelError.Visible)
            {
                btnEnviar.Enabled = true;
                return true;
            }

            btnEnviar.Enabled = false;
            return false;
        }

        // Funciones de validaci�n
        private void ValidarNombre()
        {
            // Validar que el campo de nombre no est� vac�o
            if (string.IsNullOrEmpty(tbNombre.Text))
            {
                labelError.Visible = true;
            }
            else
            {
                // Validar que el campo de nombre sea s�lo letras y espacios
                foreach (char c in tbNombre.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        labelError.Visible = true;
                        return;
                    }
                }
                labelError.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidarApellido()
        {
            // Validar que el campo de apellido no est� vac�o
            if (string.IsNullOrEmpty(tbApellido.Text))
            {
                labelError.Visible = true;
            }
            else
            {
                // Validar que el campo de apellido sea s�lo letras
                foreach (char c in tbApellido.Text)
                {
                    if (!char.IsLetter(c))
                    {
                        labelError.Visible = true;
                        return;
                    }
                }
                labelError.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void ValidarNumeroDocumento()
        {
            // Validar que el campo de n�mero de documento no est� vac�o
            if (string.IsNullOrEmpty(tbDocumento.Text))
            {
                labelError.Visible = true;
            }
            else
            {
                // Validar que el campo de apellido sea s�lo n�meros
                foreach (char c in tbDocumento.Text)
                {
                    if (!char.IsDigit(c))
                    {
                        labelError.Visible = true;
                        return;
                    }
                }
                labelError.Visible = false;
            }

            AreAllTextboxValid();
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {
            if (rbTipoCliente.Checked)
            {
                rbTipoProveedor.Checked = false;
            }
            else if (rbTipoProveedor.Checked)
            {
                rbTipoCliente.Checked = false;
            }
        }

        // Bot�n enviar
        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            ValidarNombre();
            ValidarApellido();
            ValidarNumeroDocumento();

            // Obtener informacion del gbTipoCliente
            string tipoCliente = "";
            foreach (Control control in gbTipoCliente.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    if (radioButton.Checked)
                    {
                        tipoCliente = radioButton.Text;
                    }
                }
            }

            // Obtener informacion del gbSucursal
            string sucursal = "";
            foreach (Control control in gbSucursal.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    if (checkBox.Checked)
                    {
                        sucursal += checkBox.Text + "/";
                    }
                }
            }

            MessageBox.Show(
                "Nombre: " + tbNombre.Text +
                "\nApellido: " + tbApellido.Text +
                "\nTipo Documento: " + cbTipoDocumento.Text +
                "\nN�mero Documento: " + tbDocumento.Text +
                "\nFecha de Nacimiento: " + dtpFechaNacimiento.Value.ToString("dd/MM/yyyy") +
                "\nTipo de cliente: " + tipoCliente +
                "\nSucursal: " + sucursal
                );
        }

        // Bot�n limpiar los campos
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Text = "";
            tbApellido.Text = "";
            cbTipoDocumento.Text = "";
            tbDocumento.Text = "";
            dtpFechaNacimiento.Value = DateTime.Now;

            foreach (Control control in gbTipoCliente.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radioButton = (RadioButton)control;
                    radioButton.Checked = false;
                }
            }

            foreach (Control control in gbSucursal.Controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                }
            }
        }
    }
}
