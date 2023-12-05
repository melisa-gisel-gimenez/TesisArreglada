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
    public partial class ListaMiembrosCelula : Form
    {
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public ListaMiembrosCelula()
        {
            InitializeComponent();
        }

        private void ListaMiembrosCelula_Load(object sender, EventArgs e)
        {
            CargarIdCelulaEnComboBox();
        }

        private void CargarIdCelulaEnComboBox()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(connectionString))
                {
                    // Consulta para obtener los id_celula desde la tabla Celula
                    string consulta = "SELECT id_celula FROM Celula";

                    // Crear el adaptador de datos y el DataSet
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(consulta, conexion);
                    DataSet dataSet = new DataSet();

                    // Llenar el DataSet con los datos de la tabla Celula
                    conexion.Open();
                    adaptador.Fill(dataSet, "Celula");
                    conexion.Close();

                    // Enlazar los datos al ComboBox
                    comboIdCelula.DataSource = dataSet.Tables["Celula"];
                    comboIdCelula.DisplayMember = "id_celula";
                    comboIdCelula.ValueMember = "id_celula";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los id_celula: " + ex.Message);
            }
        }
    }
}
}
