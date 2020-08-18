namespace Microsoft.AspNetCore.Authorization
{
	/// <summary>
	/// Determines whether an authorization request was successful or not.
	/// </summary>
	public class DefaultAuthorizationEvaluator : IAuthorizationEvaluator
	{
		/// <summary>
		/// Determines whether the authorization result was successful or not.
		/// </summary>
		/// <param name="context">The authorization information.</param>
		/// <returns>The <see cref="T:Microsoft.AspNetCore.Authorization.AuthorizationResult" />.</returns>
		public AuthorizationResult Evaluate(AuthorizationHandlerContext context)
		{
			throw null;
		}

		public DefaultAuthorizationEvaluator()
		{
			throw null;
		}
	}
}
