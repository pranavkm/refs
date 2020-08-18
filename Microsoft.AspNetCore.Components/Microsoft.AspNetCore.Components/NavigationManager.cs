using Microsoft.AspNetCore.Components.Routing;
using System;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Provides an abstraction for querying and managing URI navigation.
	/// </summary>
	public abstract class NavigationManager
	{
		/// <summary>
		/// Gets or sets the current base URI. The <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.BaseUri" /> is always represented as an absolute URI in string form with trailing slash.
		/// Typically this corresponds to the 'href' attribute on the document's &lt;base&gt; element.
		/// </summary>
		/// <remarks>
		/// Setting <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.BaseUri" /> will not trigger the <see cref="E:Microsoft.AspNetCore.Components.NavigationManager.LocationChanged" /> event.
		/// </remarks>
		public string BaseUri
		{
			get
			{
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the current URI. The <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.Uri" /> is always represented as an absolute URI in string form.
		/// </summary>
		/// <remarks>
		/// Setting <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.Uri" /> will not trigger the <see cref="E:Microsoft.AspNetCore.Components.NavigationManager.LocationChanged" /> event.
		/// </remarks>
		public string Uri
		{
			get
			{
				throw null;
			}
			protected set
			{
				throw null;
			}
		}

		/// <summary>
		/// An event that fires when the navigation location has changed.
		/// </summary>
		public event EventHandler<LocationChangedEventArgs> LocationChanged
		{
			add
			{
				throw null;
			}
			remove
			{
				throw null;
			}
		}

		/// <summary>
		/// Navigates to the specified URI.
		/// </summary>
		/// <param name="uri">The destination URI. This can be absolute, or relative to the base URI
		/// (as returned by <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.BaseUri" />).</param>
		/// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
		public void NavigateTo(string uri, bool forceLoad = false)
		{
			throw null;
		}

		/// <summary>
		/// Navigates to the specified URI.
		/// </summary>
		/// <param name="uri">The destination URI. This can be absolute, or relative to the base URI
		/// (as returned by <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.BaseUri" />).</param>
		/// <param name="forceLoad">If true, bypasses client-side routing and forces the browser to load the new page from the server, whether or not the URI would normally be handled by the client-side router.</param>
		protected abstract void NavigateToCore(string uri, bool forceLoad);

		/// <summary>
		/// Called to initialize BaseURI and current URI before these values are used for the first time.
		/// Override <see cref="M:Microsoft.AspNetCore.Components.NavigationManager.EnsureInitialized" /> and call this method to dynamically calculate these values.
		/// </summary>
		protected void Initialize(string baseUri, string uri)
		{
			throw null;
		}

		/// <summary>
		/// Allows derived classes to lazily self-initialize. Implementations that support lazy-initialization should override
		/// this method and call <see cref="M:Microsoft.AspNetCore.Components.NavigationManager.Initialize(System.String,System.String)" />.
		/// </summary>
		protected virtual void EnsureInitialized()
		{
			throw null;
		}

		/// <summary>
		/// Converts a relative URI into an absolute one (by resolving it
		/// relative to the current absolute URI).
		/// </summary>
		/// <param name="relativeUri">The relative URI.</param>
		/// <returns>The absolute URI.</returns>
		public Uri ToAbsoluteUri(string relativeUri)
		{
			throw null;
		}

		/// <summary>
		/// Given a base URI (e.g., one previously returned by <see cref="P:Microsoft.AspNetCore.Components.NavigationManager.BaseUri" />),
		/// converts an absolute URI into one relative to the base URI prefix.
		/// </summary>
		/// <param name="uri">An absolute URI that is within the space of the base URI.</param>
		/// <returns>A relative URI path.</returns>
		public string ToBaseRelativePath(string uri)
		{
			throw null;
		}

		internal static string NormalizeBaseUri(string baseUri)
		{
			throw null;
		}

		/// <summary>
		/// Triggers the <see cref="E:Microsoft.AspNetCore.Components.NavigationManager.LocationChanged" /> event with the current URI value.
		/// </summary>
		protected void NotifyLocationChanged(bool isInterceptedLink)
		{
			throw null;
		}

		protected NavigationManager()
		{
			throw null;
		}
	}
}
