using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    [Table("Comentarios")]
    public class Commentarios
    {
         public int Id { get; set; }

        public string Title { get; set; } = string.Empty;
        
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public int? StockId { get; set; }

        public Stocks? Stocks  { get; set; }

        public string AppUserId {get; set;}

        public AppUser AppUser {get; set;}
    }
} 
