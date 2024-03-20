namespace hw1_computer_windowApp
{
    public partial class Form1 : Form
    {
        public static double r = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r1 = Math.Round(r, 4); //四舍五入到小数点后四位
            textBox3.Text = Convert.ToString(r1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            r = Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}