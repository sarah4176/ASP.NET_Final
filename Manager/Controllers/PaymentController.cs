using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Manager.Controllers
{
    public class PaymentController : ApiController
    {
            
        [HttpGet]
        [Route("api/Payment/All")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = PaymentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Payment/All")]
        public HttpResponseMessage ReceivePayment(PaymentDTO p)
        {
            try
            {
                var data = PaymentService.ReceivePayment(p.Id, p.Salary);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);



            }
        }


        [HttpPost]
        [Route("api/Payment/create")]
        public HttpResponseMessage AddPayment(PaymentDTO ds)
        {
            try
            {
                var res = PaymentService.Create(ds);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Booking/update")]
        public HttpResponseMessage UpdatePayment(PaymentDTO ds)
        {
            try
            {
                var res = PaymentService.Update(ds);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }




        [HttpDelete]
        [Route("api/Payment/delete/{id:int}")]
        public HttpResponseMessage DeletePayment(int id)
        {
            try
            {
                var res = PaymentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}

