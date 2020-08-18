using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.WebUtilities
{
	public class MultipartReader
	{
		public const int DefaultHeadersCountLimit = 16;

		public const int DefaultHeadersLengthLimit = 16384;

		/// <summary>
		/// The limit for the number of headers to read.
		/// </summary>
		public int HeadersCountLimit
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

		/// <summary>
		/// The combined size limit for headers per multipart section.
		/// </summary>
		public int HeadersLengthLimit
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

		/// <summary>
		/// The optional limit for the total response body length.
		/// </summary>
		public long? BodyLengthLimit
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

		public MultipartReader(string boundary, Stream stream)
		{
			throw null;
		}

		public MultipartReader(string boundary, Stream stream, int bufferSize)
		{
			throw null;
		}

		[AsyncStateMachine(typeof(_003CReadNextSectionAsync_003Ed__20))]
		[DebuggerStepThrough]
		public Task<MultipartSection?> ReadNextSectionAsync(CancellationToken cancellationToken = default(CancellationToken))
		{
			throw null;
		}
	}
}
