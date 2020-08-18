using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// Exception thrown when an <see cref="T:Microsoft.AspNetCore.Components.NavigationManager" /> is not able to navigate to a different url.
	/// </summary>
	public class NavigationException : Exception
	{
		/// <summary>
		/// Gets the uri to which navigation was attempted.
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
		/// Initializes a new <see cref="T:Microsoft.AspNetCore.Components.NavigationException" /> instance.
		/// </summary>
		public NavigationException(string uri)
		{
			throw null;
		}
	}
}
