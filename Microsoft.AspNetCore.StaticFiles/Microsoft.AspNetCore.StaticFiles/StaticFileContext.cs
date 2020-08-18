using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.Net.Http.Headers;
using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.StaticFiles
{
	internal struct StaticFileContext
	{
		internal enum PreconditionState : byte
		{
			Unspecified,
			NotModified,
			ShouldProcess,
			PreconditionFailed
		}

		[Flags]
		private enum RequestType : byte
		{
			Unspecified = 0x0,
			IsHead = 0x1,
			IsGet = 0x2,
			IsRange = 0x4
		}

		private readonly HttpContext _context;

		private readonly StaticFileOptions _options;

		private readonly HttpRequest _request;

		private readonly HttpResponse _response;

		private readonly ILogger _logger;

		private readonly IFileProvider _fileProvider;

		private readonly string _method;

		private readonly string _contentType;

		private IFileInfo _fileInfo;

		private EntityTagHeaderValue _etag;

		private RequestHeaders _requestHeaders;

		private ResponseHeaders _responseHeaders;

		private RangeItemHeaderValue _range;

		private long _length;

		private readonly PathString _subPath;

		private DateTimeOffset _lastModified;

		private PreconditionState _ifMatchState;

		private PreconditionState _ifNoneMatchState;

		private PreconditionState _ifModifiedSinceState;

		private PreconditionState _ifUnmodifiedSinceState;

		private RequestType _requestType;

		public bool IsHeadMethod
		{
			get
			{
				throw null;
			}
		}

		public bool IsGetMethod
		{
			get
			{
				throw null;
			}
		}

		public bool IsRangeRequest
		{
			get
			{
				throw null;
			}
		}

		public string SubPath
		{
			get
			{
				throw null;
			}
		}

		public string PhysicalPath
		{
			get
			{
				throw null;
			}
		}

		public StaticFileContext(HttpContext context, StaticFileOptions options, ILogger logger, IFileProvider fileProvider, string contentType, PathString subPath)
		{
			throw null;
		}

		public bool LookupFileInfo()
		{
			throw null;
		}

		public void ComprehendRequestHeaders()
		{
			throw null;
		}

		public void ApplyResponseHeaders(int statusCode)
		{
			throw null;
		}

		public PreconditionState GetPreconditionState()
		{
			throw null;
		}

		public Task SendStatusAsync(int statusCode)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CServeStaticFile_003Ed__47))]
		[DebuggerStepThrough]
		public Task ServeStaticFile(HttpContext context, RequestDelegate next)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendAsync_003Ed__48))]
		[DebuggerStepThrough]
		public Task SendAsync()
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CSendRangeAsync_003Ed__49))]
		[DebuggerStepThrough]
		internal Task SendRangeAsync()
		{
			throw null;
		}
	}
}
