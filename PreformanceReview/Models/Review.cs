using System;
using System.Collections.Generic;

namespace PreformanceReview.Models
{
    public class Review
    {
        public string EmployeeNumber { get; set; }
        public DateTime ReviewDate { get; set; }
        public IList<string> Reviewers { get; set; }
        public IList<string> ReviewComments { get; set; }
        public string ReviewResult { get; set; }
    }
}