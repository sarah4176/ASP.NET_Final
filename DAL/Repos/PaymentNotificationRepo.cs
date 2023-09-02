using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PaymentNotificationRepo : Repo, IRepoo<PaymentNotification, int, bool>
    {
        public bool Create(PaymentNotification obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentNotification> Get()
        {
            throw new NotImplementedException();
        }

        public PaymentNotification Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<PaymentNotification> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(PaymentNotification obj)
        {
            throw new NotImplementedException();
        }

    }
}
