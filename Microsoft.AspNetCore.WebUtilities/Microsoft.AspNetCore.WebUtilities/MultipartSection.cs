using Microsoft.Extensions.Primitives;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebUtilities
{
	public class MultipartSection
	{
		public string? ContentType
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		public string? ContentDisposition
		{
			[System.Runtime.CompilerServices.NullableContext(2)]
			get
			{
				throw null;
			}
		}

		public Dictionary<string, StringValues>? Headers
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
		/// Gets or sets the body.
		/// </summary>
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

		/// <summary>
		/// The position where the body starts in the total multipart body.
		/// This may not be available if the total multipart body is not seekable.
		/// </summary>
		public long? BaseStreamOffset
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

		public MultipartSection()
		{
			throw null;
		}
	}
}
