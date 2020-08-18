namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides access to the current <see cref="P:Microsoft.AspNetCore.Http.IHttpContextAccessor.HttpContext" />, if one is available.
	/// </summary>
	/// <remarks>
	/// This interface should be used with caution. It relies on <see cref="T:System.Threading.AsyncLocal`1" /> which can have a negative performance impact on async calls.
	/// It also creates a dependency on "ambient state" which can make testing more difficult.
	/// </remarks>
	public interface IHttpContextAccessor
	{
		/// <summary>
		/// Gets or sets the current <see cref="P:Microsoft.AspNetCore.Http.IHttpContextAccessor.HttpContext" />. Returns <see langword="null" /> if there is no active <see cref="P:Microsoft.AspNetCore.Http.IHttpContextAccessor.HttpContext" />.
		/// </summary>
		HttpContext? HttpContext
		{
			get;
			set;
		}
	}
}
