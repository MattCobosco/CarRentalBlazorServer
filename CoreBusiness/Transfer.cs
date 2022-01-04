using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBusiness
{
    public class Transfer
    {
        public int TransferId { get; set; }
        public string FromBranch { get; set; }
        public string ToBranch { get; set; }
        public DateTime Date { get; set; }
        public int EmployeeId { get; set; }
        public int FleetVehicleId { get; set; }
    }
}
