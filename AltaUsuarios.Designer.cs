﻿namespace Iglesia
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alta de Usuarios en el Sistema";
            // 
            // textBoxDNIBuscar
            // 
            this.textBoxDNIBuscar.Location = new System.Drawing.Point(157, 128);
            this.textBoxDNIBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.textBoxDNIBuscar.Name = "textBoxDNIBuscar";
            this.textBoxDNIBuscar.Size = new System.Drawing.Size(127, 26);
            this.textBoxDNIBuscar.TabIndex = 1;
            this.textBoxDNIBuscar.TextChanged += new System.EventHandler(this.textBoxDNIBuscar_TextChanged);
            this.textBoxDNIBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNIBuscar_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ingresar DNI:";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(302, 128);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(84, 29);
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
            this.label3.Location = new System.Drawing.Point(32, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 42);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre de \r\nUsuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(32, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tipo de Usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(157, 186);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 26);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(157, 232);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(200, 26);
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
            this.comboBoxTipoUsuario.Location = new System.Drawing.Point(157, 284);
            this.comboBoxTipoUsuario.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.comboBoxTipoUsuario.Name = "comboBoxTipoUsuario";
            this.comboBoxTipoUsuario.Size = new System.Drawing.Size(136, 28);
            this.comboBoxTipoUsuario.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 342);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inhabilitado?:";
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(157, 340);
            this.checkBoxInhabilitado.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(51, 24);
            this.checkBoxInhabilitado.TabIndex = 11;
            this.checkBoxInhabilitado.Text = "SI";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(221, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dar de alta al Usuario?:";
            // 
            // checkBoxAltaUser
            // 
            this.checkBoxAltaUser.AutoSize = true;
            this.checkBoxAltaUser.Location = new System.Drawing.Point(403, 342);
            this.checkBoxAltaUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.checkBoxAltaUser.Name = "checkBoxAltaUser";
            this.checkBoxAltaUser.Size = new System.Drawing.Size(51, 24);
            this.checkBoxAltaUser.TabIndex = 13;
            this.checkBoxAltaUser.Text = "SI";
            this.checkBoxAltaUser.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.buttonAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAceptar.Location = new System.Drawing.Point(53, 418);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(117, 65);
            this.buttonAceptar.TabIndex = 14;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.buttonCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancelar.Location = new System.Drawing.Point(269, 418);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(117, 65);
            this.buttonCancelar.TabIndex = 15;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(321, 287);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 35);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // AltaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 508);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.checkBoxAltaUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.checkBoxInhabilitado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxTipoUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDNIBuscar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "AltaUsuarios";
            this.Text = "AltaUsuarios";
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
    }
}