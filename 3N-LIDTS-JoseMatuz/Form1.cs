using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Data.Common;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace _3N_LIDTS_JoseMatuz
{
    public partial class Form1 : Form
    {
        string SqlConnection = "Server=localhost; Port= 3306; Database=programacionavanzada;Uid=root;Pwd=Timeshirt#21";

        delegate void setTextDelegate(string value);
        public SerialPort ArduinoPort { get; }
        public Form1()
        {
            InitializeComponent();
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM3";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(Form1_Load);

            this.btnConectar.Click += btnConectar_Click;
        }

        


        private void insertarRegistro(string limite, string temperatura)
        {

            using (MySqlConnection connection = new MySqlConnection(SqlConnection))
            {
                connection.Open();
                string insertQuery = "INSERT INTO temperaturas (limite, temperatura)" +
                "VALUES (@limite, @temperatura)";
                using (MySqlCommand command = new MySqlCommand(insertQuery, connection))
                {
                    //command.Parameters.AddWithValue("@",);
                    command.Parameters.AddWithValue("@limite", limite);
                    command.Parameters.AddWithValue("@temperatura", temperatura);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            //lbtemp.Text=indata
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            

            if (InvokeRequired)
                try
                {
                    Invoke(new setTextDelegate(EscribirTxt), dato);
                }
                catch
                {
                    //poner accion de aviso de error (message box)
                }
            else
                lbTemp.Text = dato;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            btnDesconectar.Enabled = true;
            btnConectar.Enabled = false;
            try
            {
                if (!ArduinoPort.IsOpen)
                    ArduinoPort.Open();
                if (int.TryParse(tbLimTemp.Text, out int temperatureLimit))
                {
                    //convierte el valor en una cadena y luego en un arreglo de bytes
                    string limitString = temperatureLimit.ToString();
                    ArduinoPort.Write(limitString);
                }
                else
                {
                    MessageBox.Show("Ingresa un valor numerico valido en el textbox limite de temp");
                }
                lbConection.Text = "Conexion OK";
                lbConection.ForeColor = System.Drawing.Color.Lime;
            }

            
            catch
            {
                MessageBox.Show("Configure el puerto correcto o desconectese");
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            btnConectar.Enabled = true;
            btnDesconectar.Enabled = false;
            ArduinoPort.Close();
            lbConection.Text = "Desconectado";
            lbConection.ForeColor = System.Drawing.Color.Red;
            lbTemp.Text = "00.0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            string temperatura = lbTemp.Text;
            string limite = tbLimTemp.Text;
            insertarRegistro(limite, temperatura);
        }
    }
}
