using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class DocumentDbController : ApiController
    {
        DocumentDbRepository _repository = new DocumentDbRepository();
        public DocumentDbController()
        {

        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var result = await _repository.Get();
            return Ok(result);
        }
    }
}
