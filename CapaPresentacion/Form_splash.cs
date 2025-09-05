using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Form_splash : Form
    {
        public Form_splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop(); //Detener el timer
            Form_principal ppal = new Form_principal();
            ppal.Show();
            this.Hide();//Escondo formulario actual
        }
    }
}
