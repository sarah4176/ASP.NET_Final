using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class ClientService
    {
        public static List<ClientDTO> Get()
        {
            var data = DataAccessFactory1.ClientData().Get();
            var mapper = MapperService<Client, ClientDTO>.GetMapper();
            return mapper.Map<List<ClientDTO>>(data);
        }
        public static ClientDTO Get(int id)
        {
            var data = DataAccessFactory1.ClientData().Get(id);
            var mapper = MapperService<Client, ClientDTO>.GetMapper();
            return mapper.Map<ClientDTO>(data);
        }
        public static bool Create(ClientDTO Client)
        {
            var mapper = MapperService<ClientDTO, Client>.GetMapper();
            var mapped = mapper.Map<Client>(Client);
            return DataAccessFactory1.ClientData().Create(mapped);

        }
        public static bool Update(ClientDTO Client)
        {
            var mapper = MapperService<ClientDTO, Client>.GetMapper();
            var mapped = mapper.Map<Client>(Client);
            return DataAccessFactory1.ClientData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.ClientData().Delete(id);

        }
    }
}
