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
    public class SrviceProviderController : ApiController
    {
        [HttpGet]
        [Route("api/SrviceProvider/All")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SrviceProviderService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }
        [HttpGet]
        [Route("api/SrviceProvider/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SrviceProviderService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception e)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, e.Message);
            }
        }


        [HttpPost]
        [Route("api/SrviceProvider/add")]
        public HttpResponseMessage AddSrviceProviders(SrviceProviderDTO sp)
        {
            try
            {
                var res = SrviceProviderService.Create(sp);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/Client/update")]
        public HttpResponseMessage UpdateSrviceProvider(SrviceProviderDTO sp)
        {
            try
            {
                var res = SrviceProviderService.Update(sp);
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
                var res = SrviceProviderService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}

