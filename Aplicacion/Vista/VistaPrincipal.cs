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

namespace Vista
{
    public partial class VistaPrincipal : Form, IVistaPrincipal
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }

        public event EventHandler ClickeoMostrarPersonas;

        public void ActualizarBindingSource(BindingSource bindingSource)
        {
            this.dataGridView1.DataSource = bindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClickeoMostrarPersonas?.Invoke(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // ...
        }
    }
}
