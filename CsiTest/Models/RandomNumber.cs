using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CsiTest.Models
{
    public class RandomNumber
    {
        public int Id { get; set; }

        [DisplayName("Sort Time (millis)")]
        public int Millis { get; set; }

        [DisplayName("Sorted Numbers")]
        public string SortedNumbers { get; set; }
        public bool Ascending { get; set; }
    }
}