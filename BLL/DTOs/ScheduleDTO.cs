using DAL.EF.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class ScheduleDTO
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime Appointment { get; set; }
        [Required]
        public int ServiceProviderId { get; set; }
        [Required]
        public int ClientPhoneNumber { get; set; }
    }
}
