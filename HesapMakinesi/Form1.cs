using System;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class HesapMakinesi: Form
    {
        string girdi = ""; // Kullanýcýnýn girdiði sayýlarý saklamak için bir deðiþken
        bool yeniGiris = false;

        public HesapMakinesi()
        {
            InitializeComponent();
            // DateTimePicker'ýn MaxDate özelliðini bugünün tarihi olarak ayarla
            DogumTarihiPicker.MaxDate = DateTime.Today;
            // En fazla 150 yýl öncesi seçilebilir
            DogumTarihiPicker.MinDate = DateTime.Today.AddYears(-150);
        }

        static char FindOperator(string input)
        {
            char foundOperator = '\0'; // Baþlangýçta operatörü bulunamadý olarak iþaretle

            for (int i = 0; i < input.Length; i++)
            {
                if ("+-*/".Contains(input[i]))
                {
                    foundOperator = input[i];
                    break; // Ýlk operatörü bulduktan sonra döngüden çýk
                }
            }

            return foundOperator;
        }
        private void HesapButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AdTextBox.Text) || string.IsNullOrWhiteSpace(SoyadTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) || DogumTarihiPicker.Value == DateTime.MinValue)
            {
                MessageBox.Show("Lütfen ad, soyad, doðum tarihi ve email alanlarýný doldurun.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
                {
                    MessageBox.Show("Lütfen hesaplanacak deðerleri giriniz.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            List<double> sayýlar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("Lütfen sayýlarý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                sayýlar = Sayi1TextBox.Text.Split('+').Select(double.Parse).ToList();
                double sonuc = sayýlar[0] + sayýlar[1];
                //double yi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text =  sonuc.ToString();
            }
        }

        private void CikarmaFonk()
        {
            List<double> sayýlar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("Lütfen sayýlarý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                sayýlar = sayiTextBox.Split('-').Select(double.Parse).ToList();
                double sonuc = sayýlar[0] - sayýlar[1];
                //uble sayi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text = sonuc.ToString();
            }
        }
        private void BolmeFonk()
        {
            List<double> sayýlar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("Lütfen sayýlarý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                sayýlar = Sayi1TextBox.Text.Split('/').Select(double.Parse).ToList();
                double sonuc = sayýlar[0] / sayýlar[1];
                //uble sayi1 = Convert.ToDouble(Sayi1TextBox.Text);


                SonucLabel.Text =  sonuc.ToString();
            }
        }

        private void CarpmaFonk()
        {
            List<double> sayýlar = new List<double>();
            if (string.IsNullOrWhiteSpace(Sayi1TextBox.Text))
            {
                MessageBox.Show("Lütfen sayýlarý girin.", "Uyarý", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                String sayiTextBox = Sayi1TextBox.Text;
                sayiTextBox = sayiTextBox.Replace(" ", "");
                sayýlar = Sayi1TextBox.Text.Split('*').Select(double.Parse).ToList();
                double sonuc = sayýlar[0] * sayýlar[1];
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
            // Týklanan butonun metnini girdiye ekler
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