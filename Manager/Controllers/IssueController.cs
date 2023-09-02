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
    public class IssueController : ApiController
    {
        [HttpGet]
        [Route("api/Issue/All")]
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
        [Route("api/Issue/All")]
        public HttpResponseMessage GetIssuesForToday()
        {
            try
            {
                var data = IssueService.GetIssuesForToday();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);



            }
        }

        [HttpPost]
        [Route("api/Issue/update")]
        public HttpResponseMessage UpdatePayment(IssueDTO ds)
        {
            try
            {
                var res = IssueService.Update(ds);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }




        [HttpDelete]
        [Route("api/Issue/delete/{id:int}")]
        public HttpResponseMessage DeleteIssue(int id)
        {
            try
            {
                var res = IssueService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}

