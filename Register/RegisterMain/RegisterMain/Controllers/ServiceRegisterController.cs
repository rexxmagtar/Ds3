using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SOPSLab3Service.Models;
using Microsoft.EntityFrameworkCore;

namespace SOPSLab3Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceRegisterController : ControllerBase
    {
        private RegisterContext context;

        public ServiceRegisterController(RegisterContext context)
        {
            this.context = context;
        }

        [HttpGet]
        [Route("getMethods/{serviceName}")]
        public async Task<ActionResult<List<object>>> GetMethods(string serviceName)
        {
            if (serviceName == null)
                return BadRequest();

            Service service = await context.Services.FindAsync(serviceName);
            if (service == null)
                return NoContent();

            return service.AvailableMethods
                          .Select(method => (object)new
                          {
                              method.Id,
                              method.MethodName
                          })
                          .ToList();
        }
    }
}
