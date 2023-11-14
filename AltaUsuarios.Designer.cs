namespace Iglesia
{
    partial class AltaUsuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDNIBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.comboBoxTipoUsuario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxInhabilitado = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBoxAltaUser = new System.Windows.Forms.CheckBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(401, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Usuarios en el Sistema";
            // 
            // textBoxDNIBuscar
            // 
            this.textBoxDNIBuscar.Location = new System.Drawing.Point(140, 102);
            this.textBoxDNIBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDNIBuscar.Name = "textBoxDNIBuscar";
            this.textBoxDNIBuscar.Size = new System.Drawing.Size(113, 22);
            this.textBoxDNIBuscar.TabIndex = 1;
            this.textBoxDNIBuscar.TextChanged += new System.EventHandler(this.textBoxDNIBuscar_TextChanged);
            this.textBoxDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNIBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar DNI:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(268, 102);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Location = new System.Drawing.Point(24, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de \r\nUsuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(23, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(128, 47);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(178, 22);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 358);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 8;
            // 
            // comboBoxTipoUsuario
            // 
            this.comboBoxTipoUsuario.FormattingEnabled = true;
            this.comboBoxTipoUsuario.Items.AddRange(new object[] {
            "Tesorero",
            "Pastor",
            "Administrador",
            "Mentor"});
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(142, 395);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoUsuario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inhabilitado?:";
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(130, 155);
            this.checkBoxInhabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(41, 20);
            this.checkBoxInhabilitado.TabIndex = 11;
            this.checkBoxInhabilitado.Text = "SI";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dar de alta al Usuario?:";
            // 
            // checkBoxAltaUser
            // 
            this.checkBoxAltaUser.AutoSize = true;
            this.checkBoxAltaUser.Location = new System.Drawing.Point(197, 446);
            this.checkBoxAltaUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxAltaUser.Name = "checkBoxAltaUser";
            this.checkBoxAltaUser.Size = new System.Drawing.Size(41, 20);
            this.checkBoxAltaUser.TabIndex = 13;
            this.checkBoxAltaUser.Text = "SI";
            this.checkBoxAltaUser.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(42, 508);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(104, 52);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(223, 508);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(104, 52);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(315, 440);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(67, 28);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(140, 148);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(113, 22);
            this.txtNombre.TabIndex = 17;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(128, 103);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(113, 22);
            this.txtApellido.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Nombre:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 16);
            this.label9.TabIndex = 20;
            this.label9.Text = "Apellido:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkBoxInhabilitado);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(397, 198);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miembro Seleccionado";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNombreUsuario);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 279);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 222);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos para el login";
            // 
            // AltaUsuarios
            // 
            this.AcceptButton = this.buttonAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(430, 573);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.checkBoxAltaUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDNIBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AltaUsuarios";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "AltaUsuarios";
            this.Load += new System.EventHandler(this.AltaUsuarios_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNIBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.ComboBox comboBoxTipoUsuario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxInhabilitado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBoxAltaUser;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}