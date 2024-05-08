namespace Samostiyna_robota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox3.Text)
            {
                Account a = new Account(textBox2.Text);
                a.ShowDialog();
            }
        }
    }
}
