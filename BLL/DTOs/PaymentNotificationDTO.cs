using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PaymentNotificationDTO
    {
        [Key]
        public int id { get; set; }
        public string SenderName { get; set; }
        [Required]
        public int PaymentId { get; set; }
    }
}
