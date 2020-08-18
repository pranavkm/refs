using System;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.AspNetCore.SignalR
{
	/// <summary>
	/// Methods to add <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" />'s to Hubs.
	/// </summary>
	public static class HubOptionsExtensions
	{
		/// <summary>
		/// Adds an instance of an <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" /> to the <see cref="T:Microsoft.AspNetCore.SignalR.HubOptions" />.
		/// </summary>
		/// <param name="options">The options to add a filter to.</param>
		/// <param name="hubFilter">The filter instance to add to the options.</param>
		public static void AddFilter(this HubOptions options, IHubFilter hubFilter)
		{
			throw null;
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" /> type to the <see cref="T:Microsoft.AspNetCore.SignalR.HubOptions" /> that will be resolved via DI or type activated.
		/// </summary>
		/// <typeparam name="TFilter">The <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" /> type that will be added to the options.</typeparam>
		/// <param name="options">The options to add a filter to.</param>
		public static void AddFilter<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] TFilter>(this HubOptions options) where TFilter : IHubFilter
		{
			throw null;
		}

		/// <summary>
		/// Adds an <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" /> type to the <see cref="T:Microsoft.AspNetCore.SignalR.HubOptions" /> that will be resolved via DI or type activated.
		/// </summary>
		/// <param name="options">The options to add a filter to.</param>
		/// <param name="filterType">The <see cref="T:Microsoft.AspNetCore.SignalR.IHubFilter" /> type that will be added to the options.</param>
		public static void AddFilter(this HubOptions options, [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)] Type filterType)
		{
			throw null;
		}
	}
}
