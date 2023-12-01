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
using arreglarTesis;

namespace Iglesia
{
    public partial class LoginJuli : Form
    {
        private OleDbConnection conexion;
        //private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\juli_\OneDrive\Escritorio\pepe\BaseIglesiaproduccion.mdb";
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
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

            bool areCredentialsValid = VerifyCredentials(username, EncriptarContraseña(password));
            if (areCredentialsValid)
            {
                /* CODIGO JULI
                 if (rol.Equals("Administrador"))
                 {
                     PPAdministracion form = new PPAdministracion();
                     form.Show();
                     this.Hide();
                 }

                 if (rol.Equals("Tesorero"))
                 {
                     PPTesoreria form = new PPTesoreria();
                     form.Show();
                     this.Close();
                 }

                 if (rol.Equals("Mentor"))
                 {
                     PPmentor form = new PPmentor();
                     form.Show();
                     this.Hide();
                 }

                 if (rol.Equals("Pastor"))
                 {
                     paginaprincipal form = new paginaprincipal();
                     form.Show();
                     this.Hide();
                 }
                 // Aquí puedes abrir la ventana principal de tu aplicación.
                */
                if (rol.Equals("Administrador"))
                {
                    PPAdministracion form = new PPAdministracion();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Tesorero"))
                {
                    PPTesoreria form = new PPTesoreria();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Mentor"))
                {
                    PPmentor form = new PPmentor();
                    form.Show();
                    this.Hide();
                }
                else if (rol.Equals("Pastor"))
                {
                    paginaprincipal form = new paginaprincipal();
                    form.Show();
                    this.Hide();
                }                               
                
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

        private string EncriptarContraseña(string contraseña)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                // Convierte la contraseña a bytes
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);

                // Calcula el hash SHA256
                byte[] hashBytes = sha256.ComputeHash(bytes);

                // Convierte el hash a una cadena hexadecimal
                StringBuilder builder = new StringBuilder();
                foreach (byte b in hashBytes)
                {
                    builder.Append(b.ToString("x2"));
                }

                return builder.ToString();
            }
        }

        /*  codigo anterior de juli
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
        */

    }
}

//codigo que se puede reutilizar para alguna parte del login
/*
 * private void btnConfirm_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtNombreUsuario.Text;
            string contraseña = txtContraseña.Text;

            // Verificar si el usuario ya existe en la base de datos
            if (!UsuarioExiste(nombreUsuario))
            {
                // Si el usuario no existe, agregarlo a la base de datos
                
                MessageBox.Show("Datos incorrectos.");
            }
            else
            {
                // Verificar si el usuario ya existe en la base de datos
                if (UsuarioExiste(nombreUsuario))
                {
                    string contraseñaAlmacenada = ObtenerContraseñaAlmacenada(nombreUsuario);

                    // Desencriptar la contraseña almacenada
                    string contraseñaDesencriptada = Decrypt(contraseñaAlmacenada);

                    // Verificar si la contraseña ingresada coincide con la contraseña almacenada
                    if (contraseña == contraseñaDesencriptada)
                    {
                        MessageBox.Show("Ingresó con éxito.");
                        // Aquí podrías abrir otra ventana o realizar otras acciones después del inicio de sesión exitoso
                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta.");
                    }
                }
            }
        }

        private string ObtenerContraseñaAlmacenada(string nombreUsuario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT contraseña FROM usuarios WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    return Convert.ToString(command.ExecuteScalar());
                }
            }
        }

        private bool UsuarioExiste(string nombreUsuario)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM usuarios WHERE nombre = @nombre";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        private void AgregarUsuario(string nombreUsuario, string contraseña)
        {
// este metodo podria usarse para guardar la nueva contraseña q elige la persona
            string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE usuarios set contraseña=@contraseña where NombreUsuario=@nombre;";
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Encriptar la contraseña antes de almacenarla en la base de datos
                    string contraseñaEncriptada = Encrypt(contraseña);
                    //command.Parameters.AddWithValue("@nombre", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", contraseñaEncriptada);
                    command.ExecuteNonQuery();
                }
            }
        }

        private string Encrypt(string password)
        {
            // Encode password
            byte[] passBytes = ASCIIEncoding.ASCII.GetBytes(password);
            return Convert.ToBase64String(passBytes);
        }

        private string Decrypt(string encryptedPassword)
        {
            try
            {
                byte[] passBytes = Convert.FromBase64String(encryptedPassword);
                return ASCIIEncoding.ASCII.GetString(passBytes);
            }
            catch (Exception ex)
            {
                // Manejo de errores, por ejemplo, si la cadena no está en formato Base64 válido
                return string.Empty; // O un valor predeterminado
            }
        }
    }
*/





