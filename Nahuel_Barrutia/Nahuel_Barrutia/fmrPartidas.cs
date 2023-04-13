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
    public partial class fmrPartidas : Form
    {
        private static fmrPartidas instancia;
        public static fmrPartidas OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new fmrPartidas();
            if (instancia.IsDisposed)
                instancia = new fmrPartidas();

            return instancia;
        }

        MODELO.JUEGO oJUEGO;

        public fmrPartidas()
        {
            InitializeComponent();
            oJUEGO = MODELO.JUEGO.OBTENER_INSTANCIA();
            dgvPartidas.DataSource = oJUEGO.PARTIDAS;
        }



        private void btnReiniciar_Click(object sender, EventArgs e)
        {
            dgvPartidas.DataSource = null;
            dgvPartidas.DataSource = oJUEGO.PARTIDAS;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvPartidas.DataSource = oJUEGO.PARTIDAS;
            dgvPartidas.DataSource = oJUEGO.OBTENER_PARTIDAS(cmbTipo.Text.Trim());
        }
    }
}
