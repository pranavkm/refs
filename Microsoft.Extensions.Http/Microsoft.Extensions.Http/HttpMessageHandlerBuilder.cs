using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http
{
	/// <summary>
	/// A builder abstraction for configuring <see cref="T:System.Net.Http.HttpMessageHandler" /> instances.
	/// </summary>
	/// <remarks>
	/// The <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" /> is registered in the service collection as
	/// a transient service. Callers should retrieve a new instance for each <see cref="T:System.Net.Http.HttpMessageHandler" /> to
	/// be created. Implementors should expect each instance to be used a single time.
	/// </remarks>
	public abstract class HttpMessageHandlerBuilder
	{
		/// <summary>
		/// Gets a list of additional <see cref="T:System.Net.Http.DelegatingHandler" /> instances used to configure an
		/// <see cref="T:System.Net.Http.HttpClient" /> pipeline.
		/// </summary>
		public abstract IList<DelegatingHandler> AdditionalHandlers
		{
			get;
		}

		/// <summary>
		/// Gets or sets the name of the <see cref="T:System.Net.Http.HttpClient" /> being created.
		/// </summary>
		/// <remarks>
		/// The <see cref="P:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.Name" /> is set by the <see cref="T:System.Net.Http.IHttpClientFactory" /> infrastructure
		/// and is public for unit testing purposes only. Setting the <see cref="P:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.Name" /> outside of
		/// testing scenarios may have unpredictable results.
		/// </remarks>
		public abstract string Name
		{
			get;
			set;
		}

		/// <summary>
		/// Gets or sets the primary <see cref="T:System.Net.Http.HttpMessageHandler" />.
		/// </summary>
		public abstract HttpMessageHandler PrimaryHandler
		{
			get;
			set;
		}

		/// <summary>
		/// Gets an <see cref="T:System.IServiceProvider" /> which can be used to resolve services
		/// from the dependency injection container.
		/// </summary>
		/// <remarks>
		/// This property is sensitive to the value of
		/// <see cref="P:Microsoft.Extensions.Http.HttpClientFactoryOptions.SuppressHandlerScope" />. If <c>true</c> this
		/// property will be a reference to the application's root service provider. If <c>false</c>
		/// (default) this will be a reference to a scoped service provider that has the same
		/// lifetime as the handler being created.
		/// </remarks>
		public virtual IServiceProvider Services
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Creates an <see cref="T:System.Net.Http.HttpMessageHandler" />.
		/// </summary>
		/// <returns>
		/// An <see cref="T:System.Net.Http.HttpMessageHandler" /> built from the <see cref="P:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.PrimaryHandler" /> and
		/// <see cref="P:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.AdditionalHandlers" />.
		/// </returns>
		public abstract HttpMessageHandler Build();

		protected internal static HttpMessageHandler CreateHandlerPipeline(HttpMessageHandler primaryHandler, IEnumerable<DelegatingHandler> additionalHandlers)
		{
			throw null;
		}
	}
}
