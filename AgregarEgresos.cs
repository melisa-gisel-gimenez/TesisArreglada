﻿using System;
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
    public partial class AgregarEgresos : Form
    {
        //conexion conexionDB = new conexion();       

        int idTipoEgreso;
        private OleDbConnection conexion;
        private string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\MELIS\Documents\Baseiglesiaproduccion.mdb";

        private Dictionary<string, int> tiposEgresoDictionary = new Dictionary<string, int>();


        public AgregarEgresos()
        {
            InitializeComponent();

            CargarDatosComboboxEgresos();
        }

        private void button1Guardar_Click(object sender, EventArgs e)
        {

            {
                GuardarBD();

            }

        }


        private void CargarDatosComboboxEgresos()
        {
            string consulta = "SELECT Id_tipoEgreso, tipo_Egreso FROM TipoEgreso";
            using (OleDbConnection conexion = new OleDbConnection(connectionString))
            {
                using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                {
                    try
                    {
                        conexion.Open();
                        OleDbDataReader reader = comando.ExecuteReader();

                        while (reader.Read())
                        {
                            int idTipoEgreso = Convert.ToInt32(reader["Id_tipoEgreso"]);
                            string tipoEgreso = reader["tipo_Egreso"].ToString();
                            comboBox1TipoEgreso.Items.Add(tipoEgreso);
                            tiposEgresoDictionary.Add(tipoEgreso, idTipoEgreso); // Guarda el Id_tipoEgreso en el diccionario
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar los datos: " + ex.Message);
                    }
                    finally
                    {
                        if (conexion.State == ConnectionState.Open)
                        {
                            conexion.Close();
                        }
                    }
                }
            }
        }

        private void GuardarBD()
        {
            if ((txtMONTO.Text == "" || comboBox1TipoEgreso.Text == "" || txtDetalle.Text == ""))
            {
                MessageBox.Show("Los campos son obligatorios. Por favor completelos");
            }
            else
            {
                //DateTime fechaAlta = DateTime.Now;

                OleDbConnection cn = new OleDbConnection(connectionString);

                cn.Open();
                String consulta = "insert into Egresos ( Id_tipoEgreso, monto, detalle, fecha) values ('" + idTipoEgreso + "', '" + int.Parse(txtMONTO.Text) + "', " + " '" + txtDetalle.Text + "', '" + dateTimePicker1Fecha.Value + "');";
                OleDbCommand comando1 = new OleDbCommand(consulta, cn);


                int cantidad = comando1.ExecuteNonQuery();


                if (cantidad < 1)
                {
                    MessageBox.Show("Ocurrió un problema");
                }
                else
                {
                    MessageBox.Show("Se guardó con éxito!!!");
                }
            }

        }

        private void button3Limpiar_Click(object sender, EventArgs e)
        {
            comboBox1TipoEgreso.Text = "";
            txtMONTO.Text = "";

            txtDetalle.Text = "";
            dateTimePicker1Fecha.Text = "";

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tipoEgresoSeleccionado = comboBox1TipoEgreso.SelectedItem.ToString();
            idTipoEgreso = tiposEgresoDictionary[tipoEgresoSeleccionado];
         // MessageBox.Show($"El Id_tipoEgreso seleccionado es: {idTipoEgreso}");

        }
        private void MostrarTipoEgreso(string TipoIngreso)
        {
            string consulta = "SELECT Id_tipoEgreso FROM TipoEgreso WHERE Id_tipoEgreso = @id_tipoEgreso";

            using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
            {
                comando.Parameters.AddWithValue("@id_tipoEgreso", TipoIngreso);

                try
                {
                    conexion.Open();
                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        //txtTipoEgreso.Text = resultado.ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener el ID del Tipo Egreso: " + ex.Message);
                }
                finally
                {
                    if (conexion.State == ConnectionState.Open)
                    {
                        conexion.Close();
                    }
                }
            }
        }

        private void txtMONTO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica si la tecla presionada no es un dígito numérico o una tecla de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                // Si no es un número o una tecla de control, ignora la tecla presionada
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}