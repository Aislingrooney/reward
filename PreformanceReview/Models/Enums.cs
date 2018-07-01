using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PreformanceReview.Models
{
    public class Enums
    {
        public enum Title {
            Ms,
            Miss,
            Mrs,
            Mr,
            Dr,
            Other
        }

        public enum Department {
            HumanResources,
            IT,
            Finance,
            Marketing,
            Sales
        }
    }
}