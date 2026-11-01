using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Models
{
    public class OrganizerProfile
    {
        public int Id { get; set; }

        public string Biography { get; set; } = null!;

        public string Website { get; set; } = null!;

        public string Logo { get; set; } = null!;

        // Relationship
        public int OrganizerId { get; set; }
        public Organizer Organizer { get; set; }

    }
}
