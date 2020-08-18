using Microsoft.AspNetCore.Http;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// A default <see cref="T:Microsoft.AspNetCore.Antiforgery.IAntiforgeryAdditionalDataProvider" /> implementation.
	/// </summary>
	internal class DefaultAntiforgeryAdditionalDataProvider : IAntiforgeryAdditionalDataProvider
	{
		/// <inheritdoc />
		public string GetAdditionalData(HttpContext context)
		{
			throw null;
		}

		/// <inheritdoc />
		public bool ValidateAdditionalData(HttpContext context, string additionalData)
		{
			throw null;
		}

		public DefaultAntiforgeryAdditionalDataProvider()
		{
			throw null;
		}
	}
}
