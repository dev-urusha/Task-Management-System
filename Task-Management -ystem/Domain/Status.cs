using System.ComponentModel.DataAnnotations;
using Task_Management__ystem.Domain.Common;

namespace Task_Management__ystem.Domain
{
    public class Status: BaseAuditableEntity
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Type { get; set; }
    }
}
