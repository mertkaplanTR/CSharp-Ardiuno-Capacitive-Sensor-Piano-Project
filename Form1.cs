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
using System.Text.RegularExpressions;
using System.IO;

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
            lblConnectionStatus.Text = "Waiting Action";
            picConnectionStatus.Image = Properties.Resources.bekleniyor;
            lblConnectionStatus.ForeColor = Color.Orange;
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();


            }
            if (serialPort1.IsOpen == true)
            {
                lblConnectionStatus.Text = "Connected";
                picConnectionStatus.Image = Properties.Resources.acik;
                lblConnectionStatus.ForeColor = Color.Green;
                // connectArd();
                //timer1.Start();
                caldirFunc();
            }

        }

     
        void caldirFunc()
        {
            
            while (serialPort1.IsOpen == true)
            {
              //  string alinanDeger = serialPort1.ReadLine();
                string value = serialPort1.ReadLine();
                string[] lines = Regex.Split(value, "\r\n");
                foreach (string line in lines)
                {
                    textBox1.Text = "Alinan Deger: " + value;
                }
                textBox1.Text = "Alinan Deger: " + value;
                int gonderilendeger = int.Parse(value);
                potansiyeller(gonderilendeger);
            }
        }


      
        void potansiyeller(int _donusturulendeger)
        {
        
            int donusturulendeger = _donusturulendeger;
            if (donusturulendeger >= 480 && donusturulendeger <= 520)
            {
               
                picPianoPictures.Image = Properties.Resources._0;
                donusturulendeger = 0;
                play1();

            }
            else if (donusturulendeger >= 200 && donusturulendeger <= 260)
            {
             
                play2();
                picPianoPictures.Image = Properties.Resources._1;
                donusturulendeger = 0;
            }
            else if (donusturulendeger >= 2950 && donusturulendeger <= 3050)
            {
                play3();
                picPianoPictures.Image = Properties.Resources._2;
                donusturulendeger = 0;
            }
            else if (donusturulendeger >= 3800 && donusturulendeger <= 4200)
            {
                play4();
                picPianoPictures.Image = Properties.Resources._3;
                donusturulendeger = 0;
            }
            else if (donusturulendeger >= 4850 && donusturulendeger <= 5300)
            {
                play5();
                picPianoPictures.Image = Properties.Resources._4;
                donusturulendeger = 0;
            }
            else if (donusturulendeger >= 6050 && donusturulendeger <= 6200)
            {
                picPianoPictures.Image = Properties.Resources._5;
                play6();

                donusturulendeger = 0;

            }
            else
            {
              
                donusturulendeger = 0;
                picPianoPictures.Image = Properties.Resources._default;
            }
        }


 




















    private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            { serialPort1.Close();

            }
            if (serialPort1.IsOpen == false)
            {
                lblConnectionStatus.ForeColor = Color.Red;
                picConnectionStatus.Image = Properties.Resources.kapali;
                lblConnectionStatus.Text = "Disconnected";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try {
                
                string alinanDeger = serialPort1.ReadLine();
                string value = serialPort1.ReadLine();
                string[] lines = Regex.Split(value, "\r\n");
                foreach (string line in lines)
                {
                    textBox1.Text = "Alinan Deger: " + alinanDeger; 
                }


          //      alinanDeger = alinanDeger.Trim(); //remove newline
           
                textBox1.Text = "Alinan Deger: " +alinanDeger;
                int donusturulendeger = int.Parse(alinanDeger);
                if (donusturulendeger >= 480 && donusturulendeger <= 520)
                {
                    play1();
                    picPianoPictures.Image = Properties.Resources._0;
                    donusturulendeger = 0;
                }
                else if (donusturulendeger >= 200 && donusturulendeger <= 260)
                { play2();
                    picPianoPictures.Image = Properties.Resources._1;
                    donusturulendeger = 0;
                }
                else if (donusturulendeger >= 2950 && donusturulendeger <= 3050)
                {
                    play3();
                    picPianoPictures.Image = Properties.Resources._2;
                    donusturulendeger = 0;
                }
                else if (donusturulendeger >= 3800 && donusturulendeger <= 4200)
                {
                    play4();
                    picPianoPictures.Image = Properties.Resources._3;
                    donusturulendeger = 0;
                }
                else if (donusturulendeger >= 4850 && donusturulendeger <= 5300)
                {
                    play5();
                    picPianoPictures.Image = Properties.Resources._4;
                    donusturulendeger = 0;
                }
                else if (donusturulendeger >= 6050 && donusturulendeger <= 6200)
                {
                    picPianoPictures.Image = Properties.Resources._5;
                    play6();
                    
                    donusturulendeger = 0;
                    
                }
                else { donusturulendeger = 0; picPianoPictures.Image = Properties.Resources._default;
                   
                }
            }
            catch (Exception ex)
            { textBox1.Text = ex.ToString();
                timer1.Stop(); 
            }
        }
        void play1()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\1.wav";
            player.Play();
        }
        void play2()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\2.wav";
            player.Play();
        }
        void play3()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\3.wav";
            player.Play();
        }
        void play4()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\4.wav";
            player.Play();
        }
        void play5()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\5.wav";
            player.Play();
        }
        void play6()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = "C:\\6.wav";
            player.Play();
        }
    }
}
