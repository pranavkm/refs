using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http
{
	/// <summary>
	/// Provides an implementation of <see cref="T:Microsoft.AspNetCore.Http.IHttpContextAccessor" /> based on the current execution context. 
	/// </summary>
	public class HttpContextAccessor : IHttpContextAccessor
	{
		private class HttpContextHolder
		{
			public HttpContext? Context;

			public HttpContextHolder()
			{
				throw null;
			}
		}

		/// <inheritdoc />
		public HttpContext? HttpContext
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			set
			{
				throw null;
			}
		}

		public HttpContextAccessor()
		{
			throw null;
		}
	}
}
