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

namespace arreglarTesis
{
    public partial class InformeTesoreria : Form
    {
        private OleDbConnection conexion;
        private string cadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";
        public InformeTesoreria()
        {
            InitializeComponent();
        }
        private void CargarDatosIngresos(DateTime fechaDesde, DateTime fechaHasta)
        {
            string consulta = "SELECT * FROM Ingresos WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    try
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);
                        DGVIngresos.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
        }

        private void CargarDatosEgresos(DateTime fechaDesde, DateTime fechaHasta)
        {
            string consulta = "SELECT * FROM Egresos WHERE Fecha BETWEEN @FechaDesde AND @FechaHasta";

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@FechaDesde", fechaDesde);
                    comando.Parameters.AddWithValue("@FechaHasta", fechaHasta);

                    try
                    {
                        OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                        DataTable dataTable = new DataTable();
                        adaptador.Fill(dataTable);
                        DGVEgresos.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaDesde = dateTimePickerDesde.Value;
            DateTime fechaHasta = dateTimePickerHasta.Value;

            // Asegúrate de que la fecha hasta sea mayor o igual a la fecha desde
            if (fechaHasta < fechaDesde)
            {
                MessageBox.Show("La fecha hasta debe ser mayor o igual a la fecha desde.");
                return;
            }

            CargarDatosIngresos(fechaDesde, fechaHasta);
            CargarDatosEgresos(fechaDesde, fechaHasta);
        }

        

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            DescargarInformePDF();
        }

        private void DescargarInformePDF()
        {
            string fechaDescarga = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // Configurar SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Archivos PDF|*.pdf",
                Title = "Guardar Informe de Tesorería",
                FileName = "InformeTesoreria_" + fechaDescarga.Replace(":", "").Replace(" ", "_") + ".pdf"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta y el nombre de archivo seleccionados
                string filePath = saveFileDialog.FileName;

                using (PdfWriter writer = new PdfWriter(filePath))
                {
                    using (PdfDocument pdf = new PdfDocument(writer))
                    {
                        Document document = new Document(pdf);

                        // Agregar título e información de fecha
                        document.Add(new Paragraph("Informe de Tesorería"));
                        document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                        // Agregar tabla para Ingresos
                        document.Add(new Paragraph("Ingresos"));
                        document.Add(DGVToTable(DGVIngresos));

                        // Agregar tabla para Egresos
                        document.Add(new Paragraph("Egresos"));
                        document.Add(DGVToTable(DGVEgresos));
                    }
                }

                MessageBox.Show("Informe generado y guardado como '" + Path.GetFileName(filePath) + "'");
            }
        }


        /*
        private void DescargarInformePDF()
        {
            string fechaDescarga = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            using (PdfWriter writer = new PdfWriter("InformeTesoreria.pdf"))
            {
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);

                    // Agregar título e información de fecha
                    document.Add(new Paragraph("Informe de Tesorería"));
                    document.Add(new Paragraph("Fecha de Descarga: " + fechaDescarga));

                    // Agregar tabla para Ingresos
                    document.Add(new Paragraph("Ingresos"));
                    document.Add(DGVToTable(DGVIngresos));

                    // Agregar tabla para Egresos
                    document.Add(new Paragraph("Egresos"));
                    document.Add(DGVToTable(DGVEgresos));
                }
            }

            MessageBox.Show("Informe generado y guardado como 'InformeTesoreria.pdf'");
        }
        */

        private Table DGVToTable(DataGridView dgv)
        {
            Table table = new Table(dgv.ColumnCount);

            // Agregar encabezados de columna
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                table.AddHeaderCell(new Cell().Add(new Paragraph(column.HeaderText)));
            }

            // Agregar datos
            foreach (DataGridViewRow row in dgv.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    table.AddCell(new Cell().Add(new Paragraph(cell.Value.ToString())));
                }
            }

            return table;
        }
    }
}
