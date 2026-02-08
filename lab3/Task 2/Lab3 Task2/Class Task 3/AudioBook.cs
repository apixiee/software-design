using Lab3_Task2.Class_Task_2;
using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Task2.Class_Task_3
{
    public class AudioBook : Book2
    {
        public string Narrator { get; set; }
        public double Duration { get; set; }

        public AudioBook(string title, string author, double duration, string narrator) : base(title, author)
        {
            Duration = duration;
            Narrator = narrator;
        }

        public override string GetInfo()
        {
            return $"AudioBook: {Title} by {Author}" + $"Duration : {Duration} hrs, Narrator: {Narrator}";
        }
    }
}
