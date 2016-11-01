using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MovieRental
{
    [MetadataType(typeof(CustomerMetaData))]

    public partial class Customer
    {
    }


    public class CustomerMetaData
    {

        [DisplayName("Customer Name")]
        public string CustomerName { get; set; }
        [Required(ErrorMessage = "You must enter a Customer Name")]


        [DisplayName("Phone Number")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(DataFormatString = "{0:###-###-####}", ApplyFormatInEditMode = true)]
        public string CustomerPhone { get; set; }

        public virtual ICollection<RentalRecord> RentalRecords { get; set; }
    }

    [MetadataType(typeof(MovieMetaData))]
    public partial class Movie
    {

    }

    public class MovieMetaData
    {
        [DisplayName("Movie Name")]
        [Required(ErrorMessage = "You must enter a movie name")]
        [MaxLength(100, ErrorMessage = "Movie name must be 100 character or less")]
        public string MovieName { get; set; }

        [DisplayName("Description")]
        [MaxLength(200, ErrorMessage = "Movie name must be 200 character or less")]
        public string MovieDescription { get; set; }

        [DisplayName("Genre")]
        public Nullable<int> MovieGenre { get; set; }

    }

    [MetadataType(typeof(GenreMetaData))]
    public partial class Genre
    {

    }

    public class GenreMetaData
    {
        [DisplayName("Genre")]
        [Required(ErrorMessage = "You must enter genre")]
        [MaxLength(100, ErrorMessage = "Movie name must be 100 character or less")]
        public string GenreName { get; set; }


    }

    [MetadataType(typeof(RentalRecordMetaData))]
    public partial class RentalRecord
    {

    }

    public class RentalRecordMetaData
    {
        

        [DisplayName("Movie Name")]
        public int MovieID { get; set; }


        [DisplayName("Customer")]
        public int CustomerID { get; set; }


        [DisplayName("Date Rented")]
        //[PlaceHolder("01/01/2016")]
        [Required(ErrorMessage = "You must enter a rental date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime RentalDate { get; set; }

        [DisplayName("Date Due")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public System.DateTime DueDate { get; set; }

        [DisplayName("Date Returned")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}")]
        public Nullable<System.DateTime> ReturnDate { get; set; }
    }




}