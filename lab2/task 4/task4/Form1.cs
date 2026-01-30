namespace task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int Power(int x, int n)
        {
            if (n == 0) return 1;
            return x * Power(x, n - 1);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            int baseNum = int.Parse(txtBase.Text);
            int exponent = int.Parse(txtExponent.Text);
            int result = Power(baseNum, exponent);
            lblPowerResult.Text = "Result: " + result;
        }
    }
}
