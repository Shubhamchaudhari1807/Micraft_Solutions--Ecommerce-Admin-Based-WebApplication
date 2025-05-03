using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Micraft_Solutions.Models
{
    public class Product
    {
        public int Product_Id { get; set; }
        [Required(ErrorMessage = "Please Enter Product Code")]
        public string Product_Code { get; set; }
        [Required(ErrorMessage = "Please Enter Product Name")]
        [MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string Product_Name { get; set; }
        public HttpPostedFileBase Product_Image { get; set; }
        //public string Product_Image { get; set; }
        [Required(ErrorMessage = "Please Enter Product Unit")]
        [MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string Product_Unit { get; set; }
        //[Required(ErrorMessage = "Please Enter Product Rate")]
        //[MaxLength(50, ErrorMessage = "Max Characher allow 50")]
        //[MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public Nullable<decimal> Product_Rate { get; set; }
        [Required(ErrorMessage = "Please Enter Product Description")]
        [MaxLength(200, ErrorMessage = "Max Characher allow 200")]
        [MinLength(2, ErrorMessage = "Min Characher allow 2")]
        public string Product_Description { get; set; }
        public string image_path { get; set; }
    }
}