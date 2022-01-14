using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CoreBusiness
{
    public class AssignmentType
    {
        public int AssignmentTypeId { get; set; }
        [Required]
        public string Type { get; set; }

        // Navigation properties for EF Core
        public List<Assignment> Assignments { get; set; }
    }
}
