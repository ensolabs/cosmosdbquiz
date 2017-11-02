using System;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.Azure.Documents.Client;

namespace EnsoCosmoQuiz.AspNet.Repository
{
    public class DocumentDbRepository
    {
        private DocumentClient _client;

        public DocumentDbRepository()
        {
            //_client = new DocumentClient(new Uri("[ENDPOINT]"), "[AUTH KEY]");
         }

        public Task<int> GetNumberOfActorsInBladeRunner()
        {
            // Le code
            return Task.FromResult(0);
        }
    }
}