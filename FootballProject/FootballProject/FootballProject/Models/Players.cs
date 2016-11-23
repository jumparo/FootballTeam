using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace FootballProject.Models
{
    public  class Players
    {
        [Key]
        public int id { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "You should enter your name! ")]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string Name { get; set; }

        [Required(ErrorMessage = "You should enter your born date! ")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Birthday { get; set; }

        [Display (Name="ID number")]
        public long IdNumber { get; set; }

        [Required(ErrorMessage ="You should enter your born city! ")]
        [Display(Name = "Born city")]
        [StringLength(60, MinimumLength = 3)]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string BornCity { get; set; }

        [Required(ErrorMessage = "You should enter your unique number! ")]
        [Display(Name = "Unique number")]
       
        public int UniqueNumber { get; set; }
      
        [Display(Name = "Enter your height in santimeters")]
        [Range(80, 240)]
        [Required(ErrorMessage = "You should enter your height! ")]
        public double Height { get; set; }

        [Required(ErrorMessage = "You should enter your salary! ")]
        [Range(400, 10000)]
        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

    }
    
}