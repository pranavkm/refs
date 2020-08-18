using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Http.Features
{
	public class HttpResponseFeature : IHttpResponseFeature
	{
		public int StatusCode
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public string? ReasonPhrase
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[System.Runtime.CompilerServices.NullableContext(2)]
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public IHeaderDictionary Headers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public Stream Body
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			set
			{
				throw null;
			}
		}

		public virtual bool HasStarted
		{
			get
			{
				throw null;
			}
		}

		public HttpResponseFeature()
		{
			throw null;
		}

		public virtual void OnStarting(Func<object, Task> callback, object state)
		{
			throw null;
		}

		public virtual void OnCompleted(Func<object, Task> callback, object state)
		{
			throw null;
		}
	}
}
