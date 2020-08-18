using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;

namespace Microsoft.AspNetCore.Routing
{
	[DebuggerDisplay("{DebuggerToString(),nq}")]
	internal class UriBuildingContext
	{
		private readonly struct BufferValue
		{
			public bool RequiresEncoding
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public string Value
			{
				[CompilerGenerated]
				get
				{
					throw null;
				}
			}

			public BufferValue(string value, bool requiresEncoding)
			{
				throw null;
			}
		}

		public bool LowercaseUrls
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

		public bool LowercaseQueryStrings
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

		public bool AppendTrailingSlash
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

		public SegmentState BufferState
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public SegmentState UriState
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TextWriter PathWriter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public TextWriter QueryWriter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public UriBuildingContext(UrlEncoder urlEncoder)
		{
			throw null;
		}

		public bool Accept(string? value)
		{
			throw null;
		}

		public bool Accept(string? value, bool encodeSlashes)
		{
			throw null;
		}

		public void Remove(string literal)
		{
			throw null;
		}

		public bool Buffer(string? value)
		{
			throw null;
		}

		public void EndSegment()
		{
			throw null;
		}

		public void Clear()
		{
			throw null;
		}

		public override string ToString()
		{
			throw null;
		}

		public PathString ToPathString()
		{
			throw null;
		}

		public QueryString ToQueryString()
		{
			throw null;
		}

		internal void EncodeValue(string value, int start, int characterCount, bool encodeSlashes)
		{
			throw null;
		}
	}
}
