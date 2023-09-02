using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ScheduleRepo : Repo, IRepoo<Schedule, int, bool>
    {
        public bool Create(Schedule obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> Get()
        {
            throw new NotImplementedException();
        }

        public Schedule Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Schedule> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(Schedule obj)
        {
            throw new NotImplementedException();
        }

    }
}
