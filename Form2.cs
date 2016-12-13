using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaPlayer;

namespace ArduinoPiano
{
    public partial class Form2 : Form
    {
        private void button1_Click(object sender, EventArgs e)
        {
            media();
        }

        void media()
        {
            var player1 = new WMPLib.WindowsMediaPlayer();
            
            player1.URL = @"C:\\1.wav";

            var player2 = new WMPLib.WindowsMediaPlayer();

            player2.URL = @"C:\\2.wav";

            var player5 = new WMPLib.WindowsMediaPlayer();

            player5.URL = @"C:\\5.wav";




        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM8";
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
         
            picConnectionStatus.Image = Properties.Resources.bekleniyor;
          
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }
            if (serialPort1.IsOpen == true)
            {
                picConnectionStatus.Image = Properties.Resources.acik;
            }

        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                serialPort1.Close();

            }
            if (serialPort1.IsOpen == false)
            { picConnectionStatus.Image = Properties.Resources.kapali; }
            }

        private void btnCal_Click(object sender, EventArgs e)
        {
          
            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

       
            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);
            
            _sol();
            serialPort1.Write("4");//sol
            System.Threading.Thread.Sleep(1000);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(500);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

            _sol();
            serialPort1.Write("4");//sol
            System.Threading.Thread.Sleep(1000);

            _fa();
            serialPort1.Write("3");//fa
            System.Threading.Thread.Sleep(500);
            

            _sol();
            serialPort1.Write("4");//sol
            System.Threading.Thread.Sleep(500);
            

            _sol();
            serialPort1.Write("4");//sol
            System.Threading.Thread.Sleep(500);
           

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(500);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

            _la();
            serialPort1.Write("5");//la
            System.Threading.Thread.Sleep(250);

            _sol();
            serialPort1.Write("4");//sol
            System.Threading.Thread.Sleep(1000);
        }





        void _do()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\1.wav";
            player.Play();
        }
        void _re()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\2.wav";
            player.Play();
        }
        void _mi()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\3.wav";
            player.Play();
        }
        void _fa()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\4.wav";
            player.Play();
        }
        void _sol()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\5.wav";
            player.Play();
        }
        void _la()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\6.wav";
            player.Play();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            serialPort1.Write("0");//do
            serialPort1.Write("1");//re
            serialPort1.Write("2");//mi
            serialPort1.Write("3");//fa
            serialPort1.Write("4");//sol
            serialPort1.Write("5");//la


        }

   
    }
}
