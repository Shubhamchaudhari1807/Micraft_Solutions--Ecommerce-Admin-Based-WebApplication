using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace Micraft_Solutions.Models
{
    public class Order
    {
        public int Order_Id { get; set; }
        public Nullable<System.DateTime> Order_Date { get; set; }
        public Nullable<int> Customer_Id { get; set; }
        public string Total_Qty { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
    }
}