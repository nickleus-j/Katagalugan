using System;
using System.Collections.Generic;
using System.Linq;
using katagaluganAPI.DAL;
using katagaluganAPI.DAL.mysql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace katagaluganAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WordEntityController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get()
        {
            DiksyonaryoContext context = HttpContext.RequestServices.GetService(typeof(katagaluganAPI.DAL.DiksyonaryoContext)) as DiksyonaryoContext;
            WordEntityMysql wordDal = new WordEntityMysql(context);
            return wordDal.GetRandomWord();
        }
        [HttpGet("{keyword}")]
        public ActionResult<IEnumerable<string>> Get(string keyword)
        {
            DiksyonaryoContext context = HttpContext.RequestServices.GetService(typeof(katagaluganAPI.DAL.DiksyonaryoContext)) as DiksyonaryoContext;
            WordEntityMysql wordDal = new WordEntityMysql(context);
            return wordDal.FindWord(keyword).ToArray();
        }
    }
}