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
    public partial class ListaMiembros : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        private OleDbDataAdapter adaptador;
        private DataSet dataSet;
        public ListaMiembros()
        {
            InitializeComponent();
            // Asegúrate de tener la conexión a la base de datos configurada correctamente
            //conexion = new OleDbConnection("@\"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\MELIS\\Documents\\Baseiglesiaproduccion.mdb\";");
            adaptador = new OleDbDataAdapter();
            dataSet = new DataSet();
        }  
            

            private void botonBuscar_Click(object sender, EventArgs e)
            {
                string dniABuscar = textBoxDNI.Text.Trim();

            if (!string.IsNullOrEmpty(dniABuscar))
            {
                string consulta = "SELECT * FROM miembros WHERE DNI = @DNI";

                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    {
                        comando.Parameters.AddWithValue("@DNI", dniABuscar);

                        try
                        {
                            // Limpiar el DataSet antes de llenarlo
                            dataSet.Clear();

                            adaptador.SelectCommand = comando;
                            adaptador.Fill(dataSet, "miembros");

                            if (dataSet.Tables["miembros"].Rows.Count > 0)
                            {
                                // Se encontraron registros, mostrar en el DataGridView
                                DGVMiembros.DataSource = dataSet.Tables["miembros"];
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún registro con el DNI proporcionado.");
                                // Limpiar el DataGridView
                                DGVMiembros.DataSource = null;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un DNI válido.");
            }
            }
          

        private void ListaMiembros_Load(object sender, EventArgs e)
        {

        }

        
    }
    
}
