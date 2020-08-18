using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Http.Features.Authentication;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Claims;
using System.Threading;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Represents an implementation of the HTTP Context class. 
	/// </summary>
	public sealed class DefaultHttpContext : HttpContext
	{
		private struct FeatureInterfaces
		{
			public IItemsFeature? Items;

			public IServiceProvidersFeature? ServiceProviders;

			public IHttpAuthenticationFeature? Authentication;

			public IHttpRequestLifetimeFeature? Lifetime;

			public ISessionFeature? Session;

			public IHttpRequestIdentifierFeature? RequestIdentifier;
		}

		/// <summary>
		/// Gets or set the <see cref="P:Microsoft.AspNetCore.Http.DefaultHttpContext.FormOptions" /> for this instance.
		/// </summary>
		/// <returns>
		/// <see cref="P:Microsoft.AspNetCore.Http.DefaultHttpContext.FormOptions" />        
		/// </returns>
		public FormOptions FormOptions
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
		/// Gets or sets the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceScopeFactory" /> for this instance.
		/// </summary>
		/// <returns>   
		/// <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceScopeFactory" />      
		/// </returns>
		public IServiceScopeFactory ServiceScopeFactory
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

		/// <inheritdoc />
		public override IFeatureCollection Features
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override HttpRequest Request
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override HttpResponse Response
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override ConnectionInfo Connection
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override WebSocketManager WebSockets
		{
			get
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override ClaimsPrincipal User
		{
			get
			{
				throw null;
			}
			set
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
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override IServiceProvider RequestServices
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override CancellationToken RequestAborted
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override string TraceIdentifier
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public override ISession Session
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public HttpContext HttpContext
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" /> class.
		/// </summary>
		public DefaultHttpContext()
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" /> class with provided features.
		/// </summary>
		/// <param name="features">Initial set of features for the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" />.</param>
		public DefaultHttpContext(IFeatureCollection features)
		{
			throw null;
		}

		/// <summary>
		/// Reinitialize  the current instant of the class with features passed in.
		/// </summary>
		/// <remarks>
		/// This method allows the consumer to re-use the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" /> for another request, rather than having to allocate a new instance.
		/// </remarks>
		/// <param name="features">The new set of features for the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" />.</param>
		public void Initialize(IFeatureCollection features)
		{
			throw null;
		}

		/// <summary>
		/// Uninitialize all the features in the <see cref="T:Microsoft.AspNetCore.Http.DefaultHttpContext" />.
		/// </summary>
		public void Uninitialize()
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
