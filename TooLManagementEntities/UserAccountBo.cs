using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TooLManagementEntities
{
    public class UserAccountBo
    {
        public int UserID { get; set; }
        public string  FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
        public string Mobile { get; set; }
        public string UserName { get; set; }
        public string JobTittle { get; set; }
        public string DepartMent { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Notes { get; set; }
        public bool IsAdmin { get; set; }
        public string AccessLevel { get; set; }


        public bool AllowGeneral { get; set; }
        public bool AllowItemMnagement { get; set; }
        public bool AllowInventory { get; set; }
        public bool AllowJobs { get; set; }
        public bool AllowReports { get; set; }
        public bool AllowSupplier { get; set; }
        public bool AllowConfiguration { get; set; }
    }
}
