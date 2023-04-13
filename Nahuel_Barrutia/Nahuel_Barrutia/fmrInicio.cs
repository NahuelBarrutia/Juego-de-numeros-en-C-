using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nahuel_Barrutia
{
    public partial class fmrInicio : Form
    {
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            fmrJuego formJuego = fmrJuego.OBTENER_INSTANCIA();
            formJuego.Show();
        }

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            fmrPartidas formPartidas = fmrPartidas.OBTENER_INSTANCIA();
            formPartidas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
