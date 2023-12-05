namespace arreglarTesis
{
    partial class MiembrosMinisterios
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBoxMini = new System.Windows.Forms.ComboBox();
            this.dgvMiembrosMini = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembrosMini)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(215, 299);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ministerio  Nro:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(281, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // comboBoxMini
            // 
            this.comboBoxMini.FormattingEnabled = true;
            this.comboBoxMini.Location = new System.Drawing.Point(126, 71);
            this.comboBoxMini.Name = "comboBoxMini";
            this.comboBoxMini.Size = new System.Drawing.Size(121, 24);
            this.comboBoxMini.TabIndex = 8;
            // 
            // dgvMiembrosMini
            // 
            this.dgvMiembrosMini.AllowUserToAddRows = false;
            this.dgvMiembrosMini.AllowUserToDeleteRows = false;
            this.dgvMiembrosMini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMiembrosMini.Location = new System.Drawing.Point(28, 120);
            this.dgvMiembrosMini.Name = "dgvMiembrosMini";
            this.dgvMiembrosMini.ReadOnly = true;
            this.dgvMiembrosMini.RowHeadersWidth = 51;
            this.dgvMiembrosMini.RowTemplate.Height = 24;
            this.dgvMiembrosMini.Size = new System.Drawing.Size(430, 150);
            this.dgvMiembrosMini.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Filtrar Miembros por Ministerio";
            // 
            // MiembrosMinisterios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 360);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.comboBoxMini);
            this.Controls.Add(this.dgvMiembrosMini);
            this.Controls.Add(this.label1);
            this.Name = "MiembrosMinisterios";
            this.Text = "MiembrosMinisterios";
            this.Load += new System.EventHandler(this.MiembrosMinisterios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMiembrosMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBoxMini;
        private System.Windows.Forms.DataGridView dgvMiembrosMini;
        private System.Windows.Forms.Label label1;
    }
}