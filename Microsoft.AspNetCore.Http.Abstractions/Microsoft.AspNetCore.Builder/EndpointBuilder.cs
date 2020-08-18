using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Builder
{
	/// <summary>
	/// A base class for building an new <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.
	/// </summary>
	public abstract class EndpointBuilder
	{
		/// <summary>
		/// Gets or sets the delegate used to process requests for the endpoint.
		/// </summary>
		public RequestDelegate? RequestDelegate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets or sets the informational display name of this endpoint.
		/// </summary>
		public string? DisplayName
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the collection of metadata associated with this endpoint.
		/// </summary>
		public IList<object> Metadata
		{
			[System.Runtime.CompilerServices.NullableContext(1)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an instance of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" /> from the <see cref="T:Microsoft.AspNetCore.Builder.EndpointBuilder" />.
		/// </summary>
		/// <returns>The created <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.</returns>
		public abstract Endpoint Build();

		protected EndpointBuilder()
		{
			throw null;
		}
	}
}
