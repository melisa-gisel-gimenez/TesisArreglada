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
    public partial class MiembrosMinisterios : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public MiembrosMinisterios()
        {
            InitializeComponent();
        }

        private void CargarMinisterios()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString)) // Reemplaza cadenaConexion con tu cadena de conexión real
                {
                    string consulta = "SELECT Id_ministerio, nombreMinisterio FROM Ministerios";
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion); 
                    DataTable tablaMinisterios = new DataTable();
                    adaptador.Fill(tablaMinisterios);

                    // Enlazar datos al ComboBox
                    comboBoxMini.DataSource = tablaMinisterios;
                    comboBoxMini.ValueMember = "Id_ministerio";
                    comboBoxMini.DisplayMember = "nombreMinisterio";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar ministerios: " + ex.Message);
            }
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MiembrosMinisterios_Load(object sender, EventArgs e)
        {
            CargarMinisterios();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtén el id_ministerio seleccionado en el ComboBox
                int idMinisterioSeleccionado = Convert.ToInt32(comboBoxMini.SelectedValue);

                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    string consulta = "SELECT id_miembro AS 'Nro Miembro', Nombre, Apellido " +
                                      "FROM Miembros " +
                                      "WHERE id_ministerio = @IdMinisterio";

                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    adaptador.SelectCommand.Parameters.AddWithValue("@IdMinisterio", idMinisterioSeleccionado);

                    DataTable tablaMiembros = new DataTable();
                    adaptador.Fill(tablaMiembros);

                    // Enlazar datos al DataGridView dgvmiembros
                    dgvMiembrosMini.DataSource = tablaMiembros;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar miembros: " + ex.Message);
            }
        }

    }
}
