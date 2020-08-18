using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace Microsoft.AspNetCore.Routing.Patterns
{
	/// <summary>
	/// An exception that is thrown for error constructing a <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePattern" />.
	/// </summary>
	[Serializable]
	public sealed class RoutePatternException : Exception
	{
		/// <summary>
		/// Gets the route pattern associated with this exception.
		/// </summary>
		public string Pattern
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Routing.Patterns.RoutePatternException" />.
		/// </summary>
		/// <param name="pattern">The route pattern as raw text.</param>
		/// <param name="message">The exception message.</param>
		public RoutePatternException(string pattern, string message)
		{
			throw null;
		}

		/// <summary>
		/// Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with the data needed to serialize the target object.
		/// </summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> to populate with data.</param>
		/// <param name="context">The destination (<see cref="T:System.Runtime.Serialization.StreamingContext" />) for this serialization.</param>
		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
