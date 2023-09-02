using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookingNotificationRepo : Repo, IRepoo<BookingNotification, int, bool>
    {
        public bool Create(BookingNotification obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BookingNotification> Get()
        {
            throw new NotImplementedException();
        }

        public BookingNotification Get(int id)
        {
            throw new NotImplementedException();
        }

     
        public List<BookingNotification> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(BookingNotification obj)
        {
            throw new NotImplementedException();
        }

     
    }
}
