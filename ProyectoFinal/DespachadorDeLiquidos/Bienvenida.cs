using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;


namespace DespachadorDeLiquidos
{
    public partial class Bienvenida : Form
    {
        SerialPort serialPort;
        int bandera=0;

        public Bienvenida()
        {
            InitializeComponent();
            serialPort = new SerialPort();
            Selecciona();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                //if (bandera == 0)
                //{
                 //   throw new ApplicationException("Debes realizar primero la conexion");
                //}
                this.Hide();
                Menu ventana = new Menu(serialPort);
                ventana.Show();
            //}
            //catch (ApplicationException error)
            //{
              //  MessageBox.Show(error.Message);
            //}

        }

        private void Bienvenida_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        public void Selecciona()
        {
            string[] puertos = SerialPort.GetPortNames();
            Array.Sort(puertos);
            tscmbPuertos.Items.AddRange(puertos);
        }

        private void verificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.BaudRate = int.Parse(tscmbVelocidad.SelectedItem.ToString());
                serialPort.PortName = tscmbPuertos.SelectedItem.ToString();
                MessageBox.Show("Se ha verificado la conexion correctamente");
            }
            catch (IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
            catch (NullReferenceException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }

        private void conectarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort.Open();
                MessageBox.Show("Conexion establecida");
                bandera = 1;
            }
            catch (IOException error)
            {
                MessageBox.Show("Error: " + error.Message);
            }
        }
    }
}
