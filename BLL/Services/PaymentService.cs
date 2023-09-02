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
    public class PaymentService
    {
        public static List<PaymentDTO> Get()
        {
            var data = DataAccessFactory1.PaymentData().Get();
            var mapper = MapperService<Payment, PaymentDTO>.GetMapper();
            return mapper.Map<List<PaymentDTO>>(data);
        }
        public static PaymentDTO Get(int id)
        {
            var data = DataAccessFactory1.PaymentData().Get(id);
            var mapper = MapperService<Payment, PaymentDTO>.GetMapper();
            return mapper.Map<PaymentDTO>(data);
        }
        public static bool Create(PaymentDTO payment)
        {
            var mapper = MapperService<PaymentDTO, Payment>.GetMapper();
            var mapped = mapper.Map<Payment>(payment);
            return DataAccessFactory1.PaymentData().Create(mapped);

        }
        public static bool Update(PaymentDTO payment)
        {
            var mapper = MapperService<PaymentDTO, Payment>.GetMapper();
            var mapped = mapper.Map<Payment>(payment);
            return DataAccessFactory1.PaymentData().Update(mapped);

        }
        public static bool Delete(int id)
        {

            return DataAccessFactory1.PaymentData().Delete(id);

        }
        public static PaymentDTO ReceivePayment(int managerId, int salary)
        {
            var payment = new Payment
            {
                ReceiveDate = DateTime.Now,
                Salary = salary
            };

            var newPayment = DataAccessFactory1.PaymentData().Create(payment);

            var cfg = new MapperConfiguration(c =>
            {
                c.CreateMap<Payment, PaymentDTO>();
            });

            var mapper = new Mapper(cfg);
            var mappedPayment = mapper.Map<PaymentDTO>(newPayment);

            return mappedPayment;
        }

        /*public static void Main(string[] args)
        {
            // Example data
            int managerId = 1; // Replace with the actual manager's ID
            int salary = 5000; // Replace with the actual salary amount

            var result = ReceivePayment(managerId, salary);

            Console.WriteLine($"Payment received with ID: {result.Id}");
        } */

    }
}
