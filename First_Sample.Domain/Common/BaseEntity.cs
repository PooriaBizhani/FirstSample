using System.ComponentModel.DataAnnotations;

namespace First_Sample.Domain.Common
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
