using System.Threading.Tasks;
using System.Web.Http;
using EnsoCosmoQuiz.AspNet.Repository;

namespace EnsoCosmoQuiz.AspNet.Controllers
{
    public class TableStorageController : ApiController
    {
        private readonly TableStorageRepository _repository = new TableStorageRepository();
        
        [HttpGet]
        [ActionName("task1")]
        public async Task<IHttpActionResult> GetPercentageOfFemaleActresses()
        {
            var result = await _repository.GetPercentageOfFemaleActresses();
            return Ok(result);
        }
    }
}
