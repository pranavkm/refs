namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// A builder for configuring named <see cref="T:System.Net.Http.HttpClient" /> instances returned by <see cref="T:System.Net.Http.IHttpClientFactory" />.
	/// </summary>
	public interface IHttpClientBuilder
	{
		/// <summary>
		/// Gets the name of the client configured by this builder.
		/// </summary>
		string Name
		{
			get;
		}

		/// <summary>
		/// Gets the application service collection.
		/// </summary>
		IServiceCollection Services
		{
			get;
		}
	}
}
