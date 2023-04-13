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
    public partial class fmrJuego : Form
    {
        private static fmrJuego instancia;
        public static fmrJuego OBTENER_INSTANCIA()
        {
            if (instancia == null)
                instancia = new fmrJuego();
            if (instancia.IsDisposed)
                instancia = new fmrJuego();

            return instancia;
        }
        MODELO.JUEGO oJUEGO;
        MODELO.PARTIDA oPARTIDA;

        public fmrJuego()
        {
            InitializeComponent();
            oJUEGO = MODELO.JUEGO.OBTENER_INSTANCIA(); //Obtengo la instancia del juego en ejecucion

        }
        private void habilitarJuego()
        {
            gbTipo.Enabled = false;
            gbJuego.Enabled = true;
            txtNumero.Clear();
            lblCreditos.Text = null;
            lblIntentos.Text = null;
        }

        private void nuevaPartida()
        {
            gbTipo.Enabled = true;
            gbJuego.Enabled = false;
            rbAyuda.Checked = false;
            rbNormal.Checked = false;
            txtNumero.Clear();

        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            if (rbNormal.Checked)
            {
                oPARTIDA = new MODELO.PARTIDANORMAL(); //Creo una instancia de PARTIDANORMAL
                habilitarJuego();
            }
            else if (rbAyuda.Checked)
            {
                oPARTIDA = new MODELO.PARTIDACONAYUDA(); //Creo una instancia de PARTIDACONAYUDA
                habilitarJuego();
            }
            else
            {
                MessageBox.Show("Debe seleccionar el tipo de partidda", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void btnProbar_Click(object sender, EventArgs e)
        {
 
            int numero;

            if (!int.TryParse(txtNumero.Text, out numero) || txtNumero.Text is null)
            {
                MessageBox.Show("Debe ingresar el numero correctamente", "ATENCION", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                oPARTIDA.verificarNro(numero); //Ejecuto el metodo verificarNro de la Partida
                lblIntentos.Text = oPARTIDA.INTENTO.ToString();
                lblCreditos.Text = oPARTIDA.CREDITO.ToString();
                if (oPARTIDA.RESULTADO == "Ganada") //Si el resultado es "Ganada", finalizo la partida, 
                {

                    oJUEGO.PARTIDAS.Add(oPARTIDA); //Si el resultado es "Ganada", guardo la partida en la lista de partidas
                    DialogResult = MessageBox.Show("Felicidades, ha ganado la partida en " + oPARTIDA.INTENTO + " intentos. ¿Jugamos otra vez?", "Ganador!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        nuevaPartida();

                    }
                    else
                    {
                        this.Close();
                    }

                }
            }
            catch (Exception ex)
            {
                if (oPARTIDA.CREDITO == 0)
                {

                    oJUEGO.PARTIDAS.Add(oPARTIDA); //Si el resultado es "Ganada", guardo la partida en la lista de partidas
                    DialogResult = MessageBox.Show(ex.Message + " ¿Jugamos otra vez?", "Perdida!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (DialogResult == DialogResult.Yes)
                    {
                        nuevaPartida();

                    }
                    else
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(ex.Message, "¡¡!!"); //Muestro un mensaje con la excepcion
                }
                lblIntentos.Text = oPARTIDA.INTENTO.ToString();
                lblCreditos.Text = oPARTIDA.CREDITO.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
