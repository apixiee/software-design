namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private long Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int number = int.Parse(txtFactorialInput.Text);
            long result = Factorial(number);
            lblFactorialResult.Text = "Result: " + result;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
