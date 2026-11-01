using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_Assignment02.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public int BadgeNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public string Tier { get; set; } = null!;

        // Relationship
        public int AttendeeId { get; set; }
        public Attendee Attendee { get; set; } = null!;

    }
}
