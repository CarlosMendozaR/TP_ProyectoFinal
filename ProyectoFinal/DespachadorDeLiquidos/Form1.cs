using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace DespachadorDeLiquidos
{
    public partial class Menu : Form
    {
        Bebida nuevaBebida;
        ArrayList ListaDeBebidas;
        Queue<Bebida> ColaBebidas = new Queue<Bebida>();
        string[] porciones = {"10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%"};

        #region Constructor
        public Menu()
        {
            InitializeComponent();
            ListaDeBebidas = new ArrayList();
            ListaDeBebidas.Add(new Bebida("Ron Blanco", "Coca Cola", -1, -1, -1, 5));
            ListaDeBebidas.Add(new Bebida("Tequila", "Squirt", -1, -1, -1, 2));
            ListaDeBebidas.Add(new Bebida("Bacardi", "Coca Cola", -1, -1, -1, 3));
            ListaDeBebidas.Add(new Bebida("Absolut Vodka", "Jugo", -1, -1, -1, 3));
            foreach (Bebida copa in ListaDeBebidas)
            {
                cmbBebida.Items.Add(copa.Alcohol);
            }
            foreach (string item in porciones)
                cmbPorcion.Items.Add(item);
        }
        #endregion

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
            DesaparecerControles();
            MostrarParaCombinado();
        }
        private void rdbSoloHielo_CheckedChanged(object sender, EventArgs e)
        {
            DesaparecerControles();
            MostrarParaHielos();
        }
        private void rdbShot_CheckedChanged(object sender, EventArgs e)
        {
            DesaparecerControles();
            MostrarParaShot();
        }
        private void rdbPersonalizado_CheckedChanged(object sender, EventArgs e)
        {
            DesaparecerControles();
            MostrarParaPersonalizado();
        }
        private void cmbPorcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbAlcohol.Text = ((cmbPorcion.SelectedIndex + 1)*10).ToString();
            txtbAguaMineral.Text = "0";
            txtbRefresco.Text = (100 - int.Parse(txtbAlcohol.Text)).ToString();
            txtbHielos.Text = "4";
        }
        private void btnServir_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbCombinado.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, nuevaBebida.Refresco, int.Parse(txtbAlcohol.Text), int.Parse(txtbRefresco.Text), int.Parse(txtbAguaMineral.Text), byte.Parse(txtbHielos.Text)));
                    MessageBox.Show("Cubeibi en cola de preparacion");
                }
                else if (rdbSoloHielo.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, "Sin refresco", 100, 0, 0, byte.Parse(txtbHielos.Text)));
                    MessageBox.Show("A las rocas en cola de preparacion");
                }
                else if (rdbShot.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, "Sin refresco", int.Parse(txtbAlcohol.Text), 0, 0, 0));
                    MessageBox.Show("Shot en cola de preparacion");
                }
                else if (rdbPersonalizado.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, nuevaBebida.Refresco, int.Parse(txtbAlcohol.Text), int.Parse(txtbRefresco.Text), int.Parse(txtbAguaMineral.Text), byte.Parse(txtbHielos.Text)));
                    MessageBox.Show("Bebida personalizada en cola de preparacion");
                }
                errorProvider1.Clear();
            }
            catch (FormatException)
            {
                errorProvider1.SetError(btnServir, "Rellene los campos necesarios");
            }
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
            label8.Visible = true; label8.Text = "Ingresa la cantidad que desees [ml]";
            label4.Visible = true; 
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true; label7.Location = new Point(49, 144);
            txtbAlcohol.Visible = true; txtbAlcohol.Enabled = true;
            txtbRefresco.Visible = true; txtbRefresco.Enabled = true;
            txtbAguaMineral.Visible = true; txtbAguaMineral.Enabled = true;
            txtbHielos.Visible = true; txtbHielos.Enabled = true; txtbHielos.Location = new Point(142, 142);
        }
        public void MostrarParaCombinado()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true; label7.Location = new Point(49, 144);
            cmbPorcion.Visible = true;
            txtbAlcohol.Visible = true; txtbAlcohol.Enabled = false;
            txtbRefresco.Visible = true; txtbRefresco.Enabled = false;
            txtbAguaMineral.Visible = true; txtbAguaMineral.Enabled = false;
            txtbHielos.Visible = true; txtbHielos.Enabled = false; txtbHielos.Location = new Point(142, 142);
        }
        public void MostrarParaHielos()
        { 
            label8.Visible=true; label8.Text = "Ingresa la cantidad de hielos que deseas";
            label7.Visible = true; label7.Location = new Point(49, 76);
            txtbHielos.Visible = true; txtbHielos.Enabled = true; txtbHielos.Location = new Point(142, 74);
        }
        public void MostrarParaShot()
        {
            label8.Visible = true; label8.Text="Ingresa la cantidad que desees [ml]";
            label4.Visible = true;
            txtbAlcohol.Visible = true; txtbAlcohol.Enabled = true;
        }

        public void DesaparecerControles()
        {
            foreach (Control cont in gpbPorcion.Controls)
            {
                if (cont is TextBox)
                {
                    ((TextBox)cont).Visible = false;
                    ((TextBox)cont).Text = "";
                }
                if (cont is Label)
                {
                    ((Label)cont).Visible = false;
                }
                if(cont is ComboBox)
                {
                    ((ComboBox)cont).Visible = false;
                }
            }
        }
        #endregion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
        }
    }
}
