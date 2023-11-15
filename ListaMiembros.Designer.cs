namespace arreglarTesis
{
    partial class ListaMiembros
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVMiembros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDescargar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.checkBoxInhabilitado = new System.Windows.Forms.CheckBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMiembros)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de  Miembros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar por DNI:";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(130, 79);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 22);
            this.textBoxDNI.TabIndex = 2;
            // 
            // botonBuscar
            // 
            this.botonBuscar.Location = new System.Drawing.Point(247, 79);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(75, 23);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Filtrar por:";
            // 
            // DGVMiembros
            // 
            this.DGVMiembros.AllowUserToAddRows = false;
            this.DGVMiembros.AllowUserToDeleteRows = false;
            this.DGVMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMiembros.Location = new System.Drawing.Point(26, 249);
            this.DGVMiembros.Name = "DGVMiembros";
            this.DGVMiembros.ReadOnly = true;
            this.DGVMiembros.RowHeadersWidth = 51;
            this.DGVMiembros.RowTemplate.Height = 24;
            this.DGVMiembros.Size = new System.Drawing.Size(752, 211);
            this.DGVMiembros.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista:";
            // 
            // buttonDescargar
            // 
            this.buttonDescargar.Location = new System.Drawing.Point(247, 468);
            this.buttonDescargar.Name = "buttonDescargar";
            this.buttonDescargar.Size = new System.Drawing.Size(98, 42);
            this.buttonDescargar.TabIndex = 8;
            this.buttonDescargar.Text = "Descargar";
            this.buttonDescargar.UseVisualStyleBackColor = true;
            this.buttonDescargar.Click += new System.EventHandler(this.buttonDescargar_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(397, 466);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.Location = new System.Drawing.Point(510, 176);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(75, 23);
            this.buttonFiltrar.TabIndex = 10;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click_1);
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(526, 74);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(91, 20);
            this.checkBoxHabilitado.TabIndex = 11;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(526, 102);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(98, 20);
            this.checkBoxInhabilitado.TabIndex = 12;
            this.checkBoxInhabilitado.Text = "Inhabilitado";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(526, 128);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(69, 20);
            this.checkBoxTodos.TabIndex = 13;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // ListaMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.checkBoxTodos);
            this.Controls.Add(this.checkBoxInhabilitado);
            this.Controls.Add(this.checkBoxHabilitado);
            this.Controls.Add(this.buttonFiltrar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDescargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVMiembros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.botonBuscar);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ListaMiembros";
            this.Text = "ListaMiembros";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMiembros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DGVMiembros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDescargar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.CheckBox checkBoxInhabilitado;
        private System.Windows.Forms.CheckBox checkBoxTodos;
    }
}