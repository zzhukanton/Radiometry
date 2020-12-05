using Radiometry.Authorization.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Radiometry.Authorization.Repository
{
	public interface IUserCosmosDbRepository
	{
		Task<IEnumerable<User>> GetItemsAsync(string query);
		Task<User> GetItemAsync(string id);
		Task AddItemAsync(User item);
	}
}
