using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Vroom.Extension;

namespace Vroom.Models
{
    public class Bike
    {
        public int Id { get; set; }

        
        public Make Make { get; set; }
        [Required]
        [RegularExpression("^[1-9]", ErrorMessage = "Select Make of bike*")]
        [Display(Name = "Make :")]
        public int MakeId { get; set; }

        
        public Model Model { get; set; }
        [Required]
        [RegularExpression("^[1-9]", ErrorMessage = "Select Model of bike*")]
        [Display(Name = "Model :")]
        public int ModelId { get; set; }

        [Required]
        [Display(Name = "Year :")]
        [TillDate(1980,ErrorMessage ="Invalid Year")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Milleage :")]
        [Range(1, int.MaxValue, ErrorMessage = "Provide Milleage*")]
        public int Milleage { get; set; }

        [Display(Name = "Features :")]
        public string Features { get; set; }

        [Required(ErrorMessage ="Provide Seller Name *")]
        [Display(Name ="Seller Name :")]
        public string SellerName { get; set; }

        [Display(Name = "Seller Email :")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string SellerEmail { get; set; }

        [Required(ErrorMessage ="Provide Seller Phone*")]
        [Display(Name = "Seller Phone :")]
        public string SellerPhone { get; set; }

        [Required]
        [RegularExpression("^[1-9]", ErrorMessage = "Give your vehicle a price*")]
        [Display(Name = "Price :")]
        public int Price { get; set; }

        [Required]
        [RegularExpression("^[a-z]", ErrorMessage = "Select currency*")]
        [Display(Name = "Currency :")]
        public string Currency { get; set; }


        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
    }
}
