namespace Microsoft.AspNetCore.Hosting.Server.Abstractions
{
	/// <summary>
	/// When implemented by a Server allows an <see cref="T:Microsoft.AspNetCore.Hosting.Server.IHttpApplication`1" /> to pool and reuse
	/// its <typeparamref name="TContext" /> between requests.
	/// </summary>
	/// <typeparam name="TContext">The <see cref="T:Microsoft.AspNetCore.Hosting.Server.IHttpApplication`1" /> Host context</typeparam>
	public interface IHostContextContainer<TContext> where TContext : notnull
	{
		TContext HostContext
		{
			get;
			set;
		}
	}
}
