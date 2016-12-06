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
using System.Media;
using System.Threading;
namespace ArduinoPiano
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
     
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM8";
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            

            label1.Text = "Action bekleniyor";

           


        }

        void play()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\2.wav";
            player.Play();
        }

  

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            try {
                string alinanDeger = serialPort1.ReadLine();
                ////
                string[] parcalar;
                parcalar = alinanDeger.Split('\r');
                alinanDeger = parcalar[0];
                ///
                alinanDeger = alinanDeger.Trim(); //remove newline
                textBox1.Text = "Alinan Deger: " +alinanDeger;
                int donusturulendeger = int.Parse(alinanDeger);
                if (donusturulendeger >=230 )
                    play();
            }
            catch(Exception ex)
            { textBox1.Text = ex.ToString();
                timer1.Stop(); 
            }

        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
                
                Thread.Sleep(2000);
                Thread.Sleep(0);
                
            }
            if(serialPort1.IsOpen==true)
            {   
                
                label1.Text = "BAGLANTI ACIK"; }
            

        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            { serialPort1.Close(); }
            if (serialPort1.IsOpen == false)
            { label1.Text = "kestim"; }
        }
    }
}
