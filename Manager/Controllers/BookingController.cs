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
    public class BookingController : ApiController
    {
        [HttpGet]
        [Route("api/Booking/All")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = BookingService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);

            }
        }

        [HttpGet]
        [Route("api/Booking/All")]
        public HttpResponseMessage GetBookingsForTomorrow()
        {
            try
            {
                var data = BookingService.GetBookingsForTomorrow();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);



            }
        }


        [HttpPost]
        [Route("api/Booking/create")]
        public HttpResponseMessage AddBooking(BookingDTO ds)
        {
            try
            {
                var res = BookingService.Create(ds);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }



        [HttpPost]
        [Route("api/Booking/update")]
        public HttpResponseMessage UpdateBooking(BookingDTO ds)
        {
            try
            {
                var res = BookingService.Update(ds);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }




        [HttpDelete]
        [Route("api/Discount/delete/{id:int}")]
        public HttpResponseMessage DeleteBooking(int id)
        {
            try
            {
                var res = BookingService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, res);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex.Message);
            }

        }
    }
}
