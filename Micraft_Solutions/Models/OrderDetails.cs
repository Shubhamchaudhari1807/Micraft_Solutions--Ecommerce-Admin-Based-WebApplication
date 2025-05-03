using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Micraft_Solutions.Models
{
    public class OrderDetails
    {
        public int Line_ID { get; set; }
        public Nullable<int> OrderID { get; set; }
        public Nullable<int> ProductCode { get; set; }
        public string Image { get; set; }
    }
}