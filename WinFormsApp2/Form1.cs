namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public static int Soma(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1 = Convert.ToInt32(textBox1.Text);
            int n2 = Convert.ToInt32(textBox2.Text);
            int resultado = Soma(n1, n2);
            MessageBox.Show($"A soma entre os números é: {resultado}");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
