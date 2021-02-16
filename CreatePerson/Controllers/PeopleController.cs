using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CreatePerson.Controllers
{
	public class PeopleController : Infrastructure.BaseApiController
	{
		private readonly HttpClient _httpClient;

		public PeopleController(HttpClient httpClient) : base()
		{
			_httpClient = httpClient;
		}

		[HttpPost]
		public async Task<ActionResult> Post(Models.Person contact)
		{

			var contactDic =
				new Dictionary<string, object>();

			contactDic.Add("Contact", contact.Contact);

			var response =
				await _httpClient.PostAsJsonAsync<Dictionary<string, object>>($"/api/contact/save?apikey=lczdz7c0i7i0rlpbrfov8els42ytunti", contactDic);

			var e = response.StatusCode;

			var result =
				await response.Content.ReadFromJsonAsync<bool>();

			return Ok();

		}
	}
}
