namespace arreglarTesis
{
    partial class InformeTesoreria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InformeTesoreria));
            this.DGVIngresos = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVEgresos = new System.Windows.Forms.DataGridView();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVIngresos
            // 
            this.DGVIngresos.AllowUserToAddRows = false;
            this.DGVIngresos.AllowUserToDeleteRows = false;
            this.DGVIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIngresos.Location = new System.Drawing.Point(178, 226);
            this.DGVIngresos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVIngresos.Name = "DGVIngresos";
            this.DGVIngresos.ReadOnly = true;
            this.DGVIngresos.RowHeadersWidth = 51;
            this.DGVIngresos.RowTemplate.Height = 24;
            this.DGVIngresos.Size = new System.Drawing.Size(537, 218);
            this.DGVIngresos.TabIndex = 0;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(276, 125);
            this.dateTimePickerDesde.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(224, 26);
            this.dateTimePickerDesde.TabIndex = 1;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(276, 160);
            this.dateTimePickerHasta.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(224, 26);
            this.dateTimePickerHasta.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFiltrar.Location = new System.Drawing.Point(566, 150);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 38);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // DGVEgresos
            // 
            this.DGVEgresos.AllowUserToAddRows = false;
            this.DGVEgresos.AllowUserToDeleteRows = false;
            this.DGVEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEgresos.Location = new System.Drawing.Point(178, 477);
            this.DGVEgresos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DGVEgresos.Name = "DGVEgresos";
            this.DGVEgresos.ReadOnly = true;
            this.DGVEgresos.RowHeadersWidth = 51;
            this.DGVEgresos.RowTemplate.Height = 24;
            this.DGVEgresos.Size = new System.Drawing.Size(537, 218);
            this.DGVEgresos.TabIndex = 6;
            // 
            // btnDescargar
            // 
            this.btnDescargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnDescargar.Location = new System.Drawing.Point(754, 401);
            this.btnDescargar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(100, 65);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Generar informe de Tesoria";
            // 
            // InformeTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(900, 708);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.DGVEgresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.DGVIngresos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(922, 764);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(922, 764);
            this.Name = "InformeTesoreria";
            this.Text = "InformeTesoreria";
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngresos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEgresos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVIngresos;
        private System.Windows.Forms.DateTimePicker dateTimePickerDesde;
        private System.Windows.Forms.DateTimePicker dateTimePickerHasta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGVEgresos;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.Label label3;
    }
}