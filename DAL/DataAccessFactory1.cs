using DAL.EF.Models;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory1
    {
        public static IRepoo<Payment, int, bool> PaymentData()
        {
            return new PaymentRepo();
        }
        public static IRepoo<Client, int, bool> ClientData()
        {
            return new ClientRepo1();
        }
        public static IRepoo<Booking, int, bool> BookingData()
        {
            return new BookingRepo();
        }
        public static IRepoo<Schedule, int, bool> ScheduleData()
        {
            return new ScheduleRepo();
        }
        public static IRepoo<SrviceProvider, int, bool> SrviceProviderData()
        {
            return new SrviceProviderRepo();
        }
        public static IRepoo<Issue, int, bool> IssueData()
        {
            return new IssueRepo();
        }
        public static IRepoo<Manager, int, bool> ManagerData()
        {
            return new ManagerRepo();
        }
        public static IRepoo<Token, int, bool> TokenData()
        {
            return new TokenRepo();
        }
        public static IRepoo<BookingNotification, int, bool> BookingNotificationData()
        {
            return new BookingNotificationRepo();
        }
        public static IRepoo<IssueNotification, int, bool> IssueNotificationData()
        {
            return new IssueNotificationRepo();
        }
        public static IRepoo<PaymentNotification, int, bool> PaymentNotificationData()
        {
            return new PaymentNotificationRepo();
        }

        public static IAuthh AuthData()
        {
            return new ManagerRepo();
        }

    }
}
