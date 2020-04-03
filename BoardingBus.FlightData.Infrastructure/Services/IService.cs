using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BoardingBus.FlightData.Infrastructure.Services
{
    public interface IService
    {
		Task<object> CallService<T>(string URL);

	}
}
