using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class BookingRepo : Repo, IRepoo<Booking, int, bool>
    {
        public bool Create(Booking obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> Get()
        {
            throw new NotImplementedException();
        }

        public Booking Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Booking> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(Booking obj)
        {
            throw new NotImplementedException();
        }

     
    }
}
