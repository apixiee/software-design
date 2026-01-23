using MaterialSkin.Controls;

namespace Task5._1
{
    public partial class Form1 : MaterialForm
    {
        int[] numbers = { 5, 2, 9, 1, 3, 7, 4 };
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            BubbleSort(numbers);

            foreach (int num in numbers)
            {
                listBoxResults.Items.Add(num);
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            foreach (int num in numbers)
            {
                listBoxResults.Items.Add(num);
            }
        }

        private void BubbleSort(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                       
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
