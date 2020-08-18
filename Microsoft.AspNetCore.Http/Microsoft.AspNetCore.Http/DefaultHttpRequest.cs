using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Routing;
using System.IO;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	internal sealed class DefaultHttpRequest : HttpRequest
	{
		private struct FeatureInterfaces
		{
			public IHttpRequestFeature? Request;

			public IQueryFeature? Query;

			public IFormFeature? Form;

			public IRequestCookiesFeature? Cookies;

			public IRouteValuesFeature? RouteValues;

			public IRequestBodyPipeFeature? BodyPipe;
		}

		public override HttpContext HttpContext
		{
			get
			{
				throw null;
			}
		}

		public override PathString PathBase
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

		public override PathString Path
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

		public override QueryString QueryString
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

		public override long? ContentLength
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

		public override Stream Body
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

		public override string Method
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

		public override string Scheme
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

		public override bool IsHttps
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

		public override HostString Host
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

		public override IQueryCollection Query
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

		public override string Protocol
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

		public override IHeaderDictionary Headers
		{
			get
			{
				throw null;
			}
		}

		public override IRequestCookieCollection Cookies
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

		public override string ContentType
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

		public override bool HasFormContentType
		{
			get
			{
				throw null;
			}
		}

		public override IFormCollection Form
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

		public override RouteValueDictionary RouteValues
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

		public override PipeReader BodyReader
		{
			get
			{
				throw null;
			}
		}

		public DefaultHttpRequest(DefaultHttpContext context)
		{
			throw null;
		}

		public void Initialize()
		{
			throw null;
		}

		public void Initialize(int revision)
		{
			throw null;
		}

		public void Uninitialize()
		{
			throw null;
		}

		public override Task<IFormCollection> ReadFormAsync(CancellationToken cancellationToken)
		{
			throw null;
		}
	}
}
