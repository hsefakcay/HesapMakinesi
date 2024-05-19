using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi: Form
    {
        string girdi = ""; // Kullan�c�n�n girdi�i say�lar� saklamak i�in bir de�i�ken
        bool yeniGiris = false;

        public HesapMakinesi()
        {
            InitializeComponent();
            // DateTimePicker'�n MaxDate �zelli�ini bug�n�n tarihi olarak ayarla
            DogumTarihiPicker.MaxDate = DateTime.Today;
            // En fazla 150 y�l �ncesi se�ilebilir
            DogumTarihiPicker.MinDate = DateTime.Today.AddYears(-150);
        }

        static char FindOperator(string input)
        {
            char foundOperator = '\0'; // Ba�lang��ta operat�r� bulunamad� olarak i�aretle

            for (int i = 0; i < input.Length; i++)
            {
                if ("+-*/".Contains(input[i]))
                {
                    foundOperator = input[i];
                    break; // �lk operat�r� bulduktan sonra d�ng�den ��k
                }
            }

            return foundOperator;
        }
        private void HesapButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdTextBox.Text) || string.IsNullOrWhiteSpace(SoyadTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) || DogumTarihiPicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("L�tfen ad, soyad, do�um tarihi ve email alanlar�n� doldurun.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
                {
                    MessageBox.Show("L�tfen hesaplanacak de�erleri giriniz.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {                    

                    string button = FindOperator(Sayi1TextBox.Text).ToString();


                    if (button == "*") {
                        CarpmaFonk();
                    }
                    else if (button == BolmeButton.Text)
                    {
                        BolmeFonk();
                    }
                    else if (button == ToplamaButton.Text)
                    {
                        ToplamaFonk();
                    }
                    else if (button == CikarmaButton.Text)
                    {
                        CikarmaFonk();
                    }

                    yasHesapla(sender, e);
                  
                }
            }
        }


        void yasHesapla(object sender, EventArgs e)
        {
            DateTime dogumTarihi = DogumTarihiPicker.Value;

            DateTime simdikiTarih = DateTime.Now;

            int yas = simdikiTarih.Year - dogumTarihi.Year;

            if(dogumTarihi > simdikiTarih.AddYears(-yas))
            {
                yas--;
            }

            yasLabel.Text = yas.ToString();
            
        }

        private void ToplamaFonk()
        {
            List<double> say�lar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("L�tfen say�lar� girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                say�lar = Sayi1TextBox.Text.Split('+').Select(double.Parse).ToList();
                double sonuc = say�lar[0] + say�lar[1];
                //double yi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text =  sonuc.ToString();
            }
        }

        private void CikarmaFonk()
        {
            List<double> say�lar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("L�tfen say�lar� girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                say�lar = sayiTextBox.Split('-').Select(double.Parse).ToList();
                double sonuc = say�lar[0] - say�lar[1];
                //uble sayi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text = sonuc.ToString();
            }
        }
        private void BolmeFonk()
        {
            List<double> say�lar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("L�tfen say�lar� girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                say�lar = Sayi1TextBox.Text.Split('/').Select(double.Parse).ToList();
                double sonuc = say�lar[0] / say�lar[1];
                //uble sayi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text =  sonuc.ToString();
            }
        }

        private void CarpmaFonk()
        {
            List<double> say�lar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("L�tfen say�lar� girin.", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                say�lar = Sayi1TextBox.Text.Split('*').Select(double.Parse).ToList();
                double sonuc = say�lar[0] * say�lar[1];
                //uble sayi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text =  sonuc.ToString();
            }
        }

        private void CarpmaButton_Click(object sender, EventArgs e)
        {
            
            Sayi1TextBox.Text += "*";
            yeniGiris = false;

        }
        private void BolmeButton_Click(object sender, EventArgs e)
        {
            Sayi1TextBox.Text += "/";
            yeniGiris = false;

        }
        private void ToplamaButton_Click(object sender, EventArgs e)
        {
            Sayi1TextBox.Text += "+";
            yeniGiris = false;
        }
        private void CikarmaButton_Click(object sender, EventArgs e)
        {
            Sayi1TextBox.Text += "-";
            yeniGiris = false;

        }

        private void SayiButtonClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (yeniGiris)
            {
                girdi += button.Text;
                yeniGiris = false;
            }
            else
            {
                girdi = button.Text;
            }
            // T�klanan butonun metnini girdiye ekler
            Sayi1TextBox.Text += girdi;
        }

        

        private void SilButton_Click(object sender, EventArgs e)
        {
            Sayi1TextBox.Text ="";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}