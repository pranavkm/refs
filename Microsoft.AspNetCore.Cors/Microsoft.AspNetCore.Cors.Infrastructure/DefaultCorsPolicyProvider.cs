using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <inheritdoc />
	public class DefaultCorsPolicyProvider : ICorsPolicyProvider
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.DefaultCorsPolicyProvider" />.
		/// </summary>
		/// <param name="options">The options configured for the application.</param>
		public DefaultCorsPolicyProvider(IOptions<CorsOptions> options)
		{
			throw null;
		}

		/// <inheritdoc />
		public Task<CorsPolicy> GetPolicyAsync(HttpContext context, string policyName)
		{
			throw null;
		}
	}
}
