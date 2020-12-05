using Microsoft.Azure.Cosmos;
using Radiometry.Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Radiometry.Authorization.Repository
{
	public class UserCosmosDbRepository: IUserCosmosDbRepository
	{
        private Container _container;

        public UserCosmosDbRepository(
            CosmosClient dbClient,
            string databaseName,
            string containerName)
        {
            this._container = dbClient.GetContainer(databaseName, containerName);
        }

        public async Task AddItemAsync(Models.User item)
        {
            await this._container.CreateItemAsync<Models.User>(item, new PartitionKey(item.Id));
        }

        public async Task<Models.User> GetItemAsync(string id)
        {
            try
            {
                ItemResponse<Models.User> response = await this._container.ReadItemAsync<Models.User>(id, new PartitionKey(id));
                return response.Resource;
            }
            catch (CosmosException ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                return null;
            }
        }

        public async Task<IEnumerable<Models.User>> GetItemsAsync(string queryString)
        {
            var query = this._container.GetItemQueryIterator<Models.User>(new QueryDefinition(queryString));
            List<Models.User> results = new List<Models.User>();
            while (query.HasMoreResults)
            {
                var response = await query.ReadNextAsync();

                results.AddRange(response.ToList());
            }

            return results;
        }
    }
}
