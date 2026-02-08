using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Task2.Class_Task_2
{
    public class Book2
    {
        public string Title { get; set; }
        public string Author { get; set; }

        public Book2 (string title, string author)
        {
            Title = title;
            Author = author;
        }
        public virtual string GetInfo()
        {
            return $"Book : {Title} by {Author}";
        }
    }
}
