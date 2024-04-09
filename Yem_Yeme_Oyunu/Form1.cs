using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yem_Yeme_Oyunu
{
    public partial class Form_Game : Form
    {
        public Form_Game()
        {
            InitializeComponent();

        }
        
            
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (tusKontrol == 0)
            {

                int x = Avci.Location.X;
                int y = Avci.Location.Y;

                int x_yem = Yem.Location.X;
                int y_yem = Yem.Location.Y;


                if (e.KeyCode == Keys.Right)
                {
                    x = x + 10;
                    Avci.Location = new Point(x, y);
                }
                if (e.KeyCode == Keys.Left && x > 0)
                {
                    x = x - 10;
                    Avci.Location = new Point(x, y);
                }
                if (e.KeyCode == Keys.Up && y > 5)
                {
                    y = y - 10;
                    Avci.Location = new Point(x, y);
                }
                if (e.KeyCode == Keys.Down)
                {
                    y = y + 10;
                    Avci.Location = new Point(x, y);
                }

                if (Avci.Top <= EngelUst.Bottom || Avci.Bottom >= EngelAlt.Top)
                {
                    timer1.Stop();
                    ++tusKontrol;
                    Kaybettin();
                }

                if (Avci.Right >= EngelSag.Left && Avci.Left <= EngelSag.Right)
                {
                    timer1.Stop();
                    ++tusKontrol;
                    Kaybettin();
                }
                if (Avci.Right >= EngelSol.Left && Avci.Left <= EngelSol.Right)
                {
                    timer1.Stop();
                    ++tusKontrol;
                    Kaybettin();
                }

                if ((Avci.Right >= EngelOrta.Left && Avci.Bottom >= EngelOrta.Top) && (Avci.Left <= EngelOrta.Right && Avci.Bottom >= EngelOrta.Top) && (Avci.Right >= EngelOrta.Left && Avci.Top <= EngelOrta.Bottom) && (Avci.Left <= EngelOrta.Right && Avci.Top <= EngelOrta.Bottom))
                {
                    timer1.Stop();
                    ++tusKontrol;
                    Kaybettin();
                }

                if ((Avci.Right >= Yem.Left && Avci.Bottom >= Yem.Top) && (Avci.Left <= Yem.Right && Avci.Bottom >= Yem.Top) && (Avci.Right >= Yem.Left && Avci.Top <= Yem.Bottom) && (Avci.Left <= Yem.Right && Avci.Top <= Yem.Bottom))
                {

                    while (yemKontrol == 0)
                    {
                        x_yem = rdm.Next(90, 1850);
                        y_yem = rdm.Next(60, 1000);
                        Yem.Location = new Point(x_yem, y_yem);

                        if ((Yem.Right >= EngelOrta.Left && Yem.Bottom >= EngelOrta.Top) && (Yem.Left <= EngelOrta.Right && Yem.Bottom >= EngelOrta.Top) && (Yem.Right >= EngelOrta.Left && Yem.Top <= EngelOrta.Bottom) && (Yem.Left <= EngelOrta.Right && Yem.Top <= EngelOrta.Bottom))
                        {
                            yemKontrol = 0;
                        }
                        else
                        {
                            yemKontrol = 1;
                        }
                    }
                    yemKontrol = 0;
                    saniye = 0;
                    puan = puan + 10;
                    labelPuan.Text = "Puan: " + puan;
                    timer1.Start();
                }

                if (puan % 50 == 0 && puan != 0)
                {
                    timer_Disco.Start();
                }
                else
                {
                    timer_Disco.Stop();
                }

            }

        }

        Random rdm = new Random();
        int saniye, puan = -10, tusKontrol = 0, yemKontrol = 0, disco = 0; // YemKontrol yemi doğru yere koyar

        private void timer_Disco_Tick(object sender, EventArgs e)
        {

            Color randomColor = Color.FromArgb(rdm.Next(256), rdm.Next(256), rdm.Next(256));
            this.BackColor = randomColor;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            saniye++;
            labelSure.Text = "Süre: " + (10 - saniye);

            if ((10 - saniye) == 0)
            {
                timer1.Stop();
                ++tusKontrol;
                Kaybettin();
            }


        }

        public void YenidenBaslat()
        {
            // Oyun bileşenlerini başlangıç konumlarına geri getir
            this.BackColor= Color.White;
            Avci.Location = new Point(365, 80);
            Yem.Location = new Point(374, 90);
            saniye = 0;
            puan = -10;
            tusKontrol = 0;
            yemKontrol = 0;
            labelPuan.Text = "Puan: " + puan;
            labelSure.Text = "Süre: " + (10 - saniye);
            // Timer'ı yeniden başlat
            timer1.Start();
        }
        private void Kaybettin()
        {
            DialogResult result = MessageBox.Show("Kaybettin\nYeniden denemek ister misin", "İyi deneme", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                YenidenBaslat();
            }
            if (DialogResult.No == result)
            {
                this.Close();
            }
        }

    }
}
