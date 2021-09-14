using BookStoresWebAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoresWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Publisher> Get()
        { 
            using (var context = new BookStoresDBContext())
            {
                Publisher publisher = new Publisher();
                publisher.PublisherName = "Egmont Book";

                context.Publishers.Add(publisher);

                context.SaveChanges();


                return context.Publishers.ToList();
            }
           
        }
    }
}
