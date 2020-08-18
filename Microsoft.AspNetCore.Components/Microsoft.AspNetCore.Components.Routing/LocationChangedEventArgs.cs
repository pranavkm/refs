using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components.Routing
{
	/// <summary>
	/// <see cref="T:System.EventArgs" /> for <see cref="E:Microsoft.AspNetCore.Components.NavigationManager.LocationChanged" />.
	/// </summary>
	public class LocationChangedEventArgs : EventArgs
	{
		/// <summary>
		/// Gets the changed location.
		/// </summary>
		public string Location
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a value that determines if navigation for the link was intercepted.
		/// </summary>
		public bool IsNavigationIntercepted
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of <see cref="T:Microsoft.AspNetCore.Components.Routing.LocationChangedEventArgs" />.
		/// </summary>
		/// <param name="location">The location.</param>
		/// <param name="isNavigationIntercepted">A value that determines if navigation for the link was intercepted.</param>
		public LocationChangedEventArgs(string location, bool isNavigationIntercepted)
		{
			throw null;
		}
	}
}
