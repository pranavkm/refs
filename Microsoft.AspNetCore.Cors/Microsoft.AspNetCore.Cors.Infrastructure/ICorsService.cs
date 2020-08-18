using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// A type which can evaluate a policy for a particular <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.
	/// </summary>
	public interface ICorsService
	{
		/// <summary>
		/// Evaluates the given <paramref name="policy" /> using the passed in <paramref name="context" />.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with the call.</param>
		/// <param name="policy">The <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> which needs to be evaluated.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsResult" /> which contains the result of policy evaluation and can be
		/// used by the caller to set appropriate response headers.</returns>
		CorsResult EvaluatePolicy(HttpContext context, CorsPolicy policy);

		/// <summary>
		/// Adds CORS-specific response headers to the given <paramref name="response" />.
		/// </summary>
		/// <param name="result">The <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsResult" /> used to read the allowed values.</param>
		/// <param name="response">The <see cref="T:Microsoft.AspNetCore.Http.HttpResponse" /> associated with the current call.</param>
		void ApplyResult(CorsResult result, HttpResponse response);
	}
}
