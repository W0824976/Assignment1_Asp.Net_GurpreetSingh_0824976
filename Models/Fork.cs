using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gurdeep_Fork_Assignment.Models
{
    public class Fork
    {
        public int Id { get; set; }

        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Brand { get; set; }

        public string Model { get; set; }

        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 3)")]
        public decimal Price { get; set; }

        [Required]
        [StringLength(30)]
        public string HandleMaterial { get; set; }

        public int TineCount { get; set; }

        [Required]
        public RateScale Rating { get; set; }
    }

    public enum RateScale
    {
        [Display(Name = "One Star")]
        One = 1,

        [Display(Name = "Two Star")]
        Two = 2,

        [Display(Name = "Three Star")]
        Three = 3,

        [Display(Name = "Four Star")]
        Four = 4,

        [Display(Name = "Five Star")]
        Five = 5
    }
  

}
