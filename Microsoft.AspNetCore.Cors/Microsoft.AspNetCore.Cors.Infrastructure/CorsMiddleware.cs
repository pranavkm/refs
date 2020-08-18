using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// A middleware for handling CORS.
	/// </summary>
	public class CorsMiddleware
	{
		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsMiddleware" />.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="corsService">An instance of <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.ICorsService" />.</param>
		/// <param name="loggerFactory">An instance of <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public CorsMiddleware(RequestDelegate next, ICorsService corsService, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsMiddleware" />.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="corsService">An instance of <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.ICorsService" />.</param>
		/// <param name="loggerFactory">An instance of <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		/// <param name="policyName">An optional name of the policy to be fetched.</param>
		public CorsMiddleware(RequestDelegate next, ICorsService corsService, ILoggerFactory loggerFactory, string policyName)
		{
			throw null;
		}

		/// <summary>
		/// Instantiates a new <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsMiddleware" />.
		/// </summary>
		/// <param name="next">The next middleware in the pipeline.</param>
		/// <param name="corsService">An instance of <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.ICorsService" />.</param>
		/// <param name="policy">An instance of the <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> which can be applied.</param>
		/// <param name="loggerFactory">An instance of <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public CorsMiddleware(RequestDelegate next, ICorsService corsService, CorsPolicy policy, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <inheritdoc />
		public Task Invoke(HttpContext context, ICorsPolicyProvider corsPolicyProvider)
		{
			throw null;
		}
	}
}
