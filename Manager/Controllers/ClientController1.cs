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
    public class ClientController1 : ApiController
    {
        [HttpGet]
        [Route("api/Client/All")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ClientService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/Client/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ClientService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPost]
        [Route("api/Client/add")]
        public HttpResponseMessage AddClients(ClientDTO sp)
        {
            try
            {
                var res = ClientService.Create(sp);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpPost]
        [Route("api/Client/update")]
        public HttpResponseMessage UpdateFeedback(ClientDTO sp)
        {
            try
            {
                var res = ClientService.Update(sp);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }


        [HttpDelete]
        [Route("api/Client/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var res = ClientService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
