using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.WebUtilities
{
	internal class MultipartBoundary
	{
		public bool ExpectLeadingCrlf
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

		public byte[] BoundaryBytes
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public int FinalBoundaryLength
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public MultipartBoundary(string boundary, bool expectLeadingCrlf = true)
		{
			throw null;
		}

		public int GetSkipValue(byte input)
		{
			throw null;
		}
	}
}
