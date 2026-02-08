using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Lab3_Task2.Class_Task_2
{
    public class Ebook2 : Book2
    {
        public double FileSizeMB { get; set; }

        public Ebook2 (string author, string title, double  fileSize) : base(title, author)
        {
            FileSizeMB = fileSize;
        }

        public override string GetInfo()
        {
            return $"Ebook : {Title} by {Author} ({FileSizeMB} MB)";
        }
    }
}
