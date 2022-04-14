using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WebAPICustDet.Models;
using System.Threading.Tasks;

namespace WebAPICustDet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustDetailController : ControllerBase
    {
        List<Customer> clist = new List<Customer>()
        {
            new Customer() { cid = "C001", cname = "Pradip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C002", cname = "Sandip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "sandip@gmail.com" },
            new Customer() { cid = "C003", cname = "Randip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "randip@gmail.com" },
            new Customer() { cid = "C004", cname = "Mandip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "mandip@gmail.com" },
            new Customer() { cid = "C005", cname = "Gagandip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C006", cname = "Adip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C007", cname = "Akashdip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C008", cname = "Radip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C009", cname = "Deep", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
            new Customer() { cid = "C010", cname = "Dip", caddr = "Wardha", contactno = "1234567890", cmailaddr= "pradip@gmail.com" },
        };

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> getAllCust()
        {
            var res = from i in clist select i;
            return res.ToList();
        }
    }
}
