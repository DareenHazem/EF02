using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Models
{
    [Table("AttendeeTable")]
    public class Attendee
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FullName { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(150)]
        public string Street { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string City { get; set; } = null!;

        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = null!;

        [Required]
        [MaxLength(20)]
        [Column(name: "ZipCode")]
        public string PostalCode { get; set; } = null!;

        [NotMapped]
        public string FullAddress =>$"{Street}, {City}, {Country}, {PostalCode}";


        // Relationship
        public Badge? Badge { get; set; }


    }
}
