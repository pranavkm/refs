namespace Microsoft.AspNetCore.Http.Features
{
	public class RequestCookiesFeature : IRequestCookiesFeature
	{
		public IRequestCookieCollection Cookies
		{
			get
			{
				throw null;
			}
			set
			{
				throw null;
			}
		}

		public RequestCookiesFeature(IRequestCookieCollection cookies)
		{
			throw null;
		}

		public RequestCookiesFeature(IFeatureCollection features)
		{
			throw null;
		}
	}
}
