using System;
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Threading;

namespace DespachadorDeLiquidos
{
    public partial class Menu : Form
    {
        //Conexion
        SerialPort serialPort;
        byte fin;
        int contadorBombas = 0;

        Bebida nuevaBebida;
        ArrayList ListaDeBebidas;
        Queue<Bebida> ColaBebidas = new Queue<Bebida>();
        string[] porciones = { "10%", "20%", "30%", "40%", "50%", "60%", "70%", "80%", "90%" };

        #region Constructor
        public Menu(SerialPort serialPort)
        {
            this.serialPort = serialPort;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(ContadorBombas);

            InitializeComponent();
            ListaDeBebidas = new ArrayList();
            ListaDeBebidas.Add(new Bebida("Ron Blanco", "Coca Cola", -1, -1, -1));
            ListaDeBebidas.Add(new Bebida("Tequila", "Squirt", -1, -1, -1));
            ListaDeBebidas.Add(new Bebida("Bacardi", "Coca Cola", -1, -1, -1));
            ListaDeBebidas.Add(new Bebida("Absolut Vodka", "Jugo", -1, -1, -1));
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
            txtbAlcohol.Text = ((cmbPorcion.SelectedIndex + 1) * 10).ToString();
            txtbAguaMineral.Text = "0";
            txtbRefresco.Text = (100 - int.Parse(txtbAlcohol.Text)).ToString();
        }
        private void btnServir_Click(object sender, EventArgs e)
        {
            try
            {
                fin = 0;
                if(fin == 1)
                {
                    throw new ApplicationException("Espera a que se termine la bebida");
                }
                if (rdbCombinado.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, nuevaBebida.Refresco, int.Parse(txtbAlcohol.Text), int.Parse(txtbRefresco.Text), int.Parse(txtbAguaMineral.Text)));
                }
                else if (rdbShot.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, "Sin refresco", int.Parse(txtbAlcohol.Text), 0, 0));
                }
                else if (rdbPersonalizado.Checked)
                {
                    ColaBebidas.Enqueue(new Bebida(nuevaBebida.Alcohol, nuevaBebida.Refresco, int.Parse(txtbAlcohol.Text), int.Parse(txtbRefresco.Text), int.Parse(txtbAguaMineral.Text)));
                }
                errorProvider1.Clear();
                fin = ServirBebida(ColaBebidas.Dequeue());
            }
            catch (ApplicationException error)
            {
                MessageBox.Show(error.Message);
            }
            catch (FormatException)
            {
                errorProvider1.SetError(btnServir, "Rellene los campos necesarios");
            }
        }

        public void ContadorBombas(object sender, EventArgs e)
        {
            contadorBombas++;
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
            lbMas1.Visible = true;
            lbMas2.Visible = true;
        }
        public void MostrarParaPersonalizado()
        {
            label8.Visible = true; label8.Text = "Ingresa la cantidad que desees [ml]";
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            txtbAlcohol.Visible = true; txtbAlcohol.Enabled = true;
            txtbRefresco.Visible = true; txtbRefresco.Enabled = true;
            txtbAguaMineral.Visible = true; txtbAguaMineral.Enabled = true;
        }
        public void MostrarParaCombinado()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            cmbPorcion.Visible = true;
            txtbAlcohol.Visible = true; txtbAlcohol.Enabled = false;
            txtbRefresco.Visible = true; txtbRefresco.Enabled = false;
            txtbAguaMineral.Visible = true; txtbAguaMineral.Enabled = false;
        }

        public void MostrarParaShot()
        {
            label8.Visible = true; label8.Text = "Ingresa la cantidad que desees [ml]";
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
                if (cont is ComboBox)
                {
                    ((ComboBox)cont).Visible = false;
                }
            }
        }

        public byte ServirBebida(Bebida miBebida)
        {
            Form2 form2 = new Form2();
            form2.Show();
            for (int i = 0; i < 2; i++)
            {
                switch (contadorBombas)
                {
                    case 0:
                        int[] bomba1 = { 1, 1, miBebida.CantidadAlcohol };
                        for (int j = 0; j < 2; j++)
                        {
                            serialPort.Write(bomba1[i].ToString());
                        }
                        Thread.Sleep(1000);
                        break;

                    case 1:
                        int[] bomba2 = { 1, 2, miBebida.CantidadRefresco };
                        for (int j = 0; j < 2; j++)
                        {
                            serialPort.Write(bomba2[i].ToString());
                        }
                        Thread.Sleep(1000);
                        break;
                    case 2:
                        int[] bomba3 = { 1, 3, miBebida.CantidadAgua };
                        for (int j = 0; j < 2; j++)
                        {
                            serialPort.Write(bomba3[i].ToString());
                        }
                        Thread.Sleep(1000);
                        break;
                }
            }
            contadorBombas = 0;
            form2.Hide();
            return 1;
        }
        #endregion

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Bienvenida bienvenida = new Bienvenida();
            bienvenida.Show();
        }
    }
}