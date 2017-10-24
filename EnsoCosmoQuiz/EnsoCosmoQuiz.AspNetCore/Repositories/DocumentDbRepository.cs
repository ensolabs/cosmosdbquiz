using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents.Client;

namespace EnsoCosmoQuiz.AspNetCore.Repositories
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