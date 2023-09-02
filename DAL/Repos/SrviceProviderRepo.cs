using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class SrviceProviderRepo : Repo, IRepoo<SrviceProvider, int, bool>
    {
        public bool Create(SrviceProvider obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SrviceProvider> Get()
        {
            throw new NotImplementedException();
        }

        public SrviceProvider Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<SrviceProvider> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public bool Update(SrviceProvider obj)
        {
            throw new NotImplementedException();
        }

    }
}
