using Microsoft.AspNetCore.Connections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Task_Management__ystem.Domain.Common;

namespace Task_Management__ystem.Domain
{
    public class Role: BaseAuditableEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [ForeignKey(nameof(Status))]
        public Guid? StatusId { get; set; }
        public Status? Status { get; set; }
    }
}
