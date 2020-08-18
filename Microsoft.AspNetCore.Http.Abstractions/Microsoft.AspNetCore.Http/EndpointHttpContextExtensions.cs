using Microsoft.AspNetCore.Http.Features;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Extension methods to expose Endpoint on HttpContext.
	/// </summary>
	public static class EndpointHttpContextExtensions
	{
		private class EndpointFeature : IEndpointFeature
		{
			public Endpoint? Endpoint
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
				[CompilerGenerated]
				set
				{
					throw null;
				}
			}

			public EndpointFeature()
			{
				throw null;
			}
		}

		/// <summary>
		/// Extension method for getting the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> for the current request.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.</returns>
		public static Endpoint? GetEndpoint(this HttpContext context)
		{
			throw null;
		}

		/// <summary>
		/// Extension method for setting the <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> for the current request.
		/// </summary>
		/// <param name="context">The <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> context.</param>
		/// <param name="endpoint">The <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.</param>
		public static void SetEndpoint(this HttpContext context, Endpoint? endpoint)
		{
			throw null;
		}
	}
}
