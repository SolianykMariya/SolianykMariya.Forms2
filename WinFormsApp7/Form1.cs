namespace WinFormsApp7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox2.Text = Convert.ToString(3);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            int shift = Convert.ToInt32(textBox2.Text);
            string encryptedText = EncryptedText(Text, shift);
            textBox3.Text = encryptedText;
        }
        private string EncryptedText(string text, int shift)
        {
            string result = "";
            foreach (char c in text)
            {
                if (char.IsLetter(c))
                {
                    result += (char)(c + shift);
                }
              
            }
            return result;
        }

    }
}
