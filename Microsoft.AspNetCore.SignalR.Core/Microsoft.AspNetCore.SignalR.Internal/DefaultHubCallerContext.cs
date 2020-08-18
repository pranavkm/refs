using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;

namespace Microsoft.AspNetCore.SignalR.Internal
{
	/// <summary>
	/// A context for accessing information about the hub caller from their connection.
	/// </summary>
	internal class DefaultHubCallerContext : HubCallerContext
	{
		/// <inheritdoc />
		public override string ConnectionId
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override string? UserIdentifier
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override ClaimsPrincipal? User
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override IDictionary<object, object?> Items
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override IFeatureCollection Features
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override CancellationToken ConnectionAborted
		{
			get
			{
				throw null;
			}
		}

		public DefaultHubCallerContext(HubConnectionContext connection)
		{
			throw null;
		}

		/// <inheritdoc />
		public override void Abort()
		{
			throw null;
		}
	}
}
