using System;

namespace Microsoft.AspNetCore.HttpSys.Internal
{
	internal static class Constants
	{
		internal const string HttpScheme = "http";

		internal const string HttpsScheme = "https";

		internal const string Chunked = "chunked";

		internal const string Close = "close";

		internal const string Zero = "0";

		internal const string SchemeDelimiter = "://";

		internal const string DefaultServerAddress = "http://localhost:5000";

		internal static readonly Version V1_0;

		internal static readonly Version V1_1;

		internal static readonly Version V2;
	}
}
