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
            ListaDeBebidas.Add(new Bebida("Ron Blanco", "Coca Cola", -1, -1, -1, 5));
            ListaDeBebidas.Add(new Bebida("Tequila", "Squirt", -1, -1, -1, 2));
            foreach (Bebida copa in ListaDeBebidas)
            {
                cmbBebida.Items.Add(copa.Alcohol);
            }
        }

        #region Eventos

        #endregion
        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevaBebida = (Bebida)ListaDeBebidas[cmbBebida.SelectedIndex];

            //Esta parte podemos hacerla un método
            gpbPorcion.Text = nuevaBebida.Alcohol;
            lbAlcohol.Text = nuevaBebida.Alcohol;
            lbRefresco.Text = nuevaBebida.Refresco;
            lbAlcohol.Visible = true;
            lbRefresco.Visible = true;
            lbAgua.Visible = true;
            lbHielo.Visible = true;
            lbMas1.Visible = true;
            lbMas2.Visible = true;
            lbMas3.Visible = true;
        }
        private void cmbBebida_Preparado(object sender, EventArgs e)
        {
            rdbCombinado.Checked = true;
        }
    }
}
