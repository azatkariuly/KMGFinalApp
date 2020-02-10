using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace Infrastructure.Data.Models
{
    [Table("user")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string FName { get; set; }    // First Name
        public string LName { get; set; }    // Last Name
        public string Email { get; set; }
        
        //public List<Problem> Problems { get; set; }
    }
}