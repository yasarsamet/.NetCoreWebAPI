using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Users
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(50)] 
        [Required]
        public string Name { get; set; }

        [StringLength(50)]
        [Required]
        public string Password{ get; set; }
    }
}
