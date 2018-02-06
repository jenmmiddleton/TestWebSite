using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;
using System.Net;
using System.Net.Http;
using System.Globalization;
using TestWebSite.DAL;
using TestWebSite.Models;


namespace TestWebSite.Controllers
{
    public class SubscribersAPIController : ApiController
    {
        class SubscribersDataEntry
        {
            public string Fullname { get; set; }
            public string Email { get; set; }
            public string SMS { get; set; }
            public string Fax { get; set; }
        }

        //POST /api/SubscribersAPI/SubscribersDataTable
        [System.Web.Http.HttpPost]
        [System.Web.Http.ActionName("SubscribersDataTable")]
        public HttpResponseMessage SubscribersDataTable()
        {
            try
            {
                Playground_DB_Context db = new Playground_DB_Context();
                var subscribers = db.Subscriber.Select(s => new
                {
                    s.AccountId,
                    s.FullName,
                    s.Email,
                    s.Sms,
                    s.Fax
                }).Where(s => (s.AccountId == 1)).OrderBy(s => s.FullName).Take(10).ToList();

                List<SubscribersDataEntry> list = new List<SubscribersDataEntry>();

                foreach (var subscriber in subscribers)
                {
                    SubscribersDataEntry subscriberRow = new SubscribersDataEntry
                    {
                        Fullname = subscriber.FullName,
                        Email = subscriber.Email,
                        SMS = subscriber.Sms,
                        Fax = subscriber.Fax
                    };

                    list.Add(subscriberRow);
                }
                return Request.CreateResponse(HttpStatusCode.OK, list);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }



        }
    }
}