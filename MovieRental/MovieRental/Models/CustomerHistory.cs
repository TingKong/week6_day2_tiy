using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental.Models
{
    public class CustomerHistory
    {
        [DisplayName("Movie Name")]
        public Movie CustMovie { get; set; }

        [DisplayName("Customer")]
        public Customer Cust{ get; set; }



        [DisplayName("Date Rented")]
        //[PlaceHolder("01/01/2016")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime RentalDate { get; set; }


        [DisplayName("Date Returned")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> ReturnDate { get; set; }


        MovieRentalEntities db = new MovieRentalEntities();



    }
}
