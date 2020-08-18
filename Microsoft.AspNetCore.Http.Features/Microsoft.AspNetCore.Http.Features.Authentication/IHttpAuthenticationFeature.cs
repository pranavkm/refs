using System.Security.Claims;

namespace Microsoft.AspNetCore.Http.Features.Authentication
{
	public interface IHttpAuthenticationFeature
	{
		ClaimsPrincipal? User
		{
			get;
			set;
		}
	}
}
