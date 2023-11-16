using iTextSharp.text.pdf;
using iTextSharp.text;
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

namespace Iglesia
{
    public partial class Modificar_Ingresos : Form
    {
        private OleDbConnection conn;
        private OleDbDataAdapter daIngresos;
        private OleDbDataAdapter daEgresos;
        private DataTable dtIngresos;
        private DataTable dtEgresos;

        public Modificar_Ingresos()
        {
            InitializeComponent();

            conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\BaseIglesiaproduccion.mdb;");
            daIngresos = new OleDbDataAdapter("SELECT * FROM ingresos", conn);
            daEgresos = new OleDbDataAdapter("SELECT * FROM egresos", conn);
            dtIngresos = new DataTable();
            dtEgresos = new DataTable();

            daIngresos.Fill(dtIngresos);
            daEgresos.Fill(dtEgresos);

            DGVReporteI.DataSource = dtIngresos;
            DGVReporteE2.DataSource = dtEgresos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);
            //PdfWriter writer = PdfWriter.GetInstance("informe.pdf");
            doc.Open();

            Paragraph title = new Paragraph("Informe de Ingresos y Egresos");
            title.Alignment = Element.ALIGN_CENTER;
            doc.Add(title);

            Paragraph ingresosTitle = new Paragraph("Ingresos");
            ingresosTitle.Alignment = Element.ALIGN_CENTER;
            doc.Add(ingresosTitle);

            PdfPTable tableIngresos = new PdfPTable(dtIngresos.Columns.Count);

            foreach (DataColumn column in dtIngresos.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                //cell.BackgroundColor = Color.LightGray;
                tableIngresos.AddCell(cell);
            }

            foreach (DataRow row in dtIngresos.Rows)
            {
                for (int i = 0; i < dtIngresos.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(row[i].ToString()));
                    tableIngresos.AddCell(cell);
                }
            }

            doc.Add(tableIngresos);

            Paragraph egresosTitle = new Paragraph("Egresos");
            egresosTitle.Alignment = Element.ALIGN_CENTER;
            doc.Add(egresosTitle);

            PdfPTable tableEgresos = new PdfPTable(dtEgresos.Columns.Count);

            foreach (DataColumn column in dtEgresos.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.ColumnName));
                //cell.BackgroundColor = Color.LightGray;
                tableEgresos.AddCell(cell);
            }

            foreach (DataRow row in dtEgresos.Rows)
            {
                for (int i = 0; i < dtEgresos.Columns.Count; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(row[i].ToString()));
                    tableEgresos.AddCell(cell);
                }
            }

            doc.Add(tableEgresos);

            doc.Close();
        }

        private void Informes_Load(object sender, EventArgs e)
        {

        }

        private void DGVReporteI_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cargarDGVReporteI();
            //ConfigurarDGVReporteI();


        }
        private void cargarDGVReporteI()
        {
            string consulta = "SELECT columna1, columna2, columna3 FROM Ingresos";

            using (OleDbCommand comando = new OleDbCommand(consulta, conn))
            {
                try
                {
                    conn.Open();
                    DataTable dataTable = new DataTable();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    DGVReporteI.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void DGVReporteE2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            cargarDGVReporteE();
            // ConfigurarDGVReporteE();


        }
        private void cargarDGVReporteE()
        {
            string consulta = "SELECT columna1, columna2, columna3 FROM Egresos";

            using (OleDbCommand comando = new OleDbCommand(consulta, conn))
            {
                try
                {
                    conn.Open();
                    DataTable dataTable = new DataTable();
                    OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                    adaptador.Fill(dataTable);
                    DGVReporteE2.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al ejecutar la consulta: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
