 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FootballProject.Models
{
    public class FootballTeam
    {
        [Key]
        public int id { get; set; }
        [Required (ErrorMessage ="You should enter your name! ")]
        [Display(Name ="Name")]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string NameOfTheTeam { get; set; }
        [Required(ErrorMessage = "You should enter the year when the club is founded! ")]
        [Display(Name = "Year")]
        [Range(1880,2016)]
        public int YearFound { get; set; }
        [Display(Name = "Stadium")]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string Stadium { get; set; }
        [Required(ErrorMessage = "You should enter the name of the owner! ")]
        [Display(Name = "Owner")]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string Owner { get; set; }
        [Display(Name = "Coach")]
        [RegularExpression(@"^\S\n]*([^<\n]+<[^>\n]*\@[^>\n]*>)|.*$", ErrorMessage = "only letters are allowed")]
        public string Coach { get; set; }
        [Display(Name = "Website")]
       
         [RegularExpression(@"((file|gopher|news|nntp|telnet|http|ftp|https|ftps|sftp)://)+(([a-zA-Z0-9\._-]+\.[a-zA-Z]{2,15})|([0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}))(/[a-zA-Z0-9\&amp;%_\./-~-]*)?"
, ErrorMessage = "Please enter valid url of your website")]
        public string Website { get; set; }





    }


}