using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcUploadFile.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Role { get; set; }


        public virtual IList<EmployeeAttachment> EmployeeAttachments { get; set; }
    }
}
