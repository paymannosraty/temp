using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreatePerson.Controllers
{
	public class ContactsController : Infrastructure.BaseApiController
	{
		private readonly HttpClient _httpClient;

		public ContactsController(HttpClient httpClient) : base()
		{
			_httpClient = httpClient;
		}

		[HttpPost]
		public async Task<ActionResult<Models.Contact>> Post(Models.Contact contact)
		{

			var contactDic =
				new Dictionary<string, object>
				{
					{ "Contact", contact }
				};

			var response =
				await _httpClient.PostAsJsonAsync<Dictionary<string, object>>($"/api/contact/save?apikey=lczdz7c0i7i0rlpbrfov8els42ytunti", contactDic);

			var result =
				await response.Content.ReadAsStringAsync();

			return Ok(value: result);

		}
	}
}
