using System;
using System.Collections;
using System.Windows.Forms;

namespace DespachadorDeLiquidos
{
    public partial class Form1 : Form
    {
        Bebida nuevaBebida;
        ArrayList ListaDeBebidas;

        public Form1()
        {
            InitializeComponent();
            ListaDeBebidas = new ArrayList();
            ListaDeBebidas.Add(new Bebida());
        }

        private void rdbCuba_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
