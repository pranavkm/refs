using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// The exception thrown from a hub when an error occurs.
	/// </summary>
	/// <remarks>
	/// Exceptions often contain sensitive information, such as connection information. Because of this, SignalR does not expose the details
	/// of exceptions that occur on the server to the client. However, instances of <see cref="T:Microsoft.AspNetCore.SignalR.HubException" /> <b>are</b> sent to the client.
	/// </remarks>
	[Serializable]
	public class HubException : Exception
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubException" /> class.
		/// </summary>
		public HubException()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubException" /> class
		/// with a specified error message.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		public HubException(string? message)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubException" /> class
		/// with a specified error message and a reference to the inner exception that is the cause of this exception.
		/// </summary>
		/// <param name="message">The error message that explains the reason for the exception.</param>
		/// <param name="innerException">The exception that is the cause of the current exception, or <c>null</c> if no inner exception is specified.</param>
		public HubException(string? message, Exception? innerException)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.HubException" /> class.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
		/// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
		/// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is <c>null</c>.</exception>
		/// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is <c>null</c> or <see cref="P:System.Exception.HResult" /> is zero (0).</exception>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public HubException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
