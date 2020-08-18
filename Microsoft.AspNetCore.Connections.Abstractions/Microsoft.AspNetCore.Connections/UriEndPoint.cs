using System;
using System.Net;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Connections
{
	/// <summary>
	/// An <see cref="T:System.Net.EndPoint" /> defined by a <see cref="T:System.Uri" />.
	/// </summary>
	public class UriEndPoint : EndPoint
	{
		/// <summary>
		/// The <see cref="T:System.Uri" /> defining the <see cref="T:System.Net.EndPoint" />.
		/// </summary>
		public Uri Uri
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Connections.UriEndPoint" /> class.
		/// </summary>
		/// <param name="uri">The <see cref="T:System.Uri" /> defining the <see cref="T:System.Net.EndPoint" />.</param>
		public UriEndPoint(Uri uri)
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}
	}
}
