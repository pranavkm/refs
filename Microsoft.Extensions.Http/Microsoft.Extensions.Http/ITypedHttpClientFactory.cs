using System.Diagnostics.CodeAnalysis;
using System.Net.Http;

namespace Microsoft.Extensions.Http
{
	/// <summary>
	/// A factory abstraction for a component that can create typed client instances with custom
	/// configuration for a given logical name.
	/// </summary>
	/// <typeparam name="TClient">The type of typed client to create.</typeparam>
	/// <remarks>
	/// <para>
	/// The <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> is infrastructure that supports the
	/// <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientFactoryServiceCollectionExtensions.AddHttpClient``1(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.String)" /> and
	/// <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientBuilderExtensions.AddTypedClient``1(Microsoft.Extensions.DependencyInjection.IHttpClientBuilder)" /> functionality. This type
	/// should rarely be used directly in application code, use <see cref="M:System.IServiceProvider.GetService(System.Type)" /> instead
	/// to retrieve typed clients.
	/// </para>
	/// <para>
	/// A default <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> can be registered in an <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />
	/// by calling <see cref="M:Microsoft.Extensions.DependencyInjection.HttpClientFactoryServiceCollectionExtensions.AddHttpClient(Microsoft.Extensions.DependencyInjection.IServiceCollection)" />.
	/// The default <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> will be registered in the service collection as a singleton
	/// open-generic service.
	/// </para>
	/// <para>
	/// The default <see cref="T:Microsoft.Extensions.Http.ITypedHttpClientFactory`1" /> uses type activation to create typed client instances. Typed
	/// client types are not retrieved directly from the <see cref="T:System.IServiceProvider" />. See
	/// <see cref="M:Microsoft.Extensions.DependencyInjection.ActivatorUtilities.CreateInstance(System.IServiceProvider,System.Type,System.Object[])" /> for details.
	/// </para>
	/// </remarks>
	/// <example>
	/// This sample shows the basic pattern for defining a typed client class.
	/// <code>
	/// class ExampleClient
	/// {
	///     private readonly HttpClient _httpClient;
	///     private readonly ILogger _logger;
	///
	///     // typed clients can use constructor injection to access additional services
	///     public ExampleClient(HttpClient httpClient, ILogger&lt;ExampleClient&gt; logger)
	///     {
	///         _httpClient = httpClient;
	///         _logger = logger;
	///     }
	///
	///     // typed clients can expose the HttpClient for application code to call directly
	///     public HttpClient HttpClient =&gt; _httpClient;
	///
	///     // typed clients can also define methods that abstract usage of the HttpClient
	///     public async Task SendHelloRequest()
	///     {
	///         var response = await _httpClient.GetAsync("/helloworld");
	///         response.EnsureSuccessStatusCode();
	///     }
	/// }
	/// </code>
	/// </example>
	/// <example>
	/// This sample shows how to consume a typed client from an ASP.NET Core middleware.
	/// <code>
	/// // in Startup.cs
	/// public void Configure(IApplicationBuilder app, ExampleClient exampleClient)
	/// {
	///     app.Run(async (context) =&gt;
	///     {
	///         var response = await _exampleClient.GetAsync("/helloworld");
	///         await context.Response.WriteAsync("Remote server said: ");
	///         await response.Content.CopyToAsync(context.Response.Body);
	///     });
	/// }
	/// </code>
	/// </example>
	/// <example>
	/// This sample shows how to consume a typed client from an ASP.NET Core MVC Controller.
	/// <code>
	/// // in Controllers/HomeController.cs
	/// public class HomeController : ControllerBase(IApplicationBuilder app, ExampleClient exampleClient)
	/// {
	///     private readonly ExampleClient _exampleClient;
	///
	///     public HomeController(ExampleClient exampleClient)
	///     {
	///         _exampleClient = exampleClient;
	///     }
	///
	///     public async Task&lt;IActionResult&gt; Index()
	///     {
	///         var response = await _exampleClient.GetAsync("/helloworld");
	///         var text = await response.Content.ReadAsStringAsync();
	///         return Content("Remote server said: " + text, "text/plain");
	///     };
	/// }
	/// </code>
	/// </example>
	public interface ITypedHttpClientFactory<[System.Diagnostics.CodeAnalysis.DynamicallyAccessedMembers(System.Diagnostics.CodeAnalysis.DynamicallyAccessedMemberTypes.PublicConstructors)] TClient>
	{
		/// <summary>
		/// Creates a typed client given an associated <see cref="T:System.Net.Http.HttpClient" />.
		/// </summary>
		/// <param name="httpClient">
		/// An <see cref="T:System.Net.Http.HttpClient" /> created by the <see cref="T:System.Net.Http.IHttpClientFactory" /> for the named client
		/// associated with <typeparamref name="TClient" />.
		/// </param>
		/// <returns>An instance of <typeparamref name="TClient" />.</returns>
		TClient CreateClient(HttpClient httpClient);
	}
}
