using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class IssueRepo : Repo, IRepoo<Issue, int, bool>
    {
        public bool Create(Issue obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Issue> Get()
        {
            throw new NotImplementedException();
        }

        public Issue Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Issue> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(Issue obj)
        {
            throw new NotImplementedException();
        }
    }
}
