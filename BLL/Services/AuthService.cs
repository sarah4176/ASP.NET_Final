using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BLL.Services
{
    public class AuthService
    {
        public static TokenDTO Login(string uname, string pass)
        {
            var user = DataAccessFactory1.AuthData().Authenticate(uname, pass);
            if (user != null)
            {
                var token = new Token();
                token.TokenKey = Guid.NewGuid().ToString();
                token.Username = user.UserName;
                token.CreatedAt = DateTime.Now;
                token.ExpiredAt = null;
                var tk = DataAccessFactory1.TokenData().Create(token);
                var config = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<Token, TokenDTO>();
                });
                var mapper = new Mapper(config);
                var data = mapper.Map<TokenDTO>(tk);
                return data;
            }
            return null;
        }
        public static bool IsTokenValid(string token)
        {
            var tk = (from t in DataAccessFactory1.TokenData().Get()
                      where t.TokenKey.Equals(token)
                      && t.ExpiredAt == null
                      select t).SingleOrDefault();
            if (tk != null)
            {
                return true;
            }
            return false;

        }
        public static bool Logout(int id)
        {
            var extk = DataAccessFactory1.TokenData().Get(id);
            extk.ExpiredAt = DateTime.Now;
            if (DataAccessFactory1.TokenData().Update(extk) != null)
            {
                return true;
            }
            return false;

        }

        public static bool IsManager(int id)
        {
            var extk = DataAccessFactory1.TokenData().Get(id);
            if (extk != null && IsTokenValid(extk.TokenKey) && extk.Manager.UserName.Equals("Manager"))
            {
                return true;
            }
            return false;
        }




    }
}
