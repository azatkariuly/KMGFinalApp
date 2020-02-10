using System;

namespace Infrastructure.Data.Dtos
{
    public class ProblemDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        
        //Foreign Key
        public int UserId { get; set; }
        
        //Foreign Key
        public int StatusId { get; set; }
    }
}