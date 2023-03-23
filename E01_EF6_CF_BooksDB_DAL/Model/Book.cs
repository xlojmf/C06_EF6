﻿using System.ComponentModel.DataAnnotations;

namespace E01_EF6_CF_BooksDB_DAL
{

    public class Book
    {

        #region Scalar properties
        // PK
        public int BookID { get; set; }

        // FK
        public int PublisherID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "100 character limit.")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(9, ErrorMessage = "9 character limit.")]
        [MaxLength(9)]
        public string ISBN { get; set; }

        /*
        [Required]
        [StringLength(100, ErrorMessage = "100 character limit.")]
        [MaxLength(100)]
        public string DDC { get; set; }     // Dewey Decimal Classification
        */
        #endregion

        #region Navigation properties
        public Publisher Publisher { get; set; }
        #endregion

    }

}
