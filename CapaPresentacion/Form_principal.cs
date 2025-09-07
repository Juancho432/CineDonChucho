
using System.Windows.Forms;
using System;
using System.Data;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form_principal : Form
    {

        private readonly CN_Cine objCN = new CN_Cine();

        private DataTable listadoPelicula;

        public Form_principal()
        {
            InitializeComponent();
        }

        private void Form_principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Button_guardar_Click(object sender, EventArgs e)
        {
            objCN.RegistrarPelicula(
                    new Pelicula
                    {
                        Codigo = txt_codigo.Text,
                        Nombre = txt_nombre.Text,
                        Duracion = uint.Parse(txt_duracion.Text),
                        Genero = cb_genero.Text,
                        Precio = decimal.Parse(txt_precioBoleta.Text),
                        Fecha = datepicker_fecha.Value.Add(timepicker_horaFuncion.Value.TimeOfDay)
                    }
            );

            MessageBox.Show("Pelicula Guardada con Exito");
        }

        private void Button_limpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txt_codigo.Clear();
            txt_nombre.Clear();
            txt_duracion.Clear();
            cb_genero.Text = string.Empty;
            txt_precioBoleta.Clear();
            datepicker_fecha.Text = string.Empty;
            timepicker_horaFuncion.Text = string.Empty;
        }

        private void Txt_busqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                Pelicula result = objCN.BuscarPelicula(txt_busqueda.Text);
                txt_nombre_buscado.Text = result.Nombre;
                txt_duracion_buscada.Text = result.Duracion.ToString();
                comboBox_genero_buscado.Text = result.Genero;
                txt_precioBoleta_buscado.Text = result.Precio.ToString();
                timepicker_fecha_buscado.Value = result.Fecha.Date;
                timepicker_hora_buscado.Value = result.Fecha.Date;
            }
        }

        private void CheckBox_editar_CheckedChanged(object sender, EventArgs e)
        {
            txt_nombre_buscado.Enabled = !txt_nombre_buscado.Enabled;
            txt_duracion_buscada.Enabled = !txt_duracion_buscada.Enabled;
            comboBox_genero_buscado.Enabled = !comboBox_genero_buscado.Enabled;
            txt_precioBoleta_buscado.Enabled = !txt_precioBoleta_buscado.Enabled;
            timepicker_fecha_buscado.Enabled = !timepicker_fecha_buscado.Enabled;
            timepicker_hora_buscado.Enabled = !timepicker_hora_buscado.Enabled;
        }

        private void Txt_codigoListar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dgv_listado.DataSource = null;
                dgv_listado.DataSource = objCN.ListarPeliculas();
            }
        }

        private void Button_guardar_edicion_Click(object sender, EventArgs e)
        {
            if (checkBox_editar.Checked)
            {
                if (int.TryParse(txt_busqueda.Text, out int codigo) &&
                    int.TryParse(txt_duracion_buscada.Text, out int duracion) &&
                    decimal.TryParse(txt_precioBoleta_buscado.Text, out decimal precio))
                {
                    objCN.ActualizarPelicula(
                        codigo,
                        txt_nombre_buscado.Text,
                        duracion,
                        comboBox_genero_buscado.Text,
                        precio,
                        timepicker_fecha_buscado.Value.Add(timepicker_hora_buscado.Value.TimeOfDay)
                    );

                    MessageBox.Show("Película actualizada con éxito");
                }
                else
                {
                    MessageBox.Show("Error: Verifica los campos numéricos (Código, Duración, Precio).");
                }
            }
            else
            {
                MessageBox.Show("No se ha activado la edición");
            }
        }

        private void Button_limpiarB_Click(object sender, EventArgs e)
        {
            txt_busqueda.Text = string.Empty;
            txt_nombre_buscado.Text = string.Empty;
            txt_duracion_buscada.Text = string.Empty;
            comboBox_genero_buscado.Text = string.Empty;
            txt_precioBoleta_buscado.Text = string.Empty;
            timepicker_fecha_buscado.Value = DateTime.Today;
            timepicker_hora_buscado.Value = DateTime.Today;
        }

        private void Form_principal_Load(object sender, EventArgs e)
        {
            listadoPelicula = objCN.ListarPeliculas();
            foreach (DataRow fila in listadoPelicula.Rows)
            {
                cb_pelicula_opciones.Items.Add(fila["Nombre"]?.ToString());
            }
        }

        private void Cb_N_boletas_ValueChanged(object sender, EventArgs e)
        {
            decimal precio = decimal.Parse(
                listadoPelicula.Rows[cb_pelicula_opciones.SelectedIndex]["PrecioBoleta"].ToString());
            lbl_precio_unitario.Text = precio.ToString();
            lbl_precio_total.Text = (precio * cb_N_boletas.Value).ToString();
        }

        private void Button_confirmar_funcion_Click(object sender, EventArgs e)
        {
            DataRow venta = listadoPelicula.Rows[cb_pelicula_opciones.SelectedIndex];
            objCN.VenderBoletas(
                new Pelicula
                {
                    Codigo = venta["Codigo"].ToString(),
                    Nombre = venta["Nombre"].ToString(),
                    Duracion = uint.Parse(venta["Duracion"].ToString()),
                    Genero = venta["Genero"].ToString(),
                    Precio = decimal.Parse(venta["PrecioBoleta"].ToString()),
                    Fecha = DateTime.Parse(venta["FechaHoraFuncion"].ToString())
                }, int.Parse(cb_N_boletas.Value.ToString()));
        }
    }
}
