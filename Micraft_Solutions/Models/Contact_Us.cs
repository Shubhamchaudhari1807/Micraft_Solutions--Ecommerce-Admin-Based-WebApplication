using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Micraft_Solutions.Models
{
    public class Contact_Us
    {
        public int cust_id { get; set; }
        [Required(ErrorMessage = "Please Enter item Name")]
        [MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string Full_Name { get; set; }
        [Required(ErrorMessage = "Enter the email Addres")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Enter Message")]
        [MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string Customer_Message { get; set; }
        public string attribute1 { get; set; }
    }
}