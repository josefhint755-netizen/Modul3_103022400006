namespace Modul3_103022400006
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih satuan terlebih dahulu!");
                return;
            }

            double nilaiAwal;

            if (!double.TryParse(textBox1.Text, out nilaiAwal))
            {
                MessageBox.Show("Masukkan angka yang valid!");
                return;
            }

            string satuanAwal = comboBox1.SelectedItem.ToString();
            string satuanAkhir = comboBox2.SelectedItem.ToString();

            double hasil = 0;

            if (satuanAwal == "Celcius" && satuanAkhir == "Fahrenheit")
            {
                hasil = (nilaiAwal * 9 / 5) + 32;
            }
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Celcius")
            {
                hasil = (nilaiAwal - 32) * 5 / 9;
            }
            else if (satuanAwal == "Celcius" && satuanAkhir == "Kelvin")
            {
                hasil = nilaiAwal + 273.15;
            }
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Celcius")
            {
                hasil = nilaiAwal - 273.15;
            }
            else if (satuanAwal == "Fahrenheit" && satuanAkhir == "Kelvin")
            {
                hasil = (nilaiAwal - 32) * 5 / 9 + 273.15;
            }
            else if (satuanAwal == "Kelvin" && satuanAkhir == "Fahrenheit")
            {
                hasil = (nilaiAwal - 273.15) * 9 / 5 + 32;
            }


            textBox2.Text = hasil.ToString();

        }
    }
}
