using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class BookingNotification
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [ForeignKey("Booking")]
        [Required]
        public int BookingIdNo { get; set; }
        [ForeignKey("Client")]
        [Required]
        public int IdOfClient { get; set; }
        public virtual Booking Booking { get; set; }
        public virtual Client Client { get; set; }
    }
}
