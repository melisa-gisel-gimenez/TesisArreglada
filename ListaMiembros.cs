
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System.IO;
using iText.Layout.Borders;
using iText.Layout.Properties;
using ClosedXML.Excel;
using System.Diagnostics;
using System.Collections.Generic;





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
            if (textBoxDNI.Text.Length < 8 || textBoxDNI.Text == "")
            {
                MessageBox.Show("El DNI debe tener 8 dígitos. Por favor revise los datos ingresados.");
            }
            else
            {

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
        }

        private void buttonFiltrar_Click_1(object sender, EventArgs e)
        {
            // Limpiar el DataGridView
            DGVMiembros.DataSource = null;

            // Obtener el estado de los CheckBox
            bool habilitado = checkBoxHabilitado.Checked;
            bool inhabilitado = checkBoxInhabilitado.Checked;

            if (checkBoxHabilitado.Checked == false && checkBoxInhabilitado.Checked == false)
            {
                MessageBox.Show("Debe seleccionar una opción para filtrar. Por favor haga lick en una opción (habilitados, inahibilados o ambas.");
            }

            else
            {

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
        }


        private void buttonDescargar_Click(object sender, EventArgs e)
        {
            if (DGVMiembros.DataSource == null || DGVMiembros.Rows.Count == 0)
            {
                MessageBox.Show("Por favor, busca un miembro por DNI o selecciona algún filtro antes de descargar. La tabla está vacía.");
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivos Excel|*.xlsx";
            saveFileDialog.Title = "Guardar como Excel";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                // Crear un libro de Excel
                using (var workbook = new XLWorkbook())
                {
                    // Agregar una hoja al libro
                    var worksheet = workbook.Worksheets.Add("Miembros");

                    // Agregar título y fecha
                    worksheet.Cell("A1").Value = "Reporte de Miembros";
                    worksheet.Cell("A2").Value = "Fecha de Descarga: " + DateTime.Now.ToString();

                    // Agregar contenido del DataGridView al Excel en formato de tabla
                    DataTable dataTable = dataSet.Tables["miembros"];

                    // Configurar encabezados de columna
                    for (int col = 1; col <= dataTable.Columns.Count; col++)
                    {
                        worksheet.Cell(4, col).Value = dataTable.Columns[col - 1].ColumnName;
                    }

                    // Agregar datos del DataGridView a la tabla
                    for (int row = 1; row <= dataTable.Rows.Count; row++)
                    {
                        for (int col = 1; col <= dataTable.Columns.Count; col++)
                        {
                            worksheet.Cell(row + 4, col).Value = dataTable.Rows[row - 1][col - 1].ToString();
                        }
                    }

                    // Guardar el libro de Excel
                    workbook.SaveAs(saveFileDialog.FileName);
                }

                MessageBox.Show("Archivo Excel generado con éxito.");

                // Obtener la ruta completa del archivo guardado
                string filePath = Path.GetFullPath(saveFileDialog.FileName);

                // Abrir automáticamente el archivo excel después de guardarlo
                try
                {
                    Process.Start(filePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al abrir el archivo: " + ex.Message);
                }

            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void textBoxDNI_TextChanged(object sender, EventArgs e)
        {
            if (textBoxDNI.Text.Length > 8)
            {
                // Si es mayor a 8, recorta el texto para que solo tenga 8 caracteres
                //txtDNI.Text = txtDNI.Text.Substring(0, 8);
                // Coloca el cursor al final del texto
                textBoxDNI.SelectionStart = textBoxDNI.Text.Length;
                MessageBox.Show("Solo puede ingresar 8 números. Por favor, verifique el DNI ingresado");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBoxDNI.Text = "";
        }

        private void btnLimpiarCheck_Click(object sender, EventArgs e)
        {
            checkBoxHabilitado.Checked = false;
            checkBoxInhabilitado.Checked = false;
        }
    }
}
        /*
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

                        // Agregar título y fecha
                        document.Add(new Paragraph("Reporte de Miembros"));
                        document.Add(new Paragraph("Fecha de Descarga: " + DateTime.Now.ToString()));
                        document.Add(new Paragraph("\n"));  // Espacio en blanco

                        // Agregar contenido del DataGridView al PDF en formato de tabla
                        DataTable dataTable = dataSet.Tables["miembros"];
                        Table table = new Table(dataTable.Columns.Count);

                        // Configurar ancho de las columnas de la tabla
                        foreach (DataColumn col in dataTable.Columns)
                        {
                            table.AddCell(new Cell().Add(new Paragraph(col.ColumnName)).SetBorder(Border.NO_BORDER));
                        }

                        foreach (DataRow row in dataTable.Rows)
                        {
                            foreach (DataColumn col in dataTable.Columns)
                            {
                                table.AddCell(new Cell().Add(new Paragraph(row[col].ToString())).SetBorder(Border.NO_BORDER));
                            }
                        }

                        // Configurar que la tabla se mantenga junta en una página
                        table.SetKeepTogether(true);

                        // Agregar la tabla al documento
                        document.Add(table);
                    }
                }

                MessageBox.Show("Archivo PDF generado con éxito.");
            }
        }
        */
    

                

                
            
        
    



    

        

    

