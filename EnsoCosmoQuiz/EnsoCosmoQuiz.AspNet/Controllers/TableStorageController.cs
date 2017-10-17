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
    public class TableStorageController : ApiController
    {
        private TableStorageRepository _repository;

        public TableStorageController(TableStorageRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IHttpActionResult> Get()
        {
            var result = await _repository.Get();
            return Ok(result);
        }
    }
}
