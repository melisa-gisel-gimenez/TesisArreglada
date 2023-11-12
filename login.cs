using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;


namespace Iglesia
{
    public partial class LoginJuli : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\juli_\OneDrive\Escritorio\pepe\BaseIglesiaproduccion.mdb";
        private string rol = "";

        public LoginJuli()
        {
            InitializeComponent();
            conexion = new OleDbConnection(cadenaConexion);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciarSesion_MouseEnter(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.White;
        }

        private void btnIniciarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnIniciarSesion.ForeColor = Color.Black;

        }

        private void pbMostrar_Click(object sender, EventArgs e)
        {
            pbOcultar.BringToFront();
            txtPassword.PasswordChar = '\0';
        }

        private void pbOcultar_Click(object sender, EventArgs e)
        {
            pbMostrar.BringToFront();
            txtPassword.PasswordChar = '*';
        }


        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Por favor, introduce tu nombre de usuario y contraseña.");
                return;
            }

            bool areCredentialsValid = VerifyCredentials(username, password);
            if (areCredentialsValid)
            {

                if (rol.Equals("Administrador"))
                {
                    paginaprincipal form = new paginaprincipal();
                    form.Show();
                    this.Hide();
                }

                if (rol.Equals("Tesorero"))
                {
                    PPTesoreria form = new PPTesoreria();
                    form.Show();
                    this.Hide();
                }

                if (rol.Equals("Mentor"))
                {
                    PPmentor form = new PPmentor();
                    form.Show();
                    this.Hide();
                }
                // Aquí puedes abrir la ventana principal de tu aplicación.
            }
            else
            {
                MessageBox.Show("Nombre de usuario o contraseña incorrectos. Por favor, inténtalo de nuevo.");
            }

        }
        private bool VerifyCredentials(string username, string password)
        {
            bool result = false;
            string consulta = "SELECT * FROM usuarios WHERE nombreUsuario = @nombreUsuario AND contraseña = @clave ";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@nombreUsuario", username);
                comando.Parameters.AddWithValue("@clave", password);

                try
                {
                    conexion.Open();
                    OleDbDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        result = true;
                        rol = reader["tipo_usuario"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Los datos proporcionados no son correctos.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                }
                finally
                {
                    conexion.Close();
                }
            }
            return result;
        }

    }
}







