using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.CompilerServices;

namespace Microsoft.Extensions.Http
{
	/// <summary>
	/// An options class for configuring the default <see cref="T:System.Net.Http.IHttpClientFactory" />.
	/// </summary>
	public class HttpClientFactoryOptions
	{
		/// <summary>
		/// Gets or sets the length of time that a <see cref="T:System.Net.Http.HttpMessageHandler" /> instance can be reused. Each named
		/// client can have its own configured handler lifetime value. The default value of this property is two minutes.
		/// Set the lifetime to <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" /> to disable handler expiry.
		/// </summary>
		/// <remarks>
		/// <para>
		/// The default implementation of <see cref="T:System.Net.Http.IHttpClientFactory" /> will pool the <see cref="T:System.Net.Http.HttpMessageHandler" />
		/// instances created by the factory to reduce resource consumption. This setting configures the amount of time
		/// a handler can be pooled before it is scheduled for removal from the pool and disposal.
		/// </para>
		/// <para>
		/// Pooling of handlers is desirable as each handler typically manages its own underlying HTTP connections; creating
		/// more handlers than necessary can result in connection delays. Some handlers also keep connections open indefinitely
		/// which can prevent the handler from reacting to DNS changes. The value of <see cref="P:Microsoft.Extensions.Http.HttpClientFactoryOptions.HandlerLifetime" /> should be
		/// chosen with an understanding of the application's requirement to respond to changes in the network environment.
		/// </para>
		/// <para>
		/// Expiry of a handler will not immediately dispose the handler. An expired handler is placed in a separate pool
		/// which is processed at intervals to dispose handlers only when they become unreachable. Using long-lived
		/// <see cref="T:System.Net.Http.HttpClient" /> instances will prevent the underlying <see cref="T:System.Net.Http.HttpMessageHandler" /> from being
		/// disposed until all references are garbage-collected.
		/// </para>
		/// </remarks>
		public TimeSpan HandlerLifetime
		{
			get
			{
				throw null;
			}
			set
			{
			}
		}

		/// <summary>
		/// Gets a list of operations used to configure an <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		public IList<Action<HttpClient>> HttpClientActions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Gets a list of operations used to configure an <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" />.
		/// </summary>
		public IList<Action<HttpMessageHandlerBuilder>> HttpMessageHandlerBuilderActions
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The <see cref="T:System.Func`2" /> which determines whether to redact the HTTP header value before logging.
		/// </summary>
		public Func<string, bool> ShouldRedactHeaderValue
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		/// <summary>
		/// <para>
		/// Gets or sets a value that determines whether the <see cref="T:System.Net.Http.IHttpClientFactory" /> will
		/// create a dependency injection scope when building an <see cref="T:System.Net.Http.HttpMessageHandler" />.
		/// If <c>false</c> (default), a scope will be created, otherwise a scope will not be created.
		/// </para>
		/// <para>
		/// This option is provided for compatibility with existing applications. It is recommended
		/// to use the default setting for new applications.
		/// </para>
		/// </summary>
		/// <remarks>
		/// <para>
		/// The <see cref="T:System.Net.Http.IHttpClientFactory" /> will (by default) create a dependency injection scope
		/// each time it creates an <see cref="T:System.Net.Http.HttpMessageHandler" />. The created scope has the same
		/// lifetime as the message handler, and will be disposed when the message handler is disposed.
		/// </para>
		/// <para>
		/// When operations that are part of <see cref="P:Microsoft.Extensions.Http.HttpClientFactoryOptions.HttpMessageHandlerBuilderActions" /> are executed
		/// they will be provided with the scoped <see cref="T:System.IServiceProvider" /> via
		/// <see cref="P:Microsoft.Extensions.Http.HttpMessageHandlerBuilder.Services" />. This includes retrieving a message handler
		/// from dependency injection, such as one registered using
		/// <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddHttpMessageHandler``1(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder)" />.
		/// </para>
		/// </remarks>
		public bool SuppressHandlerScope
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
			}
		}
	}
}
