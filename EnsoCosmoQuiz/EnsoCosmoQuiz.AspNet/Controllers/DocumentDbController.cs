using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class DocumentDbController : ApiController
    {
        readonly DocumentDbRepository _repository = new DocumentDbRepository();

        [HttpGet]
        [ActionName("task1")]
        public async Task<IHttpActionResult> GetNumberOfActorsInBladeRunner()
        {
            var result = await _repository.GetNumberOfActorsInBladeRunner();
            return Ok(result);
        }
    }
}
