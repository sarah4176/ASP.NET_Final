using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IRepoo<CLASS, ID, RET>
    {

        CLASS Get(ID id);
        RET Create(CLASS obj);
        RET Update(CLASS obj);
        bool Delete(ID id);
        List<CLASS> GetDate(DateTime date);
        List<CLASS> Get();
    }
}
