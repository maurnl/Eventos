using Aplicacion.Vista;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentador;
using Modelo;
using Aplicacion.Dtos;

namespace Vista
{
    public partial class VistaPrincipal : Form, IVistaPrincipal
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        public event EventHandler ClickeoMostrarPersonas;
        public event EventHandler ClickeoMostrarPersonaRandom;

        public void ActualizarBindingSource(BindingSource bindingSource)
        {
            this.dataGridView1.DataSource = bindingSource;
        }

        public void MostrarPersonaRandom(PersonaLectura persona)
        {
            MessageBox.Show($"Nombre random: {persona.Nombre}, Id: {persona.Id}.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickeoMostrarPersonas?.Invoke(sender, e);
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            ClickeoMostrarPersonaRandom?.Invoke(sender, e);
        }
    }
}
