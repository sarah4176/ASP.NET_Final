using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class IssueNotificationRepo : Repo, IRepoo<IssueNotification, int, bool>
    {
        public bool Create(IssueNotification obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<IssueNotification> Get()
        {
            throw new NotImplementedException();
        }

        public IssueNotification Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<IssueNotification> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(IssueNotification obj)
        {
            throw new NotImplementedException();
        }

    }
}
