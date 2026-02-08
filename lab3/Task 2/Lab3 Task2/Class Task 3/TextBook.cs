using Lab3_Task2.Class_Task_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Task2.Class_Task_3
{
    public class TextBook : Book2
    {
        public string Subject { get; set; }

        public TextBook(string title, string author, string subject) : base(title, author)
        {
            Subject = subject;
        }

        public override string GetInfo()
        {
            return $"Textbook : {Title} by {Author} (Subject : {Subject})";
        }
    }
}
