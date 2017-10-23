using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;

namespace EnsoCosmoQuiz.AspNet.Repository
{
    public class TableStorageRepository
    {
        private CloudTable _table;

        public TableStorageRepository()
        {
            var cloudStorageAccount = CloudStorageAccount.Parse("[CONNECTION_SRING]");
            var tableClient = cloudStorageAccount.CreateCloudTableClient();
            _table = tableClient.GetTableReference("[TABLE_NAME]");
        }

        public Task<int> GetPercentageOfFemaleActresses()
        {
            // Le code
            return Task.FromResult(0);
        }
    }
}