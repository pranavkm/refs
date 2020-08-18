using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents an HTTP request error
	/// </summary>
	public class BadHttpRequestException : IOException
	{
		/// <summary>
		/// Gets the HTTP status code for this exception.
		/// </summary>
		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.BadHttpRequestException" /> class.
		/// </summary>
		/// <param name="message">The message to associate with this exception.</param>
		/// <param name="statusCode">The HTTP status code to associate with this exception.</param>
		public BadHttpRequestException(string message, int statusCode)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.BadHttpRequestException" /> class with the <see cref="P:Microsoft.AspNetCore.Http.BadHttpRequestException.StatusCode" /> set to 400 Bad Request.
		/// </summary>
		/// <param name="message">The message to associate with this exception</param>
		public BadHttpRequestException(string message)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.BadHttpRequestException" /> class.
		/// </summary>
		/// <param name="message">The message to associate with this exception.</param>
		/// <param name="statusCode">The HTTP status code to associate with this exception.</param>
		/// <param name="innerException">The inner exception to associate with this exception</param>
		public BadHttpRequestException(string message, int statusCode, Exception innerException)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.BadHttpRequestException" /> class with the <see cref="P:Microsoft.AspNetCore.Http.BadHttpRequestException.StatusCode" /> set to 400 Bad Request.
		/// </summary>
		/// <param name="message">The message to associate with this exception</param>
		/// <param name="innerException">The inner exception to associate with this exception</param>
		public BadHttpRequestException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
