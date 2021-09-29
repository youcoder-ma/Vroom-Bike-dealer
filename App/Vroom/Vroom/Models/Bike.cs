using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Vroom.Models
{
    public class Bike
    {
        public int Id { get; set; }

        [Display(Name = "Make :")]
        public Make Make { get; set; }
        public int MakeId { get; set; }

        [Display(Name = "Model :")]
        public Model Model { get; set; }
        public int ModelId { get; set; }

        [Required]
        [Display(Name = "Year :")]
        public int Year { get; set; }

        [Required]
        [Display(Name = "Milleage :")]
        public int Milleage { get; set; }

        [Display(Name = "Features :")]
        public string Features { get; set; }

        [Required]
        [Display(Name ="Seller Name :")]
        public string SellerName { get; set; }

        [Display(Name = "Seller Email :")]
        public string SellerEmail { get; set; }

        [Required]
        [Display(Name = "Seller Phone :")]
        public string SellerPhone { get; set; }

        [Required]
        [Display(Name = "Price :")]
        public int Price { get; set; }

        [Required]
        [Display(Name = "Currency :")]
        public string Currency { get; set; }


        [Display(Name = "Upload Image")]
        public string ImagePath { get; set; }
    }
}
