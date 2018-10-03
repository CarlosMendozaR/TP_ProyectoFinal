using System;
using System.Collections;
using System.Windows.Forms;
using System.Drawing;

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
        private void cmbBebida_SelectedIndexChanged(object sender, EventArgs e)
        {
            nuevaBebida = (Bebida)ListaDeBebidas[cmbBebida.SelectedIndex];
            gpbPorcion.Text = nuevaBebida.Alcohol;
            Ingredientes();

        }
        private void cmbBebida_Preparado(object sender, EventArgs e)
        {
            rdbCombinado.Checked = true;
        }


        private void rdbCombinado_CheckedChanged(object sender, EventArgs e)
        {

            MostrarParaCombinado();
        }
        private void rdbSoloHielo_CheckedChanged(object sender, EventArgs e)
        {
            MostrarParaHielos();
        }
        private void rdbShot_CheckedChanged(object sender, EventArgs e)
        {
            MostrarParaShot();
        }
        private void rdbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            MostrarParaPersonalizado();
        }
        #endregion

        #region Métodos
        public void Ingredientes()
        {
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
        public void MostrarParaPersonalizado()
        {
            label8.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            txtbAlcohol.Visible = true;
            txtbRefresco.Visible = true;
            txtbAguaMineral.Visible = true;
            txtbHielos.Visible = true;
        }
        public void MostrarParaCombinado()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            cmbPorcion.Visible = true;
            txtbAlcohol.Visible = true;
            txtbRefresco.Visible = true;
            txtbAguaMineral.Visible = true;
            txtbHielos.Visible = true;
        }
        public void MostrarParaHielos()
        {
            label7.Visible = true;
            txtbHielos.Visible = true;
            label7.Location = new Point(65, 94);
            txtbHielos.Location = new Point(190, 91);
        }
        public void MostrarParaShot()
        {
            label4.Visible = true;
            txtbAlcohol.Visible = true;
        }
        #endregion

    }
}
