using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arreglarTesis
{
    public partial class ListaMentoreados : Form
    {

        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public ListaMentoreados()
        {
            InitializeComponent();
        }

        private void ListaMentoreados_Load(object sender, EventArgs e)
        {

        }

        private void txtDNIBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDNIBuscar_TextChanged_1(object sender, EventArgs e)
        {
            // Verifica si la longitud del texto en el TextBox es mayor a 8
            if (txtDNIBuscar.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                txtDNIBuscar.SelectionStart = txtDNIBuscar.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }


        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string dniABuscar = txtDNIBuscar.Text.Trim();
            if (txtDNIBuscar.Text.Length < 8 || txtDNIBuscar.Text == "")
            {
                MessageBox.Show("El DNI debe tener 8 dígitos. Por favor revise los datos ingresados.");
            }
            else
            {

                if (!string.IsNullOrEmpty(dniABuscar))
                {
                    using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                    {
                        conexion.Open();

                        string consulta2 = "SELECT * FROM mentores WHERE DNI_MENTOR = @DNI";
                        using (OleDbCommand comando2 = new OleDbCommand(consulta2, conexion))
                        {
                            comando2.Parameters.AddWithValue("@DNI", dniABuscar);
                            try
                            {
                                OleDbDataReader reader2 = comando2.ExecuteReader();
                                if (reader2.Read())
                                {
                                    txtNombre.Text = reader2["NOMBRE"].ToString();
                                    txtApellido.Text = reader2["APELLIDO"].ToString();
                                    txtIdMentor.Text = reader2["id_mentor"].ToString();
                                              
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna persona registrada con el DNI proporcionado.");
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                            }
                        }
                    }
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            int idMentor = Convert.ToInt32(txtIdMentor.Text);

            
            // Realiza la búsqueda en la tabla Miembros según el id_celula
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    // Consulta para obtener los registros de Miembros con el id_celula específico
                    string consulta = "SELECT id_miembro AS 'Nro Miembro', Nombre, Apellido " +
                                      "FROM Miembros " +
                                      "WHERE id_mentor = @id_mentor";

                    // Crear el adaptador de datos y el DataSet
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@id_mentor", idMentor);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla Miembros
                    conexion.Open();
                    adaptador.Fill(dataSet, "Miembros");
                    conexion.Close();

                    // Enlazar los datos al DataGridView dgvmiembros
                    dgvMentoreados.DataSource = dataSet.Tables["Miembros"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar en la tabla Miembros: " + ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtIdMentor.Text = "";
        }
    }
}
