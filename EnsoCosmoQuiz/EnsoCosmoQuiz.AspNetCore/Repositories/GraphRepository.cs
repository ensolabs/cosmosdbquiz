using System;
using System.Threading.Tasks;
using Microsoft.Azure.Documents;
using Microsoft.Azure.Documents.Client;

namespace EnsoCosmoQuiz.AspNetCore.Repositories
{
    public class GraphRepository
    {
        private DocumentClient _client;
        private ResourceResponse<DocumentCollection> _graph;

        public GraphRepository()
        {
            _client = new DocumentClient(
                new Uri("[ENDPOINT]"),
                "[AUTH_KEY]", new ConnectionPolicy { ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp });

        }

        private async Task Init()
        {
            _graph = await _client.CreateDocumentCollectionIfNotExistsAsync(UriFactory.CreateDatabaseUri("[DB_NAME]"),
                new DocumentCollection { Id = "[GRAPH_NAME]" }, new RequestOptions { OfferThroughput = 400 });
        }

        public async Task<int> GetNumberOfActorsThatHaveActedInMoreThan1Movie()
        {
            await Init();
            // Le code
            return 0;
        }
    }
}