using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace adresDefterApp.Models
{
    public class Kisiler
    {
          //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          [Key]
         public int Id { get; set; }
        [Required]
       [StringLength(20)]
        public string Ad { get; set; }
       [Required]
        [StringLength(40)]
        public string SoyadAd { get; set; }
        [EmailAddress]
        [StringLength(200)]
        public string Email { get; set; }
        [StringLength(15)]
        public string Telefon { get; set; }

    }
}