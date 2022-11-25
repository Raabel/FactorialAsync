namespace FactorialAsync
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            ulong n = ulong.Parse(textBox1.Text);
            Task<ulong> task = Task.Run(() => (
                Factorial(n)));
            ulong result = await task;
            textBox1.Text = result.ToString();    
        }

        private ulong Factorial(ulong n)
        {
            if (n == 0)
                return 1;

            else
                return n * Factorial(n-1);
            
        }

    }
}