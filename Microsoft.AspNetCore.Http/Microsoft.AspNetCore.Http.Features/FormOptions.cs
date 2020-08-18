using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Http.Features
{
	public class FormOptions
	{
		internal static readonly FormOptions Default;

		public const int DefaultMemoryBufferThreshold = 65536;

		public const int DefaultBufferBodyLengthLimit = 134217728;

		public const int DefaultMultipartBoundaryLengthLimit = 128;

		public const long DefaultMultipartBodyLengthLimit = 134217728L;

		/// <summary>
		/// Enables full request body buffering. Use this if multiple components need to read the raw stream.
		/// The default value is false.
		/// </summary>
		public bool BufferBody
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
		/// If <see cref="P:Microsoft.AspNetCore.Http.Features.FormOptions.BufferBody" /> is enabled, this many bytes of the body will be buffered in memory.
		/// If this threshold is exceeded then the buffer will be moved to a temp file on disk instead.
		/// This also applies when buffering individual multipart section bodies.
		/// </summary>
		public int MemoryBufferThreshold
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
		/// If <see cref="P:Microsoft.AspNetCore.Http.Features.FormOptions.BufferBody" /> is enabled, this is the limit for the total number of bytes that will
		/// be buffered. Forms that exceed this limit will throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public long BufferBodyLengthLimit
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
		/// A limit for the number of form entries to allow.
		/// Forms that exceed this limit will throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public int ValueCountLimit
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
		/// A limit on the length of individual keys. Forms containing keys that exceed this limit will
		/// throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public int KeyLengthLimit
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
		/// A limit on the length of individual form values. Forms containing values that exceed this
		/// limit will throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public int ValueLengthLimit
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
		/// A limit for the length of the boundary identifier. Forms with boundaries that exceed this
		/// limit will throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public int MultipartBoundaryLengthLimit
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
		/// A limit for the number of headers to allow in each multipart section. Headers with the same name will
		/// be combined. Form sections that exceed this limit will throw an <see cref="T:System.IO.InvalidDataException" />
		/// when parsed.
		/// </summary>
		public int MultipartHeadersCountLimit
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
		/// A limit for the total length of the header keys and values in each multipart section.
		/// Form sections that exceed this limit will throw an <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public int MultipartHeadersLengthLimit
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
		/// A limit for the length of each multipart body. Forms sections that exceed this limit will throw an
		/// <see cref="T:System.IO.InvalidDataException" /> when parsed.
		/// </summary>
		public long MultipartBodyLengthLimit
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

		public FormOptions()
		{
			throw null;
		}
	}
}
