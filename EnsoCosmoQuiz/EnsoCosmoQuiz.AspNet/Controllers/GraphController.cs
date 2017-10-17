using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class GraphController : ApiController
    {
        private GraphRepository _repository;

        public GraphController(GraphRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var result = _repository.Get();
            return Ok(result);
        }
    }
}
