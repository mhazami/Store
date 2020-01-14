using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataStracture
{
    [Table("User", Schema = "Security")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }

        [MaxLength(150), Required]
        public string Name { get; set; }

        [MaxLength(150), Required]
        public string Family { get; set; }

        [MaxLength(10), Required]
        public string Username { get; set; }

        [MaxLength(10), Required]
        public string Password { get; set; }

        [MaxLength(10), Required]
        public string CreateDate { get; set; }

        [MaxLength(5), Required]
        public string CreateTime { get; set; }

        [NotMapped]
        public string RepeatPassword { get; set; }
    }
}
