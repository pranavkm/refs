namespace Microsoft.AspNetCore.SignalR.Protocol
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.IHubProtocol" />.
	/// </summary>
	public static class HubProtocolExtensions
	{
		/// <summary>
		/// Converts the specified <see cref="T:Microsoft.AspNetCore.SignalR.Protocol.HubMessage" /> to its serialized representation.
		/// </summary>
		/// <param name="hubProtocol">The hub protocol.</param>
		/// <param name="message">The message to convert to bytes.</param>
		/// <returns>The serialized representation of the specified message.</returns>
		public static byte[] GetMessageBytes(this IHubProtocol hubProtocol, HubMessage message)
		{
			throw null;
		}
	}
}
