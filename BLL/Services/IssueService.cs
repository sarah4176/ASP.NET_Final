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
    public class IssueService
    {
        public static List<IssueDTO> Get()
        {
            var data = DataAccessFactory1.IssueData().Get();
            var mapper = MapperService<Issue, IssueDTO>.GetMapper();
            return mapper.Map<List<IssueDTO>>(data);
        }
        public static IssueDTO Get(int id)
        {
            var data = DataAccessFactory1.IssueData().Get(id);
            var mapper = MapperService<Issue, IssueDTO>.GetMapper();
            return mapper.Map<IssueDTO>(data);
        }
        public static bool Create(IssueDTO Issue)
        {
            var mapper = MapperService<IssueDTO, Issue>.GetMapper();
            var mapped = mapper.Map<Issue>(Issue);
            return DataAccessFactory1.IssueData().Create(mapped);

        }
        public static bool Update(IssueDTO Issue)
        {
            var mapper = MapperService<IssueDTO, Issue>.GetMapper();
            var mapped = mapper.Map<Issue>(Issue);
            return DataAccessFactory1.IssueData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.IssueData().Delete(id);

        }
        public static List<IssueDTO> GetIssuesForToday()
        {
            DateTime today = DateTime.Today;

            var issuesForToday = DataAccessFactory1.IssueData().GetDate(today);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Issue, IssueDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedIssues = mapper.Map<List<IssueDTO>>(issuesForToday);

            return mappedIssues;
        }

    }
}
