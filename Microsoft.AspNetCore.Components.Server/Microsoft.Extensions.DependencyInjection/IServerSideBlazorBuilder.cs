namespace Microsoft.Extensions.DependencyInjection
{
	/// <summary>
	/// A builder that can be used to configure Server-Side Blazor.
	/// </summary>
	public interface IServerSideBlazorBuilder
	{
		/// <summary>
		/// Gets the <see cref="T:Microsoft.Extensions.DependencyInjection.IServiceCollection" />.
		/// </summary>
		IServiceCollection Services
		{
			get;
		}
	}
}
