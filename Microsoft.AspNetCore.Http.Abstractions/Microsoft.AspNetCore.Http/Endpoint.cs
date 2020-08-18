using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents a logical endpoint in an application.
	/// </summary>
	public class Endpoint
	{
		/// <summary>
		/// Gets the informational display name of this endpoint.
		/// </summary>
		public string? DisplayName
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the collection of metadata associated with this endpoint.
		/// </summary>
		public EndpointMetadataCollection Metadata
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets the delegate used to process requests for the endpoint.
		/// </summary>
		public RequestDelegate RequestDelegate
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates a new instance of <see cref="T:Microsoft.AspNetCore.Http.Endpoint" />.
		/// </summary>
		/// <param name="requestDelegate">The delegate used to process requests for the endpoint.</param>
		/// <param name="metadata">
		/// The endpoint <see cref="T:Microsoft.AspNetCore.Http.EndpointMetadataCollection" />. May be null.
		/// </param>
		/// <param name="displayName">
		/// The informational display name of the endpoint. May be null.
		/// </param>
		[System.Runtime.CompilerServices.NullableContext(2)]
		public Endpoint(RequestDelegate requestDelegate, EndpointMetadataCollection? metadata, string? displayName)
		{
			throw null;
		}

		public override string? ToString()
		{
			throw null;
		}
	}
}
