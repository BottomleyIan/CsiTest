﻿using CsiTest.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Numerics;

namespace CsiTest.Models
{
    public class RandomNumber
    {
        public int Id { get; set; }

        [DisplayName("Sort Time (millis)")]
        public int Millis { get; set; }

        [DisplayName("Sorted Numbers")]
        public string SortedNumbers { get; set; }

        [DisplayName("Sorted Direction")]
        public bool Ascending { get; set; }

        public RandomNumber() { }

        public RandomNumber(NewRandomNumbersViewModel newRandomNumbers)
        {
            Ascending = newRandomNumbers.IsAscending();
            Stopwatch stopwatch = Stopwatch.StartNew();

            SortedNumbers = SortNumbers(newRandomNumbers.UnsortedNumbers);

            //int will be large enough for this.
            Millis = (int)stopwatch.ElapsedMilliseconds;
        }

        private string SortNumbers(string unsortedNumbers)
        {
            Regex isNumber = new Regex(@"^\s*[-+]?[0-9]+\s*$", RegexOptions.Compiled);
            var query = from s in unsortedNumbers.Split(',')
                        where isNumber.IsMatch(s)
                        select s.Trim();
            int max_length = query.Max(s => s.Length);
            if (max_length < 10)
            {
                if (Ascending)
                {
                    query = query.OrderBy(x => int.Parse(x));
                }
                else
                {
                    query = query.OrderByDescending(x => int.Parse(x));
                }
            }else
            {
                if (Ascending)
                {
                    query = query.OrderBy(x => BigInteger.Parse(x));
                }
                else
                {
                    query = query.OrderByDescending(x => BigInteger.Parse(x));
                }
            }
            return string.Join(", ", query);
        }
    }
}