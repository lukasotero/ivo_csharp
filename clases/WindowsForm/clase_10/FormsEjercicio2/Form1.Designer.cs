namespace FormsEjercicio2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            tbApellido = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            tbDocumento = new TextBox();
            cbTipoDocumento = new ComboBox();
            label5 = new Label();
            dtpFechaNacimiento = new DateTimePicker();
            gbTipoCliente = new GroupBox();
            rbTipoProveedor = new RadioButton();
            rbTipoCliente = new RadioButton();
            gbSucursal = new GroupBox();
            checkQuilmes = new CheckBox();
            checkBelgrano = new CheckBox();
            checkAvellaneda = new CheckBox();
            btnLimpiar = new Button();
            btnEnviar = new Button();
            labelError = new Label();
            gbTipoCliente.SuspendLayout();
            gbSucursal.SuspendLayout();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(65, 33);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(191, 23);
            tbNombre.TabIndex = 0;
            // 
            // tbApellido
            // 
            tbApellido.Location = new Point(65, 75);
            tbApellido.Name = "tbApellido";
            tbApellido.Size = new Size(191, 23);
            tbApellido.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 36);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 78);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 36);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 78);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 5;
            label4.Text = "N Documento";
            // 
            // tbDocumento
            // 
            tbDocumento.Location = new Point(404, 75);
            tbDocumento.Name = "tbDocumento";
            tbDocumento.Size = new Size(121, 23);
            tbDocumento.TabIndex = 6;
            // 
            // cbTipoDocumento
            // 
            cbTipoDocumento.FormattingEnabled = true;
            cbTipoDocumento.Items.AddRange(new object[] { "DNI", "LC", "LE", "CI" });
            cbTipoDocumento.Location = new Point(404, 33);
            cbTipoDocumento.Name = "cbTipoDocumento";
            cbTipoDocumento.Size = new Size(121, 23);
            cbTipoDocumento.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 132);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 8;
            label5.Text = "F. Nac.";
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(65, 126);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(237, 23);
            dtpFechaNacimiento.TabIndex = 9;
            // 
            // gbTipoCliente
            // 
            gbTipoCliente.Controls.Add(rbTipoProveedor);
            gbTipoCliente.Controls.Add(rbTipoCliente);
            gbTipoCliente.Location = new Point(65, 176);
            gbTipoCliente.Name = "gbTipoCliente";
            gbTipoCliente.Size = new Size(166, 66);
            gbTipoCliente.TabIndex = 11;
            gbTipoCliente.TabStop = false;
            gbTipoCliente.Text = "Tipo";
            gbTipoCliente.Enter += GroupBox1_Enter;
            // 
            // rbTipoProveedor
            // 
            rbTipoProveedor.AutoSize = true;
            rbTipoProveedor.Location = new Point(74, 34);
            rbTipoProveedor.Name = "rbTipoProveedor";
            rbTipoProveedor.Size = new Size(79, 19);
            rbTipoProveedor.TabIndex = 13;
            rbTipoProveedor.TabStop = true;
            rbTipoProveedor.Text = "Proveedor";
            rbTipoProveedor.UseVisualStyleBackColor = true;
            // 
            // rbTipoCliente
            // 
            rbTipoCliente.AutoSize = true;
            rbTipoCliente.Location = new Point(6, 34);
            rbTipoCliente.Name = "rbTipoCliente";
            rbTipoCliente.Size = new Size(62, 19);
            rbTipoCliente.TabIndex = 12;
            rbTipoCliente.TabStop = true;
            rbTipoCliente.Text = "Cliente";
            rbTipoCliente.UseVisualStyleBackColor = true;
            // 
            // gbSucursal
            // 
            gbSucursal.Controls.Add(checkQuilmes);
            gbSucursal.Controls.Add(checkBelgrano);
            gbSucursal.Controls.Add(checkAvellaneda);
            gbSucursal.Location = new Point(316, 176);
            gbSucursal.Name = "gbSucursal";
            gbSucursal.Size = new Size(209, 116);
            gbSucursal.TabIndex = 14;
            gbSucursal.TabStop = false;
            gbSucursal.Text = "Sucursal";
            // 
            // checkQuilmes
            // 
            checkQuilmes.AutoSize = true;
            checkQuilmes.Location = new Point(15, 85);
            checkQuilmes.Name = "checkQuilmes";
            checkQuilmes.Size = new Size(70, 19);
            checkQuilmes.TabIndex = 2;
            checkQuilmes.Text = "Quilmes";
            checkQuilmes.UseVisualStyleBackColor = true;
            // 
            // checkBelgrano
            // 
            checkBelgrano.AutoSize = true;
            checkBelgrano.Location = new Point(15, 60);
            checkBelgrano.Name = "checkBelgrano";
            checkBelgrano.Size = new Size(73, 19);
            checkBelgrano.TabIndex = 1;
            checkBelgrano.Text = "Belgrano";
            checkBelgrano.UseVisualStyleBackColor = true;
            // 
            // checkAvellaneda
            // 
            checkAvellaneda.AutoSize = true;
            checkAvellaneda.Location = new Point(15, 35);
            checkAvellaneda.Name = "checkAvellaneda";
            checkAvellaneda.Size = new Size(84, 19);
            checkAvellaneda.TabIndex = 0;
            checkAvellaneda.Text = "Avellaneda";
            checkAvellaneda.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(172, 310);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 31);
            btnLimpiar.TabIndex = 15;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += BtnLimpiar_Click;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(293, 310);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(107, 31);
            btnEnviar.TabIndex = 16;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += BtnEnviar_Click;
            // 
            // labelError
            // 
            labelError.AutoSize = true;
            labelError.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelError.ForeColor = Color.Red;
            labelError.Location = new Point(46, 258);
            labelError.Name = "labelError";
            labelError.Size = new Size(233, 25);
            labelError.TabIndex = 17;
            labelError.Text = "Faltan completar campos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(547, 361);
            Controls.Add(labelError);
            Controls.Add(btnEnviar);
            Controls.Add(btnLimpiar);
            Controls.Add(gbSucursal);
            Controls.Add(gbTipoCliente);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(label5);
            Controls.Add(cbTipoDocumento);
            Controls.Add(tbDocumento);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbApellido);
            Controls.Add(tbNombre);
            Name = "Form1";
            Text = "Form1";
            gbTipoCliente.ResumeLayout(false);
            gbTipoCliente.PerformLayout();
            gbSucursal.ResumeLayout(false);
            gbSucursal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbNombre;
        private TextBox tbApellido;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox tbDocumento;
        private ComboBox cbTipoDocumento;
        private Label label5;
        private DateTimePicker dtpFechaNacimiento;
        private GroupBox gbTipoCliente;
        private RadioButton rbTipoProveedor;
        private RadioButton rbTipoCliente;
        private GroupBox gbSucursal;
        private CheckBox checkQuilmes;
        private CheckBox checkBelgrano;
        private CheckBox checkAvellaneda;
        private Button btnLimpiar;
        private Button btnEnviar;
        private Label labelError;
    }
}
