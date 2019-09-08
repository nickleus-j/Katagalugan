using System;
using System.Collections.Generic;
using System.Linq;
using katagaluganAPI.DAL;
using katagaluganAPI.DAL.mysql;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace katagaluganAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserDefinedWordController : ControllerBase
    {
        [HttpGet("{wordId}")]
        public ActionResult<string> Get(int wordId)
        {
            DiksyonaryoContext context = HttpContext.RequestServices.GetService(typeof(katagaluganAPI.DAL.DiksyonaryoContext)) as DiksyonaryoContext;
            UserDefinedWordsMyql udwDao = new UserDefinedWordsMyql(context);
            string jsonData = JsonConvert.SerializeObject(udwDao.GetUserDefinedwords(wordId));

            return jsonData;
        }
    }
}