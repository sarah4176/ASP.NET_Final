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
    public class ScheduleController : ApiController
    {
        [HttpGet]
        [Route("api/Schedule/All")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ScheduleService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/Schedule/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ScheduleService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }
        [HttpPost]
        [Route("api/Schedule/SendSchedule")]
        public HttpResponseMessage SendScheduleToServiceProvider(ScheduleDTO s)
        {
            try
            {
                var res = ScheduleService.SendScheduleToServiceProvider(s.ServiceProviderId, s.ClientPhoneNumber,s.Appointment);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpPost]
        [Route("api/Schedule/add")]
        public HttpResponseMessage AddSchedule(ScheduleDTO sp)
        {
            try
            {
                var res = ScheduleService.Create(sp);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Schedule/update")]
        public HttpResponseMessage UpdateSchedule(ScheduleDTO sp)
        {
            try
            {
                var res = ScheduleService.Update(sp);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpDelete]
        [Route("api/Schedule/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = ScheduleService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
