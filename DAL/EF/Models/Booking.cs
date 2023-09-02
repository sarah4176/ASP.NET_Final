using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Booking
    {

        [Key]
        public int Id { get; set; }
        [Required]
        public string ServiceType { get; set; }
        [Required]
        public DateTime ServiceDate { get; set; }
      
        [ForeignKey("Client")]
        [Required]
        public int ClientId { get; set; }

        public virtual Client Client { get; set; }



    }
}
