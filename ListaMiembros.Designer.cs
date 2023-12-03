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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListaMiembros));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.botonBuscar = new System.Windows.Forms.Button();
            this.DGVMiembros = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDescargar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonFiltrar = new System.Windows.Forms.Button();
            this.checkBoxHabilitado = new System.Windows.Forms.CheckBox();
            this.checkBoxInhabilitado = new System.Windows.Forms.CheckBox();
            this.checkBoxTodos = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMiembros)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(364, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de Miembros";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDNI.Font = new System.Drawing.Font("Consolas", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDNI.Location = new System.Drawing.Point(28, 54);
            this.textBoxDNI.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(191, 19);
            this.textBoxDNI.TabIndex = 2;
            this.textBoxDNI.Text = "ingresar D.N.I";
            this.textBoxDNI.TextChanged += new System.EventHandler(this.textBoxDNI_TextChanged);
            this.textBoxDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxDNI_KeyPress);
            // 
            // botonBuscar
            // 
            this.botonBuscar.FlatAppearance.BorderSize = 3;
            this.botonBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.botonBuscar.Location = new System.Drawing.Point(252, 49);
            this.botonBuscar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.botonBuscar.Name = "botonBuscar";
            this.botonBuscar.Size = new System.Drawing.Size(84, 29);
            this.botonBuscar.TabIndex = 3;
            this.botonBuscar.Text = "Buscar";
            this.botonBuscar.UseVisualStyleBackColor = true;
            this.botonBuscar.Click += new System.EventHandler(this.botonBuscar_Click);
            // 
            // DGVMiembros
            // 
            this.DGVMiembros.AllowUserToAddRows = false;
            this.DGVMiembros.AllowUserToDeleteRows = false;
            this.DGVMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMiembros.Location = new System.Drawing.Point(84, 291);
            this.DGVMiembros.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVMiembros.Name = "DGVMiembros";
            this.DGVMiembros.ReadOnly = true;
            this.DGVMiembros.RowHeadersWidth = 51;
            this.DGVMiembros.RowTemplate.Height = 24;
            this.DGVMiembros.Size = new System.Drawing.Size(859, 314);
            this.DGVMiembros.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lista:";
            // 
            // buttonDescargar
            // 
            this.buttonDescargar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonDescargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDescargar.Location = new System.Drawing.Point(371, 640);
            this.buttonDescargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDescargar.Name = "buttonDescargar";
            this.buttonDescargar.Size = new System.Drawing.Size(110, 52);
            this.buttonDescargar.TabIndex = 8;
            this.buttonDescargar.Text = "Descargar";
            this.buttonDescargar.UseVisualStyleBackColor = true;
            this.buttonDescargar.Click += new System.EventHandler(this.buttonDescargar_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(508, 640);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "Salir";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonFiltrar
            // 
            this.buttonFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonFiltrar.Location = new System.Drawing.Point(338, 33);
            this.buttonFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFiltrar.Name = "buttonFiltrar";
            this.buttonFiltrar.Size = new System.Drawing.Size(109, 45);
            this.buttonFiltrar.TabIndex = 10;
            this.buttonFiltrar.Text = "Filtrar";
            this.buttonFiltrar.UseVisualStyleBackColor = true;
            this.buttonFiltrar.Click += new System.EventHandler(this.buttonFiltrar_Click_1);
            // 
            // checkBoxHabilitado
            // 
            this.checkBoxHabilitado.AutoSize = true;
            this.checkBoxHabilitado.Location = new System.Drawing.Point(7, 44);
            this.checkBoxHabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxHabilitado.Name = "checkBoxHabilitado";
            this.checkBoxHabilitado.Size = new System.Drawing.Size(106, 24);
            this.checkBoxHabilitado.TabIndex = 11;
            this.checkBoxHabilitado.Text = "Habilitado";
            this.checkBoxHabilitado.UseVisualStyleBackColor = true;
            // 
            // checkBoxInhabilitado
            // 
            this.checkBoxInhabilitado.AutoSize = true;
            this.checkBoxInhabilitado.Location = new System.Drawing.Point(116, 44);
            this.checkBoxInhabilitado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxInhabilitado.Name = "checkBoxInhabilitado";
            this.checkBoxInhabilitado.Size = new System.Drawing.Size(117, 24);
            this.checkBoxInhabilitado.TabIndex = 12;
            this.checkBoxInhabilitado.Text = "Inhabilitado";
            this.checkBoxInhabilitado.UseVisualStyleBackColor = true;
            // 
            // checkBoxTodos
            // 
            this.checkBoxTodos.AutoSize = true;
            this.checkBoxTodos.Location = new System.Drawing.Point(253, 44);
            this.checkBoxTodos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTodos.Name = "checkBoxTodos";
            this.checkBoxTodos.Size = new System.Drawing.Size(79, 24);
            this.checkBoxTodos.TabIndex = 13;
            this.checkBoxTodos.Text = "Todos";
            this.checkBoxTodos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDNI);
            this.groupBox1.Controls.Add(this.botonBuscar);
            this.groupBox1.Location = new System.Drawing.Point(59, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(375, 97);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar por DNI";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxHabilitado);
            this.groupBox2.Controls.Add(this.checkBoxInhabilitado);
            this.groupBox2.Controls.Add(this.checkBoxTodos);
            this.groupBox2.Controls.Add(this.buttonFiltrar);
            this.groupBox2.Location = new System.Drawing.Point(474, 120);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(469, 97);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar por:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::arreglarTesis.Properties.Resources._81;
            this.pictureBox2.Location = new System.Drawing.Point(650, 512);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(468, 299);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::arreglarTesis.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(129, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(722, 50);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // ListaMiembros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1018, 715);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDescargar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DGVMiembros);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ListaMiembros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListaMiembros";
            ((System.ComponentModel.ISupportInitialize)(this.DGVMiembros)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.Button botonBuscar;
        private System.Windows.Forms.DataGridView DGVMiembros;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDescargar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonFiltrar;
        private System.Windows.Forms.CheckBox checkBoxHabilitado;
        private System.Windows.Forms.CheckBox checkBoxInhabilitado;
        private System.Windows.Forms.CheckBox checkBoxTodos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}