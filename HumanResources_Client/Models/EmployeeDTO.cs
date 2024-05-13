using System.ComponentModel.DataAnnotations;

namespace HumanResources_Client.Models
{
    public class EmployeeDTO
    {
        
        public string EmployeeID { get; set; }

        public string StaffIDNo { get; set; }

        public string Title { get; set; }

        public string Surname { get; set; }

        public string OtherNames { get; set; }
    }
}
