using Microsoft.AspNetCore.Http.Features;
using System;
using System.IO;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http
{
	internal sealed class DefaultHttpResponse : HttpResponse
	{
		private struct FeatureInterfaces
		{
			public IHttpResponseFeature? Response;

			public IHttpResponseBodyFeature? ResponseBody;

			public IResponseCookiesFeature? Cookies;
		}

		public override HttpContext HttpContext
		{
			get
			{
				throw null;
			}
		}

		public override int StatusCode
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

		public override IResponseCookies Cookies
		{
			get
			{
				throw null;
			}
		}

		public override bool HasStarted
		{
			get
			{
				throw null;
			}
		}

		public override PipeWriter BodyWriter
		{
			get
			{
				throw null;
			}
		}

		public DefaultHttpResponse(DefaultHttpContext context)
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

		public override void OnStarting(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public override void OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public override void Redirect(string location, bool permanent)
		{
			throw null;
		}

		public override Task StartAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}

		public override Task CompleteAsync()
		{
			throw null;
		}
	}
}
