using Lab3_Task2.Class_Task_2;
using Lab3_Task2.Class_Task_3;

namespace Lab3_Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void DisplayBooks(Book2[] books)
        {
            lstBooks.Items.Clear();

            foreach (Book2 b in books)
            {
                // Polymorphism happens here
                lstBooks.Items.Add(b.GetInfo());
            }
        }


        private void lstBooks_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            Book2[] books = new Book2[5];

            books[0] = new Book2("The Hobbit", "J.R.R. Tolkien");
            books[1] = new Magazine2("Tech Weekly", "John Doe", 45);
            books[2] = new Ebook2("Learn C#", "Jane Smith", 5.8);
            books[3] = new TextBook("Physics 101", "Albert Newton", "Science");
            books[4] = new AudioBook("Harry Potter", "J.K. Rowling", 12.5, "Stephen Fry");

            DisplayBooks(books);
        }
    }
}
