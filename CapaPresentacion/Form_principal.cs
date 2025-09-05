
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
            try
            {
                objCN.RegistrarPelicula(
                        new Pelicula
                        {
                            Codigo = txt_codigo.Text,
                            Nombre = txt_nombre.Text,
                            Duracion = uint.Parse(txt_duracion.Text),
                            Genero = cb_genero.Text,
                            Precio = double.Parse(txt_precioBoleta.Text),
                            Funcion = datepicker_fecha.Value.Add(timepicker_horaFuncion.Value.TimeOfDay)
                        }
                );
            }
            catch (CN_Excepciones.RegistroFallido)
            {
                MessageBox.Show("Error al Guardar la Pelicula");
                return;
            }
            finally
            {
                LimpiarCampos();
            }

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
    }
}
