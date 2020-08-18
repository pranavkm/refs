using Microsoft.Extensions.Http;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods for configuring an <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />
	/// </summary>
	public static class HttpClientBuilderExtensions
	{
		/// <summary>
		/// Adds a delegate that will be used to create an additional message handler for a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureHandler">A delegate that is used to create a <see cref="T:System.Net.Http.DelegatingHandler" />.</param>       /// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// The <see paramref="configureHandler" /> delegate should return a new instance of the message handler each time it
		/// is invoked.
		/// </para>
		/// <para>
		/// The <see cref="T:System.IServiceProvider" /> argument provided to <paramref name="configureHandler" /> will be
		/// a reference to a scoped service provider that shares the lifetime of the handler being constructed.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpMessageHandler(this IHttpClientBuilder builder, Func<IServiceProvider, DelegatingHandler> configureHandler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to create an additional message handler for a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureHandler">A delegate that is used to create a <see cref="T:System.Net.Http.DelegatingHandler" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// The <see paramref="configureHandler" /> delegate should return a new instance of the message handler each time it
		/// is invoked.
		/// </remarks>
		public static IHttpClientBuilder AddHttpMessageHandler(this IHttpClientBuilder builder, Func<DelegatingHandler> configureHandler)
		{
			throw null;
		}

		/// <summary>
		/// Adds an additional message handler from the dependency injection container for a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <typeparam name="THandler">
		/// The type of the <see cref="T:System.Net.Http.DelegatingHandler" />. The handler type must be registered as a transient service.
		/// </typeparam>
		/// <remarks>
		/// <para>
		/// The <typeparamref name="THandler" /> will be resolved from a scoped service provider that shares
		/// the lifetime of the handler being constructed.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpMessageHandler<THandler>(this IHttpClientBuilder builder) where THandler : DelegatingHandler
		{
			throw null;
		}

		/// <summary>
		/// Configures a binding between the <typeparamref name="TClient" /> type and the named <see cref="T:System.Net.Http.HttpClient" />
		/// associated with the <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <remarks>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddTypedClient``1(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder)" /> will register a typed
		/// client binding that creates <typeparamref name="TClient" /> using the <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />.
		/// </para>
		/// <para>
		/// The typed client's service dependencies will be resolved from the same service provider
		/// that is used to resolve the typed client. It is not possible to access services from the
		/// scope bound to the message handler, which is managed independently.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddTypedClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IHttpClientBuilder builder) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Configures a binding between the <typeparamref name="TClient" /> type and the named <see cref="T:System.Net.Http.HttpClient" />
		/// associated with the <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. They type specified will be registered in the service collection as
		/// a transient service.
		/// </typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="factory">A factory function that will be used to construct the typed client.</param>
		/// <remarks>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddTypedClient``1(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder,System.Func{System.Net.Http.HttpClient,System.IServiceProvider,``0})" />
		/// will register a typed client binding that creates <typeparamref name="TClient" /> using the provided factory function.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddTypedClient<TClient>(this IHttpClientBuilder builder, Func<HttpClient, IServiceProvider, TClient> factory) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Configures a binding between the <typeparamref name="TClient" /> type and the named <see cref="T:System.Net.Http.HttpClient" />
		/// associated with the <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. They type specified will be registered in the service collection as
		/// a transient service.
		/// </typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="factory">A factory function that will be used to construct the typed client.</param>
		/// <remarks>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddTypedClient``1(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder,System.Func{System.Net.Http.HttpClient,``0})" />
		/// will register a typed client binding that creates <typeparamref name="TClient" /> using the provided factory function.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddTypedClient<TClient>(this IHttpClientBuilder builder, Func<HttpClient, TClient> factory) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Configures a binding between the <typeparamref name="TClient" /> type and the named <see cref="T:System.Net.Http.HttpClient" />
		/// associated with the <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />. The created instances will be of type
		/// <typeparamref name="TImplementation" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The declared type of the typed client. They type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified by will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />.
		/// </typeparam>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <remarks>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddTypedClient``2(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder)" />
		/// will register a typed client binding that creates <typeparamref name="TImplementation" /> using the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />.
		/// </para>
		/// <para>
		/// The typed client's service dependencies will be resolved from the same service provider
		/// that is used to resolve the typed client. It is not possible to access services from the
		/// scope bound to the message handler, which is managed independently.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddTypedClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IHttpClientBuilder builder) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to configure a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// The <see cref="T:System.IServiceProvider" /> provided to <paramref name="configureClient" /> will be the
		/// same application's root service provider instance.
		/// </remarks>
		public static IHttpClientBuilder ConfigureHttpClient(this IHttpClientBuilder builder, Action<IServiceProvider, HttpClient> configureClient)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to configure a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		public static IHttpClientBuilder ConfigureHttpClient(this IHttpClientBuilder builder, Action<HttpClient> configureClient)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to configure message handlers using <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" />
		/// for a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureBuilder">A delegate that is used to configure an <see cref="T:Microsoft.Extensions.Http.HttpMessageHandlerBuilder" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		public static IHttpClientBuilder ConfigureHttpMessageHandlerBuilder(this IHttpClientBuilder builder, Action<HttpMessageHandlerBuilder> configureBuilder)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to configure the primary <see cref="T:System.Net.Http.HttpMessageHandler" /> for a
		/// named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureHandler">A delegate that is used to create an <see cref="T:System.Net.Http.HttpMessageHandler" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// The <see paramref="configureHandler" /> delegate should return a new instance of the message handler each time it
		/// is invoked.
		/// </para>
		/// <para>
		/// The <see cref="T:System.IServiceProvider" /> argument provided to <paramref name="configureHandler" /> will be
		/// a reference to a scoped service provider that shares the lifetime of the handler being constructed.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder ConfigurePrimaryHttpMessageHandler(this IHttpClientBuilder builder, Func<IServiceProvider, HttpMessageHandler> configureHandler)
		{
			throw null;
		}

		/// <summary>
		/// Adds a delegate that will be used to configure the primary <see cref="T:System.Net.Http.HttpMessageHandler" /> for a
		/// named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="configureHandler">A delegate that is used to create an <see cref="T:System.Net.Http.HttpMessageHandler" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// The <see paramref="configureHandler" /> delegate should return a new instance of the message handler each time it
		/// is invoked.
		/// </remarks>
		public static IHttpClientBuilder ConfigurePrimaryHttpMessageHandler(this IHttpClientBuilder builder, Func<HttpMessageHandler> configureHandler)
		{
			throw null;
		}

		/// <summary>
		/// Configures the primary <see cref="T:System.Net.Http.HttpMessageHandler" /> from the dependency injection container
		/// for a  named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <typeparam name="THandler">
		/// The type of the <see cref="T:System.Net.Http.DelegatingHandler" />. The handler type must be registered as a transient service.
		/// </typeparam>
		/// <remarks>
		/// <para>
		/// The <typeparamref name="THandler" /> will be resolved from a scoped service provider that shares
		/// the lifetime of the handler being constructed.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder ConfigurePrimaryHttpMessageHandler<THandler>(this IHttpClientBuilder builder) where THandler : HttpMessageHandler
		{
			throw null;
		}

		/// <summary>
		/// Sets the collection of HTTP headers names for which values should be redacted before logging.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="redactedLoggedHeaderNames">The collection of HTTP headers names for which values should be redacted before logging.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</returns>
		public static IHttpClientBuilder RedactLoggedHeaders(this IHttpClientBuilder builder, IEnumerable<string> redactedLoggedHeaderNames)
		{
			throw null;
		}

		/// <summary>
		/// Sets the <see cref="T:System.Func`2" /> which determines whether to redact the HTTP header value before logging.
		/// </summary>
		/// <param name="builder">The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</param>
		/// <param name="shouldRedactHeaderValue">The <see cref="T:System.Func`2" /> which determines whether to redact the HTTP header value before logging.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" />.</returns>
		/// <remarks>The provided <paramref name="shouldRedactHeaderValue" /> predicate will be evaluated for each header value when logging. If the predicate returns <c>true</c> then the header value will be replaced with a marker value <c>*</c> in logs; otherwise the header value will be logged.
		/// </remarks>
		public static IHttpClientBuilder RedactLoggedHeaders(this IHttpClientBuilder builder, Func<string, bool> shouldRedactHeaderValue)
		{
			throw null;
		}

		/// <summary>
		/// Sets the length of time that a <see cref="T:System.Net.Http.HttpMessageHandler" /> instance can be reused. Each named
		/// client can have its own configured handler lifetime value. The default value is two minutes. Set the lifetime to
		/// <see cref="F:System.Threading.Timeout.InfiniteTimeSpan" /> to disable handler expiry.
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
		/// which can prevent the handler from reacting to DNS changes. The value of <paramref name="handlerLifetime" /> should be
		/// chosen with an understanding of the application's requirement to respond to changes in the network environment.
		/// </para>
		/// <para>
		/// Expiry of a handler will not immediately dispose the handler. An expired handler is placed in a separate pool
		/// which is processed at intervals to dispose handlers only when they become unreachable. Using long-lived
		/// <see cref="T:System.Net.Http.HttpClient" /> instances will prevent the underlying <see cref="T:System.Net.Http.HttpMessageHandler" /> from being
		/// disposed until all references are garbage-collected.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder SetHandlerLifetime(this IHttpClientBuilder builder, TimeSpan handlerLifetime)
		{
			throw null;
		}
	}
}
