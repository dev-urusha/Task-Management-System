using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Task_Management__ystem.Domain.Common;

namespace Task_Management__ystem.Domain
{
    public class Assignment : BaseAuditableEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string TaskID { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime? DueDate { get; set; }

        [ForeignKey(nameof(User))]
        public Guid? UserId { get; set; }
        public User? User { get; set; }

        [ForeignKey(nameof(Status))]
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
