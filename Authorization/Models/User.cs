using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Authorization.Models
{
    [Table("UsersDB")]
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string Email { get; set; }
        [Required, StringLength(255)]
        public string Password { get; set; }
    }
}
