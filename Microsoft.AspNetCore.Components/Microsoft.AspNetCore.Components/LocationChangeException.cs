using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Components
{
	/// <summary>
	/// An exception thrown when <see cref="E:Microsoft.AspNetCore.Components.NavigationManager.LocationChanged" /> throws an exception.
	/// </summary>
	public sealed class LocationChangeException : Exception
	{
		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Components.LocationChangeException" />.
		/// </summary>
		/// <param name="message">The exception message.</param>
		/// <param name="innerException">The inner exception.</param>
		[System.Runtime.CompilerServices.NullableContext(1)]
		public LocationChangeException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
