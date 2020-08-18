using System;
using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// Extension methods to configure an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> for <see cref="T:System.Net.Http.IHttpClientFactory" />.
	/// </summary>
	public static class HttpClientFactoryServiceCollectionExtensions
	{
		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</returns>
		public static IServiceCollection AddHttpClient(this IServiceCollection services)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient(this IServiceCollection services, string name)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient(this IServiceCollection services, string name, Action<IServiceProvider, HttpClient> configureClient)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient(this IServiceCollection services, string name, Action<HttpClient> configureClient)
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name
		/// will be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services, Action<IServiceProvider, HttpClient> configureClient) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services, Action<HttpClient> configureClient) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services, string name) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services, string name, Action<IServiceProvider, HttpClient> configureClient) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>(this IServiceCollection services, string name, Action<HttpClient> configureClient) where TClient : class
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services, Action<IServiceProvider, HttpClient> configureClient) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services, Action<HttpClient> configureClient) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="factory">A delegate that is used to create an instance of <typeparamref name="TClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, TImplementation>(this IServiceCollection services, Func<HttpClient, IServiceProvider, TImplementation> factory) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="factory">A delegate that is used to create an instance of <typeparamref name="TClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, TImplementation>(this IServiceCollection services, Func<HttpClient, TImplementation> factory) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />. The client name will
		/// be set to the type name of <typeparamref name="TClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services, string name) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services, string name, Action<IServiceProvider, HttpClient> configureClient) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client. The type specified will be instantiated by the
		/// <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" />
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="configureClient">A delegate that is used to configure an <see cref="T:System.Net.Http.HttpClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <para>
		/// Use <see cref="F:Microsoft.Extensions.Options.Options.DefaultName" /> as the name to configure the default client.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, [System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TImplementation>(this IServiceCollection services, string name, Action<HttpClient> configureClient) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="factory">A delegate that is used to create an instance of <typeparamref name="TClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, TImplementation>(this IServiceCollection services, string name, Func<HttpClient, IServiceProvider, TImplementation> factory) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}

		/// <summary>
		/// Adds the <see cref="T:System.Net.Http.IHttpClientFactory" /> and related services to the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" /> and configures
		/// a binding between the <typeparamref name="TClient" /> type and a named <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <typeparam name="TClient">
		/// The type of the typed client. The type specified will be registered in the service collection as
		/// a transient service. See <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> for more details about authoring typed clients.
		/// </typeparam>
		/// <typeparam name="TImplementation">
		/// The implementation type of the typed client.
		/// </typeparam>
		/// <param name="services">The <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.</param>
		/// <param name="name">The logical name of the <see cref="T:System.Net.Http.HttpClient" /> to configure.</param>
		/// <param name="factory">A delegate that is used to create an instance of <typeparamref name="TClient" />.</param>
		/// <returns>An <see cref="T:Microsoft.Extensions.DependencyInjection.IHttpClientBuilder" /> that can be used to configure the client.</returns>
		/// <remarks>
		/// <para>
		/// <see cref="T:System.Net.Http.HttpClient" /> instances that apply the provided configuration can be retrieved using
		/// <see cref="M:System.Net.Http.IHttpClientFactory.CreateClient(System.String)" /> and providing the matching name.
		/// </para>
		/// <para>
		/// <typeparamref name="TClient" /> instances constructed with the appropriate <see cref="T:System.Net.Http.HttpClient" />
		/// can be retrieved from <see cref="M:System.IServiceProvider.GetService(System.Type)" /> (and related methods) by providing
		/// <typeparamref name="TClient" /> as the service type.
		/// </para>
		/// <typeparamref name="TImplementation">
		/// </typeparamref>
		/// </remarks>
		public static IHttpClientBuilder AddHttpClient<TClient, TImplementation>(this IServiceCollection services, string name, Func<HttpClient, TImplementation> factory) where TClient : class where TImplementation : class, TClient
		{
			throw null;
		}
	}
}
