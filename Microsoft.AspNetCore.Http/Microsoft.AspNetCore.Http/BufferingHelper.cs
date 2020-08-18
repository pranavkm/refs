using Microsoft.AspNetCore.WebUtilities;
using System;

namespace Microsoft.AspNetCore.Http
{
	internal static class BufferingHelper
	{
		internal const int DefaultBufferThreshold = 30720;

		public static HttpRequest EnableRewind(this HttpRequest request, int bufferThreshold = 30720, long? bufferLimit = null)
		{
			throw null;
		}

		public static MultipartSection EnableRewind(this MultipartSection section, Action<IDisposable> registerForDispose, int bufferThreshold = 30720, long? bufferLimit = null)
		{
			throw null;
		}
	}
}
