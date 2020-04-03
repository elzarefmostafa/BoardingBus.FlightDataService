using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BoardingBus.FlightData.Infrastructure.Services
{
	public class Service:IService
	{
		
		public async Task<object> CallService<T>(string URL)
		{
			try
			{
				using (var client = new HttpClient())
				{
					client.DefaultRequestHeaders.Accept.Add(
						new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
					client.DefaultRequestHeaders.Add("ResourceVersion", "v4");
					client.DefaultRequestHeaders.Add("app_id", "0295c117");
					client.DefaultRequestHeaders.Add("app_key", "3383a6802a21afc1c4c9be08f15f7075");
					using (var response = await client.GetAsync(URL))
					{
						if (response.IsSuccessStatusCode)
						{
							T output = JsonConvert.DeserializeObject<T>(response.Content.ReadAsStringAsync().Result);
							//T output = await response.Content.ReadAsAsync<T>();
							return output;
						}
					}
				}
			}
			catch (HttpRequestException ex)
			{
				//MessageBox.Show("The Service is Down", "Service", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
			return null;
		}
	}
}
