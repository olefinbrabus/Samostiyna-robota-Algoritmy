namespace Samostiyna_robota
{
    public partial class Account : Form
    {
        public Account(string text)
        {
            InitializeComponent();
            label1.Text = $"З початком роботи, {text}!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var text = textBox1.Text;

            label1.Text = $"До нової співпраці,{text}"!;
        }
    }
}
