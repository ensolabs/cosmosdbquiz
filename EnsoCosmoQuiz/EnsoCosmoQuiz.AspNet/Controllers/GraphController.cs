using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class GraphController : ApiController
    {
        private readonly GraphRepository _repository = new GraphRepository();
        
        [HttpGet]
        public async Task<IHttpActionResult> GetNumberOfActorsThatHaveActedInMoreThan1Movie()
        {
            var result = await _repository.GetNumberOfActorsThatHaveActedInMoreThan1Movie();
            return Ok(result);
        }
    }
}
