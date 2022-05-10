using System;
using System.Threading.Tasks;
using Microsoft.Azure.Cosmos.Table;
using Microsoft.Extensions.Options;
using PelotonDadsChallenge.API.Configuration;
using PelotonDadsChallenge.API.Models;

namespace PelotonDadsChallenge.API.Services
{
    public class AppUserChallengeResultsService : IAppUserChallengeResultsService
    {
        private ConnectionStringsConfiguration _connectionStringsConfiguration;

        public AppUserChallengeResultsService(IOptions<ConnectionStringsConfiguration> connectionStringsConfiguration)
        {
            _connectionStringsConfiguration = connectionStringsConfiguration.Value;
        }

        public async Task CreateAppUserChallengeResult(AppUserChallengeResult result)
        {
            var table = await CreateTableAsync("AppUserResults");
            await InsertOrMergeEntityAsync(table, result);
        }

        private CloudStorageAccount CreateStorageAccountFromConnectionString(string storageConnectionString)
        {
            CloudStorageAccount storageAccount;
            try
            {
                storageAccount = CloudStorageAccount.Parse(storageConnectionString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid storage account information provided. Please confirm the AccountName and AccountKey are valid in the app.config file - then restart the application.");
                throw;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Invalid storage account information provided. Please confirm the AccountName and AccountKey are valid in the app.config file - then restart the sample.");
                Console.ReadLine();
                throw;
            }

            return storageAccount;
        }

        private async Task<CloudTable> CreateTableAsync(string tableName)
        {
            string storageConnectionString = _connectionStringsConfiguration.StorageConnectionString;

            // Retrieve storage account information from connection string.
            CloudStorageAccount storageAccount = CreateStorageAccountFromConnectionString(storageConnectionString);

            // Create a table client for interacting with the table service
            CloudTableClient tableClient = storageAccount.CreateCloudTableClient(new TableClientConfiguration());

            // Create a table client for interacting with the table service 
            CloudTable table = tableClient.GetTableReference(tableName);
            await table.CreateIfNotExistsAsync();

            return table;
        }

        private async Task<AppUserChallengeResult> InsertOrMergeEntityAsync(CloudTable table, AppUserChallengeResult entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            try
            {
                // Create the InsertOrReplace table operation
                TableOperation insertOrMergeOperation = TableOperation.InsertOrMerge(entity);

                // Execute the operation.
                TableResult result = await table.ExecuteAsync(insertOrMergeOperation);
                var insertedCustomer = result.Result as AppUserChallengeResult;

                return insertedCustomer;
            }
            catch (StorageException e)
            {
                throw;
            }
        }
    }
}
