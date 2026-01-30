namespace Task3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        private void btnFibonacci_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtFibonacciInput.Text);
            int result = Fibonacci(n);
            lblFibonacciResult.Text = "Result: " + result;
        }
    }
}
