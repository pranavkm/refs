using Microsoft.AspNetCore.Http;
using System;

namespace Microsoft.AspNetCore.Server.IIS
{
	/// <summary>
	/// Extensions to <see cref="T:Microsoft.AspNetCore.Http.HttpContext" /> that enable access to IIS features.
	/// </summary>
	public static class HttpContextExtensions
	{
		/// <summary>
		/// Gets the value of a server variable for the current request.
		/// </summary>
		/// <param name="context">The http context for the request.</param>
		/// <param name="variableName">The name of the variable.</param>
		/// <returns>
		/// <c>null</c> if the server does not support the <see cref="T:Microsoft.AspNetCore.Http.Features.IServerVariablesFeature" /> feature.
		/// May return null or empty if the variable does not exist or is not set.
		/// </returns>
		[Obsolete("This is obsolete and will be removed in a future version. Use GetServerVariable instead.")]
		public static string GetIISServerVariable(this HttpContext context, string variableName)
		{
			throw null;
		}
	}
}
