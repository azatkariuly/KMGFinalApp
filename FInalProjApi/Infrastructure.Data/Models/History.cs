using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Infrastructure.Data.Models
{
    public class History
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Action { get; set; }

        //Foreign Key
        public int UserId { get; set; }
        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
        
        //Foreign Key 
        public int ProblemId { get; set; }
        [ForeignKey(nameof(ProblemId))]
        public Problem Problem { get; set; }

    }
}