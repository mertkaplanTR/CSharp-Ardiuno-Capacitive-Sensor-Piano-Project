using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArduinoPiano
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {


            picConnectionStatus.Image = Properties.Resources.bekleniyor;
        }


        private void btnBaglan_Click(object sender, EventArgs e)
        {
            serialPort1.BaudRate = 9600;
            serialPort1.PortName = "COM8";
            serialPort1.Parity = System.IO.Ports.Parity.None;
            serialPort1.DataBits = 8;
            serialPort1.StopBits = System.IO.Ports.StopBits.One;
            serialPort1.Open();
            if (serialPort1.IsOpen == false)
            {
                serialPort1.Open();
            }
            if (serialPort1.IsOpen == true)
            {
                picConnectionStatus.Image = Properties.Resources.acik;
            }

            runMusic();

        }

        void media(int _birinci, int _ikinci)
        {
            if (_birinci > 200 && _ikinci > 0)
            {
                var player1 = new WMPLib.WindowsMediaPlayer();

                player1.URL = @"C:\\1.wav";

                var player2 = new WMPLib.WindowsMediaPlayer();

                player2.URL = @"C:\\2.wav";
                return;
            }
            else
            {
                var player1 = new WMPLib.WindowsMediaPlayer();
                player1.URL = @"C:\\5.wav";
            }


        }



        public void runMusic()
        {
            // int _whileCount = 0;
            string alinanDegerBuyukMu = serialPort1.ReadLine();
            string[] ayiriciArray = new string[] { "\r" };
            string[] lines = alinanDegerBuyukMu.Split(ayiriciArray, StringSplitOptions.None);
            alinanDegerBuyukMu = lines[0];
            int karsilastiripArrayeAtilacakDeger = int.Parse(alinanDegerBuyukMu);

            ////ALINAN DEGER 150'DEN BUYUKSE MIX ICIN ISLEMLERE BASLA
            while (serialPort1.IsOpen == true && karsilastiripArrayeAtilacakDeger > 150)
            {
                //HAFIZAYA ALINACAK BASMA SURELERINI BU ARRAYA GORE AYARLA
                string[] arr = new string[2]; //2LİK STRING ARRAY TANIMLA  --> 300 ms*2=0,6 saniyelik 
                for (int i = 0; i < 2; i++) //BASILI OLDUGU SURECE BUNLARI EGER 100'DEN BUYUKSE BURAYA GIRIP ARRAYA GONDER
                {

                    arr[i] = serialPort1.ReadLine();  //SERİ OLARAK GELEN 2 FARKLI DEGERI ARRAYE GONDER

                }
                //ARRAYA ALDIKTAN SONRA BUNLARI BIR INTEGER ARRAYA GONDER VE HEPSINI BERABER CALDIR.

                foreach (string elemanlar in arr)
                {
                    if (elemanlar == null)
                    { break; }
                    else
                    {
                        string arrayElamaniniIntDonustur = elemanlar;
                        string[] donustur = arrayElamaniniIntDonustur.Split(ayiriciArray, StringSplitOptions.None); //ARRAYIN ICINDEKILERI MIXER'E GONDER
                        arrayElamaniniIntDonustur = donustur[0];
                        ////BURASI ACILACAK//   
                        Mixer(int.Parse(arrayElamaniniIntDonustur));
                        System.Threading.Thread.Sleep(1000);
                    }

                }
            }
        }

        int[] alinanDegerler = new int[2];
        int countermixer = 0;
        void Mixer(int _alinanSayi)
        {
            if (countermixer > 1)
            {
                countermixer = 0;
            }
            else if (countermixer < 2)
            {
                alinanDegerler[countermixer] = _alinanSayi;
            }
            if (countermixer == 1)
            {
                serialPort1.Close();
                serialPort1.Close();
                serialPort1.Close();

                if (alinanDegerler[0] > 0 && alinanDegerler[1] > 0)
                {
                    ////////////////////////////////



                    var player1 = new WMPLib.WindowsMediaPlayer();

                    player1.URL = @"C:\\1.wav";

                    var player2 = new WMPLib.WindowsMediaPlayer();

                    player2.URL = @"C:\\2.wav";
                    ////////////////////////////////////// serialPort1.Open();

                }
            }
            countermixer++;

        }

        private void btnCal_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            int n = r.Next();
            Mixer(n);

        }

        private void btnBaglantiKes_Click(object sender, EventArgs e)
        {
            {
                if (serialPort1.IsOpen == true)
                {
                    serialPort1.Close();

                }
                if (serialPort1.IsOpen == false)
                {

                    picConnectionStatus.Image = Properties.Resources.kapali;

                }
            }
        }
    }
}
