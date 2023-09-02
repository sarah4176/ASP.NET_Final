using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ManagerRepo : Repo, IRepoo<Manager, int, bool>, IAuthh
    {
        public bool Create(Manager obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Manager> Get()
        {
            throw new NotImplementedException();
        }

        public Manager Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Manager> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(Manager obj)
        {
            throw new NotImplementedException();
        }
        public Manager Authenticate(string uname, string pass)
        {
            throw new NotImplementedException();
        }

    }
}

