namespace hicran
{
    public partial class Form1 : Form
    {
        // Ba�lang�� konumlar�n� tut
        Point b1Start, b2Start, b3Start, b4Start;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Butonlar�n ba�lang�� konumlar�n� al
            b1Start = button1.Location;
            b2Start = button2.Location;
            b3Start = button3.Location;
            b4Start = button4.Location;

            // Animasyonu ba�lat
            await ButonlariAnimasyonla();
        }

        private async Task ButonlariAnimasyonla()
        {
            int hareketMiktari = 1; // her ad�mda ka� piksel hareket edecek
            int adimSayisi = 30;    // toplam ka� ad�m atacak (i�e/d��a)

            while (true)
            {
                // Merkeze yakla� (i�eri)
                for (int i = 0; i < adimSayisi; i++)
                {
                    button1.Left += hareketMiktari;
                    button1.Top += hareketMiktari;

                    button2.Left -= hareketMiktari;
                    button2.Top += hareketMiktari;

                    button3.Left += hareketMiktari;
                    button3.Top -= hareketMiktari;

                    button4.Left -= hareketMiktari;
                    button4.Top -= hareketMiktari;

                    await Task.Delay(15);
                }

                // D��ar� uzakla� (eski yerine d�n)
                for (int i = 0; i < adimSayisi; i++)
                {
                    button1.Left -= hareketMiktari;
                    button1.Top -= hareketMiktari;

                    button2.Left += hareketMiktari;
                    button2.Top -= hareketMiktari;

                    button3.Left -= hareketMiktari;
                    button3.Top += hareketMiktari;

                    button4.Left += hareketMiktari;
                    button4.Top += hareketMiktari;

                    await Task.Delay(15);
                }
            }
        }
    }
}