using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// The message sent when closing a connection.
	/// </summary>
	public class CloseMessage : HubMessage
	{
		/// <summary>
		/// An empty close message with no error and <see cref="P:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage.AllowReconnect" /> set to <see langword="false" />.
		/// </summary>
		public static readonly CloseMessage Empty;

		/// <summary>
		/// Gets the optional error message.
		/// </summary>
		public string? Error
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// If <see langword="false" />, clients with automatic reconnects enabled should not attempt to automatically reconnect after receiving the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage" />.
		/// </summary>
		public bool AllowReconnect
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage" /> class with an optional error message and <see cref="P:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage.AllowReconnect" /> set to <see langword="false" />.
		/// </summary>
		/// <param name="error">An optional error message.</param>
		public CloseMessage(string? error)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage" /> class with an optional error message and a <see cref="T:System.Boolean" /> indicating whether or not a client with
		/// automatic reconnects enabled should attempt to reconnect upon receiving the message.
		/// </summary>
		/// <param name="error">An optional error message.</param>
		/// <param name="allowReconnect">
		/// <see langword="true" />, if client with automatic reconnects enabled should attempt to reconnect after receiving the <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.CloseMessage" />;
		/// <see langword="false" />, if the client should not try to reconnect whether or not automatic reconnects are enabled.
		/// </param>
		public CloseMessage(string? error, bool allowReconnect)
		{
			throw null;
		}
	}
}
