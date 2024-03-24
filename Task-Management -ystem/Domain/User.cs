using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task_Management__ystem.Domain.Common;

namespace Task_Management__ystem.Domain
{
    public class User : BaseAuditableEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Username { get; set; }

        public string UserId { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [ForeignKey(nameof(Role))]
        public Guid? RoleId { get; set; }
        public Role? Role { get; set; }

        [ForeignKey(nameof(Status))]
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }

    }
}
