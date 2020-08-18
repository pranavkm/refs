using Microsoft.AspNetCore.HttpSys.Internal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Server.HttpSys
{
	internal sealed class Response
	{
		private enum ResponseState
		{
			Created,
			ComputedHeaders,
			Started,
			Closed
		}

		public int StatusCode
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

		public string ReasonPhrase
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

		public Stream Body
		{
			get
			{
				throw null;
			}
		}

		internal bool BodyIsFinished
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// The authentication challenges that will be added to the response if the status code is 401.
		/// This must be a subset of the AuthenticationSchemes enabled on the server.
		/// </summary>
		public AuthenticationSchemes AuthenticationChallenges
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

		public HeaderCollection Headers
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public HeaderCollection Trailers
		{
			get
			{
				throw null;
			}
		}

		internal bool HasTrailers
		{
			get
			{
				throw null;
			}
		}

		internal bool TrailersExpected
		{
			get
			{
				throw null;
			}
		}

		internal long ExpectedBodyLength
		{
			get
			{
				throw null;
			}
		}

		public long? ContentLength
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

		/// <summary>
		/// Enable kernel caching for the response with the given timeout. Http.Sys determines if the response
		/// can be cached.
		/// </summary>
		public TimeSpan? CacheTtl
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

		internal BoundaryType BoundaryType
		{
			get
			{
				throw null;
			}
		}

		internal bool HasComputedHeaders
		{
			get
			{
				throw null;
			}
		}

		/// <summary>
		/// Indicates if the response status, reason, and headers are prepared to send and can
		/// no longer be modified. This is caused by the first write or flush to the response body.
		/// </summary>
		public bool HasStarted
		{
			get
			{
				throw null;
			}
		}

		internal Response(RequestContext requestContext)
		{
			throw null;
		}

		internal void MakeTrailersReadOnly()
		{
			throw null;
		}

		internal void Abort()
		{
			throw null;
		}

		internal void Dispose()
		{
			throw null;
		}

		internal uint SendHeaders(HttpApiTypes.HTTP_DATA_CHUNK[] dataChunks, ResponseStreamAsyncResult asyncResult, HttpApiTypes.HTTP_FLAGS flags, bool isOpaqueUpgrade)
		{
			throw null;
		}

		internal HttpApiTypes.HTTP_FLAGS ComputeHeaders(long writeCount, bool endOfRequest = false)
		{
			throw null;
		}

		internal void SerializeTrailers(HttpApiTypes.HTTP_DATA_CHUNK[] dataChunks, int currentChunk, List<GCHandle> pins)
		{
			throw null;
		}

		internal void SendOpaqueUpgrade()
		{
			throw null;
		}

		internal void CancelLastWrite()
		{
			throw null;
		}

		public Task SendFileAsync(string path, long offset, long? count, CancellationToken cancel)
		{
			throw null;
		}

		internal void SwitchToOpaqueMode()
		{
			throw null;
		}
	}
}
