using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ApiTela.Context;

namespace ApiTela.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TelaController : ControllerBase
    {
        private readonly AppDbContext context;
        public TelaController(AppDbContext _context)
        {
            this.context = _context;
        }
        [HttpGet]
        public ActionResult GetAll()
        {
            //Error handling Try-catch
            return Ok(context.tela.ToList());
        }

    }
}
