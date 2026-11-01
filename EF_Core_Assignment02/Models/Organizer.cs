using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Models
{
    [Table("EventOrganizers")]
    public class Organizer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = null!;

        [MaxLength(150)]
        public string? CompanyName { get; set; }


        // Relationship
        public ICollection<Event> Events { get; set; }

        public OrganizerProfile Profile { get; set; }



    }
}
