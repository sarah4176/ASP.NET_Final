using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : Repo, IRepoo<Token, int, bool>, IRepoo2<Token,String,Token>
    {
        public bool Create(Token obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Token> Get()
        {

            return db.Tokens.ToList();
        }

        public Token Get(int id)
        {
            throw new NotImplementedException();
        }


        public List<Token> GetDate(DateTime date)
        {
            throw new NotImplementedException();
        }

        public Token GetToken(string id)
        {
            return db.Tokens.FirstOrDefault(v => v.TokenKey.Equals(id));
        }

        public bool Update(Token obj)
        {
            throw new NotImplementedException();
        }

      
    }
}
