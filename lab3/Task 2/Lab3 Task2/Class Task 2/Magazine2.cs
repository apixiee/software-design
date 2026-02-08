using System;
using System.Collections.Generic;
using System.Text;

namespace Lab3_Task2.Class_Task_2
{
    public class Magazine2 : Book2
    {
        public int IssueNumber { get; set; }

        public Magazine2 ( string title , string author, int issueNumber) : base (title , author)
        {
            IssueNumber = issueNumber;
        }

        public override string GetInfo()
        {
            return $"Magazine : {Title} by {Author} - IssueNumber : {IssueNumber}";
        }
    }
}
