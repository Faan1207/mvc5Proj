using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace BookStore.Models
{
    public class Book
    {
        //Simple Regex to fit the basic structure provided for book id
        [RegularExpression(@"^[a-zA-Z0-9]{8}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{12}")]
        [Display(Name = "Book ID")]
        [Required]
        public string Id { get; set; }
        
        [Display(Name = "Book Title")]
        [Required]
        public string BookName { get; set; }

        public bool Reserved { get; set; } = false;
    }
}