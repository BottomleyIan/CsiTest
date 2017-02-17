using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CsiTest.Models
{
    public class RandomNumber
    {
        public int Id { get; set; }
        public int Millis { get; set; }
        public string SortedNumbers { get; set; }
        public bool Ascending { get; set; }
    }
}