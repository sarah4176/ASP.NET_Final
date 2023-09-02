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
    public class BookingDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ServiceType { get; set; }
        [Required]
        public DateTime ServiceDate { get; set; }
        [Required]
        public int ClientId { get; set; }

    }
}
