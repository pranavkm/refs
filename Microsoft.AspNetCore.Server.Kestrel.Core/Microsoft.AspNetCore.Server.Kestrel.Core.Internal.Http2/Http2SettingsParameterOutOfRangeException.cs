using System;
using System.Runtime.CompilerServices;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Http2
{
	internal sealed class Http2SettingsParameterOutOfRangeException : Exception
	{
		public Http2SettingsParameter Parameter
		{
			[CompilerGenerated]
			get
			{
				throw null;
			}
		}

		public Http2SettingsParameterOutOfRangeException(Http2SettingsParameter parameter, long lowerBound, long upperBound)
		{
			throw null;
		}
	}
}
