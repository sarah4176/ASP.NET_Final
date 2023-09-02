using AutoMapper;
using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BookingService
    {
        public static List<BookingDTO> Get()
        {
            var data = DataAccessFactory1.BookingData().Get();
            var mapper = MapperService<Booking, BookingDTO>.GetMapper();
            return mapper.Map<List<BookingDTO>>(data);
        }
        public static BookingDTO Get(int id)
        {
            var data = DataAccessFactory1.BookingData().Get(id);
            var mapper = MapperService<Booking, BookingDTO>.GetMapper();
            return mapper.Map<BookingDTO>(data);
        }
        public static bool Create(BookingDTO Booking)
        {
            var mapper = MapperService<BookingDTO, Booking>.GetMapper();
            var mapped = mapper.Map<Booking>(Booking);
            return DataAccessFactory1.BookingData().Create(mapped);

        }
        public static bool Update(BookingDTO Booking)
        {
            var mapper = MapperService<BookingDTO, Booking>.GetMapper();
            var mapped = mapper.Map<Booking>(Booking);
            return DataAccessFactory1.BookingData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.BookingData().Delete(id);

        }
        public static BookingDTO ReceiveBooking(int clientId, string serviceType)
        {
            var Servicebooking = new Booking
            {
                Id = clientId,

                ServiceType = serviceType
            };

            var newBookings = DataAccessFactory1.BookingData().Create(Servicebooking);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedNotification = mapper.Map<BookingDTO>(newBookings);

            return mappedNotification;
        }
        public static List<BookingDTO> GetBookingsForTomorrow()
        {
            DateTime tomorrow = DateTime.Today.AddDays(1); 

            var bookingsForTomorrow = DataAccessFactory1.BookingData().GetDate(tomorrow);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Booking, BookingDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedBookings = mapper.Map<List<BookingDTO>>(bookingsForTomorrow);

            return mappedBookings;
        }


    }
}
