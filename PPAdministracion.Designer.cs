﻿
namespace arreglarTesis
{
    partial class PPAdministracion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PPAdministracion));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AdministracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AdministracionToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 36);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AdministracionToolStripMenuItem
            // 
            this.AdministracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPersonasToolStripMenuItem,
            this.modificarPersonasToolStripMenuItem});
            this.AdministracionToolStripMenuItem.Name = "AdministracionToolStripMenuItem";
            this.AdministracionToolStripMenuItem.Size = new System.Drawing.Size(147, 32);
            this.AdministracionToolStripMenuItem.Text = "Administracion";
            this.AdministracionToolStripMenuItem.Click += new System.EventHandler(this.mentoresToolStripMenuItem_Click);
            // 
            // agregarPersonasToolStripMenuItem
            // 
            this.agregarPersonasToolStripMenuItem.Name = "agregarPersonasToolStripMenuItem";
            this.agregarPersonasToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.agregarPersonasToolStripMenuItem.Text = "Alta de miembros";
            this.agregarPersonasToolStripMenuItem.Click += new System.EventHandler(this.agregarPersonasToolStripMenuItem_Click);
            // 
            // modificarPersonasToolStripMenuItem
            // 
            this.modificarPersonasToolStripMenuItem.Name = "modificarPersonasToolStripMenuItem";
            this.modificarPersonasToolStripMenuItem.Size = new System.Drawing.Size(327, 34);
            this.modificarPersonasToolStripMenuItem.Text = "Modificacion de miembros";
            this.modificarPersonasToolStripMenuItem.Click += new System.EventHandler(this.modificarPersonasToolStripMenuItem_Click_1);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // PPAdministracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "PPAdministracion";
            this.Text = "PPAdministracion";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AdministracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}