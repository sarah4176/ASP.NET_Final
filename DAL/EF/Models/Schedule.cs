using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime Appointment { get; set; }
        [Required]

        [ForeignKey("SrviceProvider")] 
        public int ServiceProviderId { get; set; }
        [Required]
        [ForeignKey("Client")] 
        public int ClientPhoneNumber { get; set; }
        public virtual Client Client { get; set; } 
        public virtual SrviceProvider SrviceProvider { get; set; } 


    }
}
