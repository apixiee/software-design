using lab3.Classes;
using System.Net;
using System.Reflection;

namespace lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Task 1//
        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            int issueNumber = 45;
            Magazine myBook = new Magazine();
            myBook.Title = "Tech Weekly";
            myBook.Author = "John Doe";
            myBook.IssueNumber = issueNumber;

            txtTitle.Text = myBook.Title;
            txtAuthor.Text = myBook.Author;
            txtIssueNumber.Text = myBook.IssueNumber.ToString();

           
            MessageBox.Show(myBook.GetInfo());

        }
    }
}
