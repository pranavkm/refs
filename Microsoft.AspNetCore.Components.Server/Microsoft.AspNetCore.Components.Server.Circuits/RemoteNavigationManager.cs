using Microsoft.AspNetCore.Components.Routing;
using Microsoft.Extensions.Logging;
using Microsoft.JSInterop;

namespace Microsoft.AspNetCore.Components.Server.Circuits
{
	/// <summary>
	/// A Server-Side Blazor implementation of <see cref="T:Microsoft.AspNetCore.Components.NavigationManager" />.
	/// </summary>
	internal class RemoteNavigationManager : NavigationManager, IHostEnvironmentNavigationManager
	{
		private static class Log
		{
			public static void RequestingNavigation(ILogger logger, string uri, bool forceLoad)
			{
				throw null;
			}

			public static void ReceivedLocationChangedNotification(ILogger logger, string uri, bool isIntercepted)
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets whether the circuit has an attached <see cref="T:Microsoft.JSInterop.IJSRuntime" />.
		/// </summary>
		public bool HasAttachedJSRuntime
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.RemoteNavigationManager" /> instance.
		/// </summary>
		/// <param name="logger">The <see cref="T:Microsoft.Extensions.Logging.ILogger`1" />.</param>
		public RemoteNavigationManager(ILogger<RemoteNavigationManager> logger)
		{
			throw null;
		}

		/// <summary>
		/// Initializes the <see cref="T:Microsoft.AspNetCore.Components.NavigationManager" />.
		/// </summary>
		/// <param name="baseUri">The base URI.</param>
		/// <param name="uri">The absolute URI.</param>
		public new void Initialize(string baseUri, string uri)
		{
			throw null;
		}

		/// <summary>
		/// Initializes the <see cref="T:Microsoft.AspNetCore.Components.Server.Circuits.RemoteNavigationManager" />.
		/// </summary>
		/// <param name="jsRuntime">The <see cref="T:Microsoft.JSInterop.IJSRuntime" /> to use for interoperability.</param>
		public void AttachJsRuntime(IJSRuntime jsRuntime)
		{
			throw null;
		}

		public void NotifyLocationChanged(string uri, bool intercepted)
		{
			throw null;
		}

		/// <inheritdoc />
		protected override void NavigateToCore(string uri, bool forceLoad)
		{
			throw null;
		}
	}
}
