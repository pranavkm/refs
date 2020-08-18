using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.HostFiltering
{
	/// <summary>
	/// A middleware used to filter requests by their Host header.
	/// </summary>
	public class HostFilteringMiddleware
	{
		/// <summary>
		/// A middleware used to filter requests by their Host header.
		/// </summary>
		/// <param name="next"></param>
		/// <param name="logger"></param>
		/// <param name="optionsMonitor"></param>
		public HostFilteringMiddleware(RequestDelegate next, ILogger<HostFilteringMiddleware> logger, IOptionsMonitor<HostFilteringOptions> optionsMonitor)
		{
			throw null;
		}

		/// <summary>
		/// Processes requests
		/// </summary>
		/// <param name="context"></param>
		/// <returns></returns>
		public Task Invoke(HttpContext context)
		{
			throw null;
		}
	}
}
