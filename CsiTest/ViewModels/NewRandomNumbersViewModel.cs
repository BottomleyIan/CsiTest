using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace CsiTest.ViewModels
{
    public class NewRandomNumbersViewModel
    {
        public Dictionary<int, string> SortDirections { get; } = new Dictionary<int, string>
        {
            {1,  "Ascending"},
            {0, "Descending" }
        };

        [DisplayName("Unsorted Numbers")]
        public string UnsortedNumbers { get; set; }

        [DisplayName("Sort Direction")]
        public int SortDirection { get; set; } = 1;

        public bool IsAscending()
        {
            return SortDirection == 1;
        }
    }
}