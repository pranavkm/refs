using Microsoft.AspNetCore.SignalR;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRBuilder" />.
	/// </summary>
	public static class JsonProtocolDependencyInjectionExtensions
	{
		/// <summary>
		/// Enables the JSON protocol for SignalR.
		/// </summary>
		/// <remarks>
		/// This has no effect if the JSON protocol has already been enabled.
		/// </remarks>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRBuilder" /> representing the SignalR server to add JSON protocol support to.</param>
		/// <returns>The value of <paramref name="builder" /></returns>
		public static TBuilder AddJsonProtocol<TBuilder>(this TBuilder builder) where TBuilder : ISignalRBuilder
		{
			throw null;
		}

		/// <summary>
		/// Enables the JSON protocol for SignalR and allows options for the JSON protocol to be configured.
		/// </summary>
		/// <remarks>
		/// Any options configured here will be applied, even if the JSON protocol has already been registered with the server.
		/// </remarks>
		/// <param name="builder">The <see cref="T:Microsoft.AspNetCore.SignalR.ISignalRBuilder" /> representing the SignalR server to add JSON protocol support to.</param>
		/// <param name="configure">A delegate that can be used to configure the <see cref="T:Microsoft.AspNetCore.SignalR.JsonHubProtocolOptions" /></param>
		/// <returns>The value of <paramref name="builder" /></returns>
		public static TBuilder AddJsonProtocol<TBuilder>(this TBuilder builder, Action<JsonHubProtocolOptions> configure) where TBuilder : ISignalRBuilder
		{
			throw null;
		}
	}
}
