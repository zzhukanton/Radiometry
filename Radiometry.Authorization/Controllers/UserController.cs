using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Radiometry.Authorization.Models;
using Radiometry.Authorization.Repository;

namespace Radiometry.Authorization.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
        private readonly IUserCosmosDbRepository _cosmosDbRepository;

        public UserController(IUserCosmosDbRepository cosmosDbRepository)
        {
            _cosmosDbRepository = cosmosDbRepository;
        }

        [HttpPost]
        [Route("api/login")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> LoginAsync(string login, string password)
        {
            if (ModelState.IsValid)
            {
                var user = await _cosmosDbRepository.GetItemAsync($"SELECT * FROM Users WHERE login = {login} AND password = {password}");

                if (user != null)
				{
                    return StatusCode(200);
                }
            }

            return StatusCode(401);
        }

        [HttpPost]
        [Route("api/register")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(User item)
        {
            if (ModelState.IsValid)
            {
                await _cosmosDbRepository.AddItemAsync(item);
                return RedirectToAction("Index");
            }

            return StatusCode(500);
        }
    }
}
