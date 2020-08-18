using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Cors.Infrastructure
{
	/// <summary>
	/// A type which can provide a <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> for a particular <see cref="T:Microsoft.AspNetCore.Http.HttpContext" />.
	/// </summary>
	public interface ICorsPolicyProvider
	{
		/// <summary>
		/// Gets a <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /> from the given <paramref name="context" />
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> associated with this call.</param>
		/// <param name="policyName">An optional policy name to look for.</param>
		/// <returns>A <see cref="T:Microsoft.AspNetCore.Cors.Infrastructure.CorsPolicy" /></returns>
		Task<CorsPolicy> GetPolicyAsync(HttpContext context, string policyName);
	}
}
