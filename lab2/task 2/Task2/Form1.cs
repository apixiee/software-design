namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int RecursiveSum(int[] arr, int index)
        {
            if (index == arr.Length)
                return 0;

            return arr[index] + RecursiveSum(arr, index + 1);
        }
        private void btnCalculateSum_Click(object sender, EventArgs e)
        {
            string[] values = txtArrayInput.Text.Split(',');
            int[] numbers = Array.ConvertAll(values, int.Parse);
            int sum = RecursiveSum(numbers, 0);
            lblSumResult.Text = "Sum: " + sum;
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
      
    }
}
