namespace System.Net.Http
{
	/// <summary>
	/// A factory abstraction for a component that can create <see cref="T:System.Net.Http.HttpMessageHandler" /> instances with custom
	/// configuration for a given logical name.
	/// </summary>
	/// <remarks>
	/// A default <see cref="T:System.Net.Http.IHttpMessageHandlerFactory" /> can be registered in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />
	/// by calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientFactoryServiceCollectionExtensions.AddHttpClient(Microsoft.Extensions.DependencyInjection.IServiceCollection)" />.
	/// The default <see cref="T:System.Net.Http.IHttpMessageHandlerFactory" /> will be registered in the service collection as a singleton.
	/// </remarks>
	public interface IHttpMessageHandlerFactory
	{
		/// <summary>
		/// Creates and configures an <see cref="T:System.Net.Http.HttpMessageHandler" /> instance using the configuration that corresponds
		/// to the logical name specified by <paramref name="name" />.
		/// </summary>
		/// <param name="name">The logical name of the message handler to create.</param>
		/// <returns>A new <see cref="T:System.Net.Http.HttpMessageHandler" /> instance.</returns>
		/// <remarks>
		/// <para>
		/// The default <see cref="T:System.Net.Http.IHttpMessageHandlerFactory" /> implementation may cache the underlying
		/// <see cref="T:System.Net.Http.HttpMessageHandler" /> instances to improve performance.
		/// </para>
		/// <para>
		/// The default <see cref="T:System.Net.Http.IHttpMessageHandlerFactory" /> implementation also manages the lifetime of the
		/// handler created, so disposing of the <see cref="T:System.Net.Http.HttpMessageHandler" /> returned by this method may
		/// have no effect.
		/// </para>
		/// </remarks>
		HttpMessageHandler CreateHandler(string name);
	}
}
