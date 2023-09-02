using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class IssueNotification
    {
        [Key] 
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }       
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}
