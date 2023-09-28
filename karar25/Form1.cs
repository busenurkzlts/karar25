namespace karar25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double kuvvet;
            for (int i = 0; i < 5; i++)
            {
                kuvvet = Math.Pow(10, i);
                listBox1.Items.Add(kuvvet);
            }
        }
    }
}