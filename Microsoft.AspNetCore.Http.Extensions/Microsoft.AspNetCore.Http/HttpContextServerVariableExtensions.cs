namespace Microsoft.AspNetCore.Http
{
	public static class HttpContextServerVariableExtensions
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
		public static string GetServerVariable(this HttpContext context, string variableName)
		{
			throw null;
		}
	}
}
