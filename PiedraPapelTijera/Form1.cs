using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Otracosa;

namespace PiedraPapelTijera
{
    public partial class Form1 : Form
    {
        Juego juego;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            juego = new Juego();
            juego.MandarMensaje += ImprimirMensaje;
            juego.TerminoPartida += ImprimirResultado;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            juego.ComenzarPartida();
        }

        private void ImprimirMensaje(string mensaje)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<string>(ImprimirMensaje), mensaje);
            }
            else
            {
                this.richTextBox1.Text = this.richTextBox1.Text.Insert(0, mensaje);
            }
        }

        private void ImprimirResultado(object sender, EventArgs e)
        {
            Juego juego = (Juego)sender;
            MessageBox.Show(juego.Ganador);
        }
    }
}
