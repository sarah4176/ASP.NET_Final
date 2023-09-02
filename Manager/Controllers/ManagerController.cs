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
    public class ManagerController : ApiController
    {
        //  [EnableCors("*", "*", "*")]
        // [ManagerAccess]
        public class AdminController : ApiController
        {

            //[Logged]
            [HttpGet]
            [Route("api/Manager/All")]
            public HttpResponseMessage Get()
            {
                try
                {
                    var data = ManagerService.Get();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

                }
            }
            [HttpPost]
            [Route("api/Manager/add")]
            public HttpResponseMessage AddMembers(ManagerDTO sp)
            {
                try
                {
                    var res = ManagerService.Create(sp);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            [HttpPost]
            [Route("api/Manager/update")]
            public HttpResponseMessage Update(ManagerDTO sp)
            {
                try
                {
                    var res = ManagerService.Update(sp);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            [HttpDelete]
            [Route("api/Manager/delete/{id}")]
            public HttpResponseMessage Delete(int id)
            {
                try
                {
                    var data = ManagerService.Delete(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
                }

            }
            [HttpPost]
            [Route("api/Manager/BookingNotification")]
            public HttpResponseMessage ReceiveBookingNotification(BookingNotificationDTO notification)
            {
                try
                {
                    var res = ManagerService.ReceiveBookingNotification(notification.ClientId, notification.Title);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            [HttpPost]
            [Route("api/Manager/PaymentNotification")]
            public HttpResponseMessage ReceivePaymentNotification(PaymentNotificationDTO Bnotification)
            {
                try
                {
                    var res = ManagerService.ReceivePaymentNotification(Bnotification.PaymentId, Bnotification.SenderName);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            [HttpPost]
            [Route("api/Manager/IssueNotification")]
            public HttpResponseMessage ReceiveIssueNotification(IssueNotificationDTO Inotification)
            {
                try
                {
                    var res = ManagerService.ReceiveIssueNotification(Inotification.ClientId, Inotification.Title);
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }

        }
    }
}
