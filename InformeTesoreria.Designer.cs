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
            this.DGVIngresos = new System.Windows.Forms.DataGridView();
            this.dateTimePickerDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHasta = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGVEgresos = new System.Windows.Forms.DataGridView();
            this.btnDescargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVIngresos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEgresos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVIngresos
            // 
            this.DGVIngresos.AllowUserToAddRows = false;
            this.DGVIngresos.AllowUserToDeleteRows = false;
            this.DGVIngresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVIngresos.Location = new System.Drawing.Point(16, 157);
            this.DGVIngresos.Name = "DGVIngresos";
            this.DGVIngresos.ReadOnly = true;
            this.DGVIngresos.RowHeadersWidth = 51;
            this.DGVIngresos.RowTemplate.Height = 24;
            this.DGVIngresos.Size = new System.Drawing.Size(477, 150);
            this.DGVIngresos.TabIndex = 0;
            // 
            // dateTimePickerDesde
            // 
            this.dateTimePickerDesde.Location = new System.Drawing.Point(70, 48);
            this.dateTimePickerDesde.Name = "dateTimePickerDesde";
            this.dateTimePickerDesde.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerDesde.TabIndex = 1;
            // 
            // dateTimePickerHasta
            // 
            this.dateTimePickerHasta.Location = new System.Drawing.Point(70, 76);
            this.dateTimePickerHasta.Name = "dateTimePickerHasta";
            this.dateTimePickerHasta.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerHasta.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(328, 68);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(89, 30);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Hasta:";
            // 
            // DGVEgresos
            // 
            this.DGVEgresos.AllowUserToAddRows = false;
            this.DGVEgresos.AllowUserToDeleteRows = false;
            this.DGVEgresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEgresos.Location = new System.Drawing.Point(12, 395);
            this.DGVEgresos.Name = "DGVEgresos";
            this.DGVEgresos.ReadOnly = true;
            this.DGVEgresos.RowHeadersWidth = 51;
            this.DGVEgresos.RowTemplate.Height = 24;
            this.DGVEgresos.Size = new System.Drawing.Size(477, 150);
            this.DGVEgresos.TabIndex = 6;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(220, 560);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(89, 30);
            this.btnDescargar.TabIndex = 7;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // InformeTesoreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 602);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.DGVEgresos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dateTimePickerHasta);
            this.Controls.Add(this.dateTimePickerDesde);
            this.Controls.Add(this.DGVIngresos);
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
    }
}