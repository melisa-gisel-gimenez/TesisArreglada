
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;


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

        private void buttonFiltrar_Click_1(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            DGVMiembros.DataSource = null;

            // Obtener el estado de los CheckBox
            bool habilitado = checkBoxHabilitado.Checked;
            bool inhabilitado = checkBoxInhabilitado.Checked;

            string consulta = "SELECT * FROM miembros";

            // Aplicar el filtro según las opciones seleccionadas
            if (habilitado && !inhabilitado)
            {
                // Mostrar solo los registros con inhabilitado = false
                consulta += " WHERE inhabilitado = false";
            }
            else if (!habilitado && inhabilitado)
            {
                // Mostrar solo los registros con inhabilitado = true
                consulta += " WHERE inhabilitado = true";
            }
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
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
                            MessageBox.Show("No se encontraron registros según los filtros seleccionados.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al buscar en la base de datos: " + ex.Message);
                    }
                }
            }
        }

        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos PDF|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // Crear un documento PDF
                using (PdfWriter writer = new PdfWriter(saveFileDialog.FileName))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Agregar contenido del DataGridView al PDF
                        DataTable dataTable = dataSet.Tables["miembros"];
                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn col in dataTable.Columns)
                            {
                                document.Add(new Paragraph(col.ColumnName + ": " + row[col].ToString()));
                            }
                            document.Add(new Paragraph("-----------------------------"));
                        }
                    }
                }

                MessageBox.Show("Archivo PDF generado con éxito.");
            }
        }
    }


}
    

        

    

