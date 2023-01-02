using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace chat_application.MessageDB.Models
{
    [Table("Saved_messages")]
    public class Saved_message
    {
        [Key]
        public int Id { get; set; }
        [Required, StringLength(255)]
        public string UserId { get; set; }
        [Required, StringLength(255)]
        public string UserName { get; set; }
        [Required, StringLength(255)]
        public string Text { get; set; }
        [Required, StringLength(255)]
        public string Photo { get; set; }
    }
}
