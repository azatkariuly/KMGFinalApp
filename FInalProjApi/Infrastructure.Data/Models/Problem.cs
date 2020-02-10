using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Models
{
    [Table("problem")]
    public class Problem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        //Foreign Key
        public int? UserId { get; set; }
        
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        
        //Foreign Key
        public int? StatusId { get; set; }
        
        [ForeignKey(nameof(StatusId))]
        public Status Status { get; set; }
    }
}