using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Classes
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{"Tech Weekly"} - Issue {IssueNumber}";
        }
    }
}
