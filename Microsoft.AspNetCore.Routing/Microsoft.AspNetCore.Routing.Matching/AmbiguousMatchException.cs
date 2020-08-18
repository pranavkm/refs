using System;
using System.Runtime.Serialization;

namespace Microsoft.AspNetCore.Routing.Matching
{
	/// <summary>
	/// An exception which indicates multiple matches in endpoint selection.
	/// </summary>
	[Serializable]
	internal class AmbiguousMatchException : Exception
	{
		public AmbiguousMatchException(string message)
		{
			throw null;
		}

		protected AmbiguousMatchException(SerializationInfo info, StreamingContext context)
		{
			throw null;
		}
	}
}
