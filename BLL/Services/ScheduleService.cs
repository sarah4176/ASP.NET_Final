using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class ScheduleService
    {
        public static List<ScheduleDTO> Get()
        {
            var data = DataAccessFactory1.ScheduleData().Get();
            var mapper = MapperService<Schedule, ScheduleDTO>.GetMapper();
            return mapper.Map<List<ScheduleDTO>>(data);
        }
        public static ScheduleDTO Get(int id)
        {
            var data = DataAccessFactory1.ScheduleData().Get(id);
            var mapper = MapperService<Schedule, ScheduleDTO>.GetMapper();
            return mapper.Map<ScheduleDTO>(data);
        }
        public static bool Create(ScheduleDTO Schedule)
        {
            var mapper = MapperService<ScheduleDTO, Schedule>.GetMapper();
            var mapped = mapper.Map<Schedule>(Schedule);
            return DataAccessFactory1.ScheduleData().Create(mapped);

        }
        public static bool Update(ScheduleDTO Schedule)
        {
            var mapper = MapperService<ScheduleDTO, Schedule>.GetMapper();
            var mapped = mapper.Map<Schedule>(Schedule);
            return DataAccessFactory1.ScheduleData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.ScheduleData().Delete(id);

        }
        public static ScheduleDTO SendScheduleToServiceProvider(int serviceProviderId, int clientPhoneNumber, DateTime appointment)
        {
            var schedule = new Schedule
            {
                ServiceProviderId = serviceProviderId,
                ClientPhoneNumber = clientPhoneNumber,
                Appointment = appointment
            };

            var newSchedule = DataAccessFactory1.ScheduleData().Create(schedule);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Schedule, ScheduleDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedSchedule = mapper.Map<ScheduleDTO>(newSchedule);

            return mappedSchedule;
        }

        /*
        public static void Main(string[] args)
        {
           
            int serviceProviderId = 1;
            int clientPhoneNumber = 1234567890;
            DateTime appointment = DateTime.Now.AddDays(2); // Set the appointment date

            var result = SendScheduleToServiceProvider(serviceProviderId, clientPhoneNumber, appointment);

            Console.WriteLine($"Schedule sent with ID: {result.Id}");
        }
        */

    }
}
