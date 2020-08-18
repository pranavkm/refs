using Microsoft.AspNetCore.Connections;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.Connections.IConnectionBuilder" />.
	/// </summary>
	public static class SignalRConnectionBuilderExtensions
	{
		/// <summary>
		/// Configure the connection to host the specified <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type.
		/// </summary>
		/// <typeparam name="THub">The <see cref="T:Microsoft.AspNetCore.SignalR.Hub" /> type to host on the connection.</typeparam>
		/// <param name="connectionBuilder">The connection to configure.</param>
		/// <returns>The same instance of the <see cref="T:Microsoft.AspNetCore.Connections.IConnectionBuilder" /> for chaining.</returns>
		public static IConnectionBuilder UseHub<[DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)11)] THub>(this IConnectionBuilder connectionBuilder) where THub : Hub
		{
			throw null;
		}
	}
}
