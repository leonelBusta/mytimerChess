using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace timerChess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Codigo de los comboBox, hora, min, y seg
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                comboBoxMinutos.Items.Add(i);
                comboBoxSegundos.Items.Add(i);

                if (i < 24) { comboBoxHora.Items.Add(i); }
            }

            comboBoxMinutos.SelectedIndex = 0;
            comboBoxSegundos.SelectedIndex = 1;
            comboBoxHora.SelectedIndex = 0;
        }

        int horas, min, seg;
        int horasn, minn, segn;

        //el button para CERRAR el programa
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //el tiempo de blancas
        private void timer1_Tick(object sender, EventArgs e)
        {
            seg -= 1;

            string minutos = min.ToString();
            string hor = horas.ToString();
            string segundos = seg.ToString();

            if (horas < 10) { hor = "0" + horas.ToString(); }
            if (min < 10) { minutos = "0" + min.ToString(); }
            if (seg < 10) { segundos = "0" + seg.ToString(); }

            if (seg == 0 && min > 0)
            {
                min -= 1;
                seg = 60;
            }
            if (min == 0 && horas > 0 && seg == 0)
            {
                seg = 60;
                horas -= 1;
                min = 59;
            }
            if (min==0 && horas== 0 && seg == 0)
            {
                timer1.Stop();
                
                MessageBox.Show("Ha "+txtBlancas+" se le termino el tiempo", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btncambio.Enabled = false;
               // btncambio.ForeColor = Color.RoyalBlue;
                btncambio.Text = "no juego";
            }
            labelTiempo1.Text = hor + ":" + minutos + ":" + segundos;
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            segn -= 1;

            string minutosn = minn.ToString();
            string horn = horasn.ToString();
            string segundosn = segn.ToString();

            if (horasn < 10) { horn = "0" + horasn.ToString(); }
            if (minn < 10) { minutosn = "0" + minn.ToString(); }
            if (segn < 10) { segundosn = "0" + segn.ToString(); }

            if (segn == 0 && minn > 0)
            {
                minn -= 1;
                segn = 60;
            }
            if (minn == 0 && horasn > 0 && segn == 0)
            {
                segn = 60;
                horasn -= 1;
                minn = 59;
            }
            if (minn == 0 && horasn == 0 && segn == 0)
            {
                
                timer2.Stop();
                MessageBox.Show("Ha " + txtNegras + " se le termino el tiempo", "Temporizador", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btncambio.Enabled = false;
               // btncambio.ForeColor = Color.RoyalBlue;
                btncambio.Text = "no juego";
            }
            
            labelTiempo2.Text = horn + ":" + minutosn + ":" + segundosn;
        }

        private void btncambio_Click(object sender, EventArgs e)
        {
            //SoundPlayer Player = new SoundPlayer();
           // Player.SoundLocation = "C:/Users/Hp/Music/push.wav";
           // Player.Play();
            if (btncambio.Text == "Blancas")
            {
                timer1.Stop();
                timer2.Start();
                btncambio.ForeColor = Color.Red;
                txtNegras.ForeColor = Color.Red;
                txtBlancas.ForeColor = Color.Black;
                btncambio.Text = "Negras";

            }
            else 
            {
                timer2.Stop();
                timer1.Start();
                btncambio.ForeColor = Color.Blue;
                txtNegras.ForeColor = Color.Black;
                txtBlancas.ForeColor = Color.Blue;
                btncambio.Text = "Blancas";

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                timer1.Start();
                //timer2.Stop();
                btnIniciar.ForeColor = Color.Firebrick;
                btncambio.Enabled = true;
                horas = comboBoxHora.SelectedIndex;
                min = comboBoxMinutos.SelectedIndex;
                seg = comboBoxSegundos.SelectedIndex;
                horasn = comboBoxHora.SelectedIndex;
                minn = comboBoxMinutos.SelectedIndex;
                segn = comboBoxSegundos.SelectedIndex;
                btnIniciar.Text = "Restablecer";
                btncambio.Text = "Blancas";
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                seg = 0;
                min = 0;
                horas = 0;
                segn = 0;
                minn = 0;
                horasn = 0;
                labelTiempo1.Text = "00:00:00";
                labelTiempo2.Text = "00:00:00";
                btnIniciar.ForeColor = Color.ForestGreen;
                btncambio.Enabled = false;
                btncambio.ForeColor = Color.Blue;
                btnIniciar.Text = "Iniciar";
                btncambio.Text = "Negras";
            }
        }
    }
}
//CHESS TIMER - LEONEL BUSTAMANTE -  instagram.com/leobustamantee/