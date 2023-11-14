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
            this.label6 = new System.Windows.Forms.Label();
            this.checkboxNo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(372, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inhabilitación/habilitación ";
            // 
            // textBoxBuscarDNI
            // 
            this.textBoxBuscarDNI.Location = new System.Drawing.Point(154, 132);
            this.textBoxBuscarDNI.Name = "textBoxBuscarDNI";
            this.textBoxBuscarDNI.Size = new System.Drawing.Size(124, 22);
            this.textBoxBuscarDNI.TabIndex = 4;
            this.textBoxBuscarDNI.TextChanged += new System.EventHandler(this.textBoxBuscarDNI_TextChanged_1);
            this.textBoxBuscarDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxBuscarDNI_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(154, 177);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(206, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(154, 215);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(206, 22);
            this.txtApellido.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Enabled = false;
            this.buttonAceptar.Location = new System.Drawing.Point(99, 318);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(97, 56);
            this.buttonAceptar.TabIndex = 9;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.BackColor = System.Drawing.SystemColors.Control;
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(262, 318);
            this.buttonCancelar.MaximumSize = new System.Drawing.Size(98, 56);
            this.buttonCancelar.MinimumSize = new System.Drawing.Size(98, 56);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(98, 56);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = false;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // buttonBuscarDNI
            // 
            this.buttonBuscarDNI.Location = new System.Drawing.Point(289, 126);
            this.buttonBuscarDNI.Name = "buttonBuscarDNI";
            this.buttonBuscarDNI.Size = new System.Drawing.Size(71, 34);
            this.buttonBuscarDNI.TabIndex = 11;
            this.buttonBuscarDNI.Text = "Buscar";
            this.buttonBuscarDNI.UseVisualStyleBackColor = true;
            this.buttonBuscarDNI.Click += new System.EventHandler(this.buttonBuscarDNI_Click);
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(170, 260);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(41, 20);
            this.checkBoxInhabilitado.TabIndex = 12;
            this.checkBoxInhabilitado.Text = "SI";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            this.checkBoxInhabilitado.CheckStateChanged += new System.EventHandler(this.checkBoxInhabilitado_CheckStateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Está Inhabilitado?";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(271, 260);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(76, 28);
            this.buttonLimpiar.TabIndex = 14;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(123, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 32);
            this.label6.TabIndex = 15;
            this.label6.Text = "de personas";
            // 
            // checkboxNo
            // 
            this.checkboxNo.AutoSize = true;
            this.checkboxNo.Location = new System.Drawing.Point(170, 286);
            this.checkboxNo.Name = "checkboxNo";
            this.checkboxNo.Size = new System.Drawing.Size(49, 20);
            this.checkboxNo.TabIndex = 16;
            this.checkboxNo.Text = "NO";
            this.checkboxNo.UseVisualStyleBackColor = true;
            this.checkboxNo.CheckStateChanged += new System.EventHandler(this.checkboxNo_CheckStateChanged);
            // 
            // InhabilitarPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancelar;
            this.ClientSize = new System.Drawing.Size(472, 386);
            this.ControlBox = false;
            this.Controls.Add(this.checkboxNo);
            this.Controls.Add(this.label6);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(490, 433);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(473, 433);
            this.Name = "InhabilitarPersonas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "InhabilitarPersonas";
            this.Load += new System.EventHandler(this.InhabilitarPersonas_Load);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkboxNo;
    }
}