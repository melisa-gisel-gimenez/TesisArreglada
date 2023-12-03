namespace Iglesia
{
    partial class InhabilitarPersonas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InhabilitarPersonas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxBuscarDNI = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonBuscarDNI = new System.Windows.Forms.Button();
            this.checkBoxInhabilitado = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.checkboxNo = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(443, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inhabilitación/habilitación de personas\r\n";
            // 
            // textBoxBuscarDNI
            // 
            this.textBoxBuscarDNI.Location = new System.Drawing.Point(173, 165);
            this.textBoxBuscarDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxBuscarDNI.Name = "textBoxBuscarDNI";
            this.textBoxBuscarDNI.Size = new System.Drawing.Size(139, 26);
            this.textBoxBuscarDNI.TabIndex = 4;
            this.textBoxBuscarDNI.TextChanged += new System.EventHandler(this.textBoxBuscarDNI_TextChanged_1);
            this.textBoxBuscarDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(173, 221);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(231, 26);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(173, 269);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(231, 26);
            this.txtApellido.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(106, 423);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(109, 70);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(281, 423);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(110, 70);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(110, 70);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(110, 70);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarDNI
            // 
            this.buttonBuscarDNI.Location = new System.Drawing.Point(325, 158);
            this.buttonBuscarDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonBuscarDNI.Name = "buttonBuscarDNI";
            this.buttonBuscarDNI.Size = new System.Drawing.Size(80, 42);
            this.buttonBuscarDNI.TabIndex = 11;
            this.buttonBuscarDNI.Text = "Buscar";
            this.buttonBuscarDNI.UseVisualStyleBackColor = true;
            this.buttonBuscarDNI.Click += new System.EventHandler(this.buttonBuscarDNI_Click);
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(191, 325);
            this.checkBoxInhabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(51, 24);
            this.checkBoxInhabilitado.TabIndex = 12;
            this.checkBoxInhabilitado.Text = "SI";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            this.checkBoxInhabilitado.CheckStateChanged += new System.EventHandler(this.checkBoxInhabilitado_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Está Inhabilitado?";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(305, 325);
            this.buttonLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(86, 35);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // checkboxNo
            // 
            this.checkboxNo.AutoSize = true;
            this.checkboxNo.Location = new System.Drawing.Point(191, 358);
            this.checkboxNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkboxNo.Name = "checkboxNo";
            this.checkboxNo.Size = new System.Drawing.Size(58, 24);
            this.checkboxNo.TabIndex = 16;
            this.checkboxNo.Text = "NO";
            this.checkboxNo.UseVisualStyleBackColor = true;
            this.checkboxNo.CheckStateChanged += new System.EventHandler(this.checkboxNo_CheckStateChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arreglarTesis.Properties.Resources._91;
            this.pictureBox1.Location = new System.Drawing.Point(24, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 187);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::arreglarTesis.Properties.Resources._91;
            this.pictureBox2.Location = new System.Drawing.Point(149, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(316, 211);
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::arreglarTesis.Properties.Resources._91;
            this.pictureBox3.Location = new System.Drawing.Point(43, 302);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(422, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // InhabilitarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(526, 506);
            this.ControlBox = false;
            this.Controls.Add(this.checkboxNo);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxInhabilitado);
            this.Controls.Add(this.buttonBuscarDNI);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.textBoxBuscarDNI);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(529, 527);
            this.Name = "InhabilitarPersonas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "InhabilitarPersonas";
            this.Load += new System.EventHandler(this.InhabilitarPersonas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxBuscarDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonBuscarDNI;
        private System.Windows.Forms.CheckBox checkBoxInhabilitado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.CheckBox checkboxNo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}