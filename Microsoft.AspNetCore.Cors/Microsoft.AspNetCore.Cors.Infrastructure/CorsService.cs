using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.ICorsService" />.
	/// </summary>
	public class CorsService : ICorsService
	{
		/// <summary>
		/// Creates a new instance of the <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsService" />.
		/// </summary>
		/// <param name="options">The option model representing <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsOptions" />.</param>
		/// <param name="loggerFactory">The <see cref="T:Microsoft.Extensions.Logging.ILoggerFactory" />.</param>
		public CorsService(IOptions<CorsOptions> options, ILoggerFactory loggerFactory)
		{
			throw null;
		}

		/// <summary>
		/// Looks up a policy using the <paramref name="policyName" /> and then evaluates the policy using the passed in
		/// <paramref name="context" />.
		/// </summary>
		/// <param name="context"></param>
		/// <param name="policyName"></param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsResult" /> which contains the result of policy evaluation and can be
		/// used by the caller to set appropriate response headers.</returns>
		public CorsResult EvaluatePolicy(HttpContext context, string policyName)
		{
			throw null;
		}

		/// <inheritdoc />
		public CorsResult EvaluatePolicy(HttpContext context, CorsPolicy policy)
		{
			throw null;
		}

		public virtual void EvaluateRequest(HttpContext context, CorsPolicy policy, CorsResult result)
		{
			throw null;
		}

		public virtual void EvaluatePreflightRequest(HttpContext context, CorsPolicy policy, CorsResult result)
		{
			throw null;
		}

		/// <inheritdoc />
		public virtual void ApplyResult(CorsResult result, HttpResponse response)
		{
			throw null;
		}
	}
}
