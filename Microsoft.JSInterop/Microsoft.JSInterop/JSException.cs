using System;

namespace Microsoft.JSInterop
{
	/// <summary>
	/// Represents errors that occur during an interop call from .NET to JavaScript.
	/// </summary>
	public class JSException : Exception
	{
		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.JSInterop.JSException" />.
		/// </summary>
		/// <param name="message">The exception message.</param>
		public JSException(string message)
		{
			throw null;
		}

		/// <summary>
		/// Constructs an instance of <see cref="T:Microsoft.JSInterop.JSException" />.
		/// </summary>
		/// <param name="message">The exception message.</param>
		/// <param name="innerException">The inner exception.</param>
		public JSException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
