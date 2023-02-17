using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using System.Data.Entity;

namespace BookStore.Models
{
    //Stores information on which books has been reserved
    public class ReservationEvents
    {   
        //This will be a simple unique booking number
        public Guid Id { get; set; }

        //Simple Regex to fit the basic structure provided for book id
        //Foreign key to book's id
        [RegularExpression(@"^[a-zA-Z0-9]{8}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{4}\-[a-zA-Z0-9]{12}")]
        [Display(Name = "Book ID")]
        [Required]
        public string BookId { get; set; }

        [Display(Name = "Book Title")]
        [Required]
        public string BookName { get; set; }
        
    }
}