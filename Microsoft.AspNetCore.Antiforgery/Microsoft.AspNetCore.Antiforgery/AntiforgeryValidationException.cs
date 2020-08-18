using System;

namespace Microsoft.AspNetCore.Antiforgery
{
	/// <summary>
	/// The <see cref="T:System.Exception" /> that is thrown when the antiforgery token validation fails.
	/// </summary>
	public class AntiforgeryValidationException : Exception
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Antiforgery.AntiforgeryValidationException" /> with the specified
		/// exception message.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		public AntiforgeryValidationException(string message)
		{
			throw null;
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Antiforgery.AntiforgeryValidationException" /> with the specified
		/// exception message and inner exception.
		/// </summary>
		/// <param name="message">The message that describes the error.</param>
		/// <param name="innerException">The inner <see cref="T:System.Exception" />.</param>
		public AntiforgeryValidationException(string message, Exception? innerException)
		{
			throw null;
		}
	}
}
