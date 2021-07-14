using System.ComponentModel.DataAnnotations.Schema;

namespace MvcUploadFile.Models
{
    public class EmployeeAttachment
    {
        public int EmployeeAttachmentId { get; set; } // PK

        public byte[] Bytes { get; set; }

        public string AttachmentName { get; set; }

        public string ContentType { get; set; }

        public long ContentLenght { get; set;  }

        public virtual int EmployeeId { get; set; } // FK
        public virtual Employee Employee { get; set; } //Navigation
    }
}
