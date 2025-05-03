using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Micraft_Solutions.Models
{
    public class Ragister
    {
        public int customer_id { get; set; }

        [Required(ErrorMessage = "Please Enter Customer Name")]
        [MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string customer_name { get; set; }

        [Required(ErrorMessage = "Enter the email Addres")]
        [EmailAddress(ErrorMessage = "Please Enter Valid Email")]
        public string email_id { get; set; }

        [Required(ErrorMessage = "This field is required ")]
        [RegularExpression(@"^[+-]?(?=.?\d)\d*(\.\d{0,9})?$", ErrorMessage = "Please enter valid input")] // this expression only pass the numaric data to fild.
        [StringLength(12, MinimumLength = 10, ErrorMessage = "Mobile number should be minimum 10 digit and maximum 12 digit")]
        public string contact_no { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "This field is required ")]
        public string password { get; set; }
        public string customer_address { get; set; }


    }
}