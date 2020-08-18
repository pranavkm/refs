using Microsoft.AspNetCore.Http;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.Antiforgery
{
	internal class DefaultAntiforgeryTokenGenerator : IAntiforgeryTokenGenerator
	{
		public DefaultAntiforgeryTokenGenerator(IClaimUidExtractor claimUidExtractor, IAntiforgeryAdditionalDataProvider additionalDataProvider)
		{
			throw null;
		}

		/// <inheritdoc />
		public AntiforgeryToken GenerateCookieToken()
		{
			throw null;
		}

		/// <inheritdoc />
		public AntiforgeryToken GenerateRequestToken(HttpContext httpContext, AntiforgeryToken cookieToken)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool IsCookieTokenValid(AntiforgeryToken? cookieToken)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool TryValidateTokenSet(HttpContext httpContext, AntiforgeryToken cookieToken, AntiforgeryToken requestToken, [NotNullWhen(false)] out string? message)
		{
			throw null;
		}
	}
}
