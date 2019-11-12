using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProjectEulerAPI.Services;

namespace ProjectEulerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EulerController : ControllerBase
    {
        private readonly EulerService _eulerService;

        public EulerController()
        {
            this._eulerService = new EulerService();
        }

        // GET api/values
        [HttpGet]
        public ActionResult<string> Get()
        {
            return "EulerController";
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public int Get(int id)
        {
            if (id == 1)
                return this._eulerService._1();
            else if (id == 2)
                return this._eulerService._2();

            return 00000;
        }
    }
}