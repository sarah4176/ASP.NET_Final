using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class PaymentRepo : Repo, IRepoo<Payment, int, bool>
    {
        public bool Create(Payment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> Get()
        {
            throw new NotImplementedException();
        }

        public Payment Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Payment> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(Payment obj)
        {
            throw new NotImplementedException();
        }

    }
}
