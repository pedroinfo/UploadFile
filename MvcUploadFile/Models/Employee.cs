using System.Collections.Generic;

namespace MvcUploadFile.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        public string Name { get; set; }

        public string Role { get; set; }


        public virtual IList<EmployeeAttachment> EmployeeAttachments { get; set; }
    }
}
