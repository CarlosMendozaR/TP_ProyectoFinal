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

            /*Para personalizado
            label8.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            txtbAlcohol.Visible = true;
            txtbRefresco.Visible = true;
            txtbAguaMineral.Visible = true;
            txtbHielos.Visible = true;*/

            /*Para Combinado
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            cmbPorcion.Visible = true;
            txtbAlcohol.Visible = true;
            txtbRefresco.Visible = true;
            txtbAguaMineral.Visible = true;
            txtbHielos.Visible = true;*/

            /*Para solo hielos
            label7.Visible = true;
            txtbHielos.Visible = true;
            label7.Location = new Point(65,94);
            txtbHielos.Location = new Point(190, 91);*/

            /*Para shot
            label4.Visible = true;
            txtbAlcohol.Visible = true;*/
        }
        private void cmbBebida_Preparado(object sender, EventArgs e)
        {
            rdbCombinado.Checked = true;
        }
        #endregion

    }
}
