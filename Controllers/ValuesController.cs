using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstApplicationDotnetCore.Models;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
using FirstApplicationDotnetCore.Dao;

namespace FirstApplicationDotnetCore.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly PaymentDAO _context;
        
        // GET api/values
        [HttpGet]
        public IEnumerable<PaymentDetail> Get()
        {
           
          
            return PaymentDAO.lists;
        }

        // GET api/values/5
        [HttpGet("get/{id}")]
        public string Get(int id)
        {
            return PaymentDAO.lists[id].cardOwner;
        }

        // POST api/values
        [HttpGet("add/{id}/{cardname}/{cardnumber}/{expiration}/{cvv}")]
        public void Post(int id,string cardname,string cardnumber,string expiration,string cvv)
        {
            PaymentDAO.lists.Add(new PaymentDetail(id, cardname, cardnumber, expiration, cvv));
           
            
        }

        // PUT api/values/5
        [HttpGet("update/{id}/{value}")]
        public void Put(int id, string value)
        {
            var payment = PaymentDAO.lists[id];
                payment.cardOwner = value;
           
        }

        // DELETE api/values/5
        [HttpGet("remove/{id}")]
        public void Delete(int id)
        {
            PaymentDAO.lists.RemoveAt(id);
        }
    }
}
