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
    public class ManagerService
    {
        public static List<ManagerDTO> Get()
        {
            var data = DataAccessFactory1.ManagerData().Get();
            var mapper = MapperService<Manager, ManagerDTO>.GetMapper();
            return mapper.Map<List<ManagerDTO>>(data);
        }
        public static ManagerDTO Get(int id)
        {
            var data = DataAccessFactory1.ManagerData().Get(id);
            var mapper = MapperService<Manager, ManagerDTO>.GetMapper();
            return mapper.Map<ManagerDTO>(data);
        }
        public static bool Create(ManagerDTO Manager)
        {
            var mapper = MapperService<ManagerDTO, Manager>.GetMapper();
            var mapped = mapper.Map<Manager>(Manager);
            return DataAccessFactory1.ManagerData().Create(mapped);

        }
        public static bool Update(ManagerDTO Manager)
        {
            var mapper = MapperService<ManagerDTO, Manager>.GetMapper();
            var mapped = mapper.Map<Manager>(Manager);
            return DataAccessFactory1.ManagerData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.IssueData().Delete(id);

        }
        public static BookingNotificationDTO ReceiveBookingNotification(int client, string name)
        {
            var bookingNotification = new BookingNotification
            {
                IdOfClient = client,
                Title = name,
                
            };

            var addedBookingNotification = DataAccessFactory1.BookingNotificationData().Create(bookingNotification);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<BookingNotification, BookingNotificationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedNotification = mapper.Map<BookingNotificationDTO>(addedBookingNotification);

            return mappedNotification;
        }
        public static PaymentNotificationDTO ReceivePaymentNotification(int id, string name)
        {
            var paymentNotification = new PaymentNotification
            {
                PaymentId = id,
                SenderName = name,

            };

            var addedPaymentNotification = DataAccessFactory1.PaymentNotificationData().Create(paymentNotification);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<PaymentNotification, PaymentNotificationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedNotification = mapper.Map<PaymentNotificationDTO>(addedPaymentNotification);

            return mappedNotification;
        }
        public static IssueNotificationDTO ReceiveIssueNotification(int id, string name)
        {
            var issueNotification = new IssueNotification
            {
                ClientId = id,
                Title = name,

            };

            var addedIssueNotification = DataAccessFactory1.IssueNotificationData().Create(issueNotification);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<IssueNotification, IssueNotificationDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedNotification = mapper.Map<IssueNotificationDTO>(addedIssueNotification);

            return mappedNotification;
        }



    }
}
