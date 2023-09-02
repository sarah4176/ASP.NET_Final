using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PaymentDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime ReceiveDate { get; set; }
        [Required]
        public int Salary { get; set; }
    }
}
