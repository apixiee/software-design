using MaterialSkin.Controls;
using System;

namespace Task5._2
{
    public partial class Form1 : MaterialForm
    {
        int[] originalNumbers = { 5, 1, 3, 2, 4 };

        Sorter sorter;
        public Form1()
        {
            InitializeComponent();

            sorter = new Sorter(originalNumbers);
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            foreach (int num in originalNumbers)
            {
                listBoxResults.Items.Add(num);
            }
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            listBoxResults.Items.Clear();

            sorter.ArraySortDescending();

            foreach (int num in sorter.Numbers)
            {
                listBoxResults.Items.Add(num);
            }


        }

        private void listBoxResults_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
