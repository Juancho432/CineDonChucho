
using System.Windows.Forms;
using System;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Form_principal : Form
    {

        private readonly CN_Cine objCN = new CN_Cine();

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
                        Precio = decimal.Parse(txt_precioBoleta.Text)
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
            if (checkBox_editar.Checked == true)
            {
                objCN.ActualizarPelicula(txt_busqueda.Text, txt_nombre_buscado.Text,
                                         txt_duracion_buscada.Text, comboBox_genero_buscado.Text,
                                         txt_precioBoleta_buscado.Text);
            }
            else
            {
                MessageBox.Show("No se ha activado la edicion");
            }
        }
    }
}
