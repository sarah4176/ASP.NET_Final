using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Models
{
    public class PaymentNotification
    {
        [Key]
        public int id { get; set; }
        public string SenderName { get; set; }
        [ForeignKey("Payment")]
        [Required]
        public int PaymentId { get; set; }
        public virtual Payment Payment { get; set; }

    }
}
