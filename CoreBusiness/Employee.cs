using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreBusiness
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public string Guid { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BranchId { get; set; }

        // Navigation properties for EF Core
        public Branch Branch { get; set; }
        public List<Assignment> Assignments { get; set; }
    }
}
