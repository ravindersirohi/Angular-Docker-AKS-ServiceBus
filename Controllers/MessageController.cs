using System;
using System.Collections.Generic;
using Angular.Docker.AKS.Models;
using Microsoft.AspNetCore.Mvc;
namespace Angular.Docker.AKS.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<ServiceMessage> Get()
        {
            var result = new List<ServiceMessage>();
            return result;
        }

        [HttpPost]
        public ServiceMessage Post(ServiceMessage dto)
        {
            return dto;
        }
    }
}
