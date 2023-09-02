using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Issue
    {
        [Key] 
        public int Id { get; set; }
        [Required] 
        public string Description { get; set; }
        [ForeignKey("Client")]
        [Required]
        public int IssueByClientId { get; set; }

        public virtual Client Client { get; set; }


    }
}
