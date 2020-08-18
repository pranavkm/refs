using Microsoft.Extensions.ObjectPool;
using System;
using System.Text;

namespace Microsoft.AspNetCore.Http.Features
{
	/// <summary>
	/// Default implementation of <see cref="T:Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature" />.
	/// </summary>
	public class ResponseCookiesFeature : IResponseCookiesFeature
	{
		/// <inheritdoc />
		public IResponseCookies Cookies
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Initializes a new <see cref="T:Microsoft.AspNetCore.Http.Features.ResponseCookiesFeature" /> instance.
		/// </summary>
		/// <param name="features">
		/// <see cref="T:Microsoft.AspNetCore.Http.Features.IFeatureCollection" /> containing all defined features, including this
		/// <see cref="T:Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature" /> and the <see cref="T:Microsoft.AspNetCore.Http.Features.IHttpResponseFeature" />.
		/// </param>
		public ResponseCookiesFeature(IFeatureCollection features)
		{
			throw null;
		}

		/// <summary>
		/// Initializes a new <see cref="T:Microsoft.AspNetCore.Http.Features.ResponseCookiesFeature" /> instance.
		/// </summary>
		/// <param name="features">
		/// <see cref="T:Microsoft.AspNetCore.Http.Features.IFeatureCollection" /> containing all defined features, including this
		/// <see cref="T:Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature" /> and the <see cref="T:Microsoft.AspNetCore.Http.Features.IHttpResponseFeature" />.
		/// </param>
		/// <param name="builderPool">The <see cref="T:Microsoft.Extensions.ObjectPool.ObjectPool`1" />, if available.</param>
		[Obsolete("This constructor is obsolete and will be removed in a future version.")]
		public ResponseCookiesFeature(IFeatureCollection features, ObjectPool<StringBuilder>? builderPool)
		{
			throw null;
		}
	}
}
